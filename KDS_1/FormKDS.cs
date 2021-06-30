using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KDS_1
{
    public partial class FormKDS : Form
    {
        // In FormKDSDesigner.cs muss this.Controls.Add(this.panelEintragKlientDoku); einkommentiert werden
        // um des anzeigen zu lassen! 

        private List<Klient> alleKlienten = new List<Klient>();
        private Dictionary<long, Klient> alleKlientenById = new Dictionary<long, Klient>();
        private List<Eintrag> bisherigeGespraeche = new List<Eintrag>();

        public FormKDS()
        {
            InitializeComponent();
        }

        public void AddKlient(Klient k)
        {
            alleKlienten.Add(k);
            listBoxKlienten.Items.Add(k.ToString());
        }

        private void KlientenDatenLadenMainWin()
        {
            Program.conn.Open();
            MySqlCommand cmd = Program.conn.CreateCommand();
            cmd.CommandText = "SELECT klient_id,vorname,nachname,geburtsdatum,klientennr,fk_erstgespraech_ID FROM kds.klient ORDER BY klientennr";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Klient klient = new Klient(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4), reader.GetInt64(5));
                alleKlienten.Add(klient);
                alleKlientenById[klient.ID] = klient;
                listBoxKlienten.Items.Add(klient.ToString());
            }
            reader.Close();
            Program.conn.Close();
        }

        private void klientHinzufuegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKlientenRegistrierung frmKlient = new FormKlientenRegistrierung(this);
            frmKlient.ShowDialog();
        }

        private void klientEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = listBoxKlienten.SelectedIndex;
            if (index < 0 || index >= alleKlienten.Count)
            {
                return;
            }
            Klient klientDel = alleKlienten[index];
            Program.conn.Open();
            MySqlCommand cmd = Program.conn.CreateCommand();
            cmd.CommandText = "DELETE FROM kds.klient WHERE klient_id =" + klientDel.ID;
            cmd.ExecuteNonQuery();
            Program.conn.Close();
            // GUI pflegen 
            alleKlienten.RemoveAt(index);
            listBoxKlienten.Items.Remove(klientDel.ToString());
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO Program beenden mit entsprechendem MenuToolStrip 
            // Programm soll sich schließen, aber mit vorheriger Abfrage, ob man sich sicher ist

            //     while (MessageBox.Show("Exit application?", "", MessageBoxButtons.YesNo) ==
            //DialogResult.No)
            //     {

            //     }
        }

        // TODO Exportieren und Importieren 
        // Import über Daten öffnen Button? 

        public void AddBisherigesGespraechToListBox(Eintrag e)
        {
            bisherigeGespraeche.Add(e);
            listBoxListeBisherigerGespraeche.Items.Add(e.ToString());
        }

        private void listBoxKlienten_DoubleClick(object sender, EventArgs e)
        {

            GespraecheLaden();
            // TODO Anzeige verschönern 
            // eventuell nur den Nachnamen des Nutzers anzeigen lassen. 
            // Datum eines Gesprächs? Datenbank verändern
        }

        Klient bearbeiteterKlient = null;
        private void GespraecheLaden()
        {
            int index = listBoxKlienten.SelectedIndex;
            if (index < 0 || index >= alleKlienten.Count)
            {
                return;
            }
            bearbeiteterKlient = alleKlienten[index];
            labelAktuellerKlient.Text = bearbeiteterKlient.Nachname + ", " + bearbeiteterKlient.Vorname;

            this.Controls.Remove(this.panelMainWindow);
            this.Controls.Add(this.panelEintragKlientDoku);

            bisherigeGespraeche.Clear();
            listBoxListeBisherigerGespraeche.Items.Clear();
            bearbeiteterEintrag = null;
            textBoxGespraechEintrag.Text = "";

            Program.conn.Open();
            MySqlCommand cmd = Program.conn.CreateCommand();
            cmd.CommandText = "SELECT e.Eintraege_ID, e.eintrag, e.fk_nutzer_ID, n.nachname, n.vorname, n.arztnummer "
           + "FROM kds.eintraege e "
           + "LEFT OUTER JOIN kds.nutzer n ON n.nutzer_ID = e.fk_nutzer_ID "
           + "WHERE fk_klient_id =  " + bearbeiteterKlient.ID;
            //+ "ORDER BY e.Eintraege_ID DESC";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nutzername = reader.GetString(4) + " " + reader.GetString(3) + " " + reader.GetString(5);
                AddBisherigesGespraechToListBox(new Eintrag(reader.GetInt64(0), reader.GetString(1), reader.GetInt64(2), nutzername));
            }
            reader.Close();
            Program.conn.Close();
        }

        private void buttonGespraechsDokuAbbrechen_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.panelEintragKlientDoku);
            this.Controls.Add(this.panelMainWindow);

            bisherigeGespraeche.Clear();
            listBoxListeBisherigerGespraeche.Items.Clear();
        }

        // TODO Bisherige Gespräche
        // Entweder in neuer Form ausgewähltes Gespräch anzeigen lassen
        // oder in einem neuen Panel über dem Gespräch dokumentieren Panel (eher neue Form) 


        private void buttonGespraechSpeichern_Click(object sender, EventArgs e)
        {
            // Reihenfolge der Liste korrekt anzeigen lassen

            string eintrag = textBoxGespraechEintrag.Text;
            if (eintrag.Length == 0)
            {
                MessageBox.Show("Tragen Sie ein Gespräch ein oder wählen eines zum bearbeiten aus.");
                return;
            }

            int index = listBoxKlienten.SelectedIndex;
            if (index < 0 || index >= alleKlienten.Count)
            {
                return;
            }

            long logNutzer = Program.eingeloggterNutzer.ID;

            bearbeiteterKlient = alleKlienten[index];
            

            if (bearbeiteterEintrag == null)
            {
                Program.conn.Open();
                MySqlCommand cmd = Program.conn.CreateCommand();

                // Eintrag für diesen Klient erstellen
                cmd = Program.conn.CreateCommand();
                cmd.CommandText = "INSERT INTO kds.eintraege (eintrag, fk_nutzer_ID, fk_klient_ID) VALUES (@eintrag, @fk_nutzer_id, @fk_klient_id) ";
                cmd.Parameters.AddWithValue("eintrag", eintrag);
                cmd.Parameters.AddWithValue("fk_nutzer_id", logNutzer); // ID des eingeloggten Nutzers einfügen
                cmd.Parameters.AddWithValue("fk_klient_id", bearbeiteterKlient.ID);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                Program.conn.Close();
                long eintrag_id = cmd.LastInsertedId;
            }
            else
            {
                Program.conn.Open();
                MySqlCommand cmd = Program.conn.CreateCommand();

                cmd = Program.conn.CreateCommand();
                cmd.CommandText = "UPDATE kds.eintraege SET eintrag = @eintrag WHERE fk_nutzer_id = @fk_nutzer_id AND fk_klient_id = @fk_klient_id";
                cmd.Parameters.AddWithValue("eintrag", eintrag);
                cmd.Parameters.AddWithValue("fk_nutzer_id", logNutzer);
                cmd.Parameters.AddWithValue("fk_klient_id", bearbeiteterKlient.ID);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                Program.conn.Close();
            }

            textBoxGespraechEintrag.Clear();
            listBoxListeBisherigerGespraeche.Items.Clear();
            GespraecheLaden();
        }

        private Eintrag bearbeiteterEintrag = null;
        private void listBoxListeBisherigerGespraeche_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxListeBisherigerGespraeche.SelectedIndex;
            if (index < 0 || index >= alleKlienten.Count)
            {
                bearbeiteterEintrag = null;
            }
            else
            {
                bearbeiteterEintrag = bisherigeGespraeche[index];
            }
            textBoxGespraechEintrag.Text = bearbeiteterEintrag == null ? "" : bearbeiteterEintrag.Gespraech;
        }

        /**
         * Sektion Nutzer Login und Registrierung
        **/

        private void FormKDS_Shown(object sender, EventArgs e)
        {
            // Echtes Login mit LoginForm
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            if (lf.DialogResult != DialogResult.OK)
            {
                Close();
            }
            else
            {
                KlientenDatenLadenMainWin();
            }

            //Platzhalter automatisches Login des ersten Nutzers!
            //Program.conn.Open();
            //MySqlCommand cmd = Program.conn.CreateCommand();
            //cmd.CommandText = "SELECT nutzer_ID, vorname, nachname, mailadresse, arztnummer FROM kds.nutzer WHERE mailadresse = 'H.Adler@praxis.de' AND passwort = 'fas3234' LIMIT 1"; // Testnutzer aus Datenbank! 
            //MySqlDataReader reader = cmd.ExecuteReader();
            //reader.Read();

            //Program.eingeloggterNutzer = new Nutzer(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));

            //reader.Close();
            //Program.conn.Close();
            //KlientenDatenLadenMainWin();
        }
    }
}


// TODO Abmelde Button 
// Zurück zum Login um anderen Nutzer anzumelden