using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KDS_1
{
    public partial class FormKDS : Form
    {
        private List<Klient> alleKlienten = new List<Klient>();
        private Dictionary<long, Klient> alleKlientenById = new Dictionary<long, Klient>();
        private List<Eintrag> bisherigeGespraeche = new List<Eintrag>();

        public FormKDS()
        {
            InitializeComponent();
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

        public void AddKlient(Klient k)
        {
            alleKlienten.Add(k);
            listBoxKlienten.Items.Add(k.ToString());
        }

        private void klientHinzufuegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKlientenRegistrierung frmKlient = new FormKlientenRegistrierung(this);
            frmKlient.ShowDialog();
        }

        private void klientEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie diesen Klienten entgültig entfernen?", "Klient entfernen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                alleKlienten.RemoveAt(index);
                listBoxKlienten.Items.Remove(klientDel.ToString());
            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anwendung beenden?", "Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void AddBisherigesGespraechToListBox(Eintrag e)
        {
            bisherigeGespraeche.Add(e);
            listBoxListeBisherigerGespraeche.Items.Add(e.ToString());
        }

        private void listBoxKlienten_DoubleClick(object sender, EventArgs e)
        {
            GespraecheLaden();
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
            cmd.CommandText = "SELECT e.Eintraege_ID, e.eintrag, e.datumEintrag, e.fk_nutzer_ID, n.nachname, n.arztnummer"
           + " FROM kds.eintraege e"
           + " LEFT OUTER JOIN kds.nutzer n ON n.nutzer_ID = e.fk_nutzer_ID"
           + " WHERE fk_klient_id =  " + bearbeiteterKlient.ID
           + " ORDER BY e.datumEintrag DESC";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nutzername = reader.GetString(4) + " - " + reader.GetString(5);
                AddBisherigesGespraechToListBox(new Eintrag(reader.GetInt64(0), reader.GetString(1), reader.GetDateTime(2), reader.GetInt64(3), nutzername));
            }
            reader.Close();
            Program.conn.Close();
        }

        private void buttonGespraechSpeichern_Click(object sender, EventArgs e)
        {
            long logNutzer = Program.eingeloggterNutzer.ID;

            //DateTime heutigesDatum = DateTime.Now;

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

            bearbeiteterKlient = alleKlienten[index];
            if (bearbeiteterEintrag == null)
            {
                Program.conn.Open();
                MySqlCommand cmd = Program.conn.CreateCommand();

                // Eintrag für diesen Klient erstellen
                cmd = Program.conn.CreateCommand();
                cmd.CommandText = "INSERT INTO kds.eintraege (eintrag, datumEintrag, fk_nutzer_ID, fk_klient_ID) VALUES (@eintrag, NOW(), @fk_nutzer_id, @fk_klient_id)";
                cmd.Parameters.AddWithValue("eintrag", eintrag);
                //cmd.Parameters.AddWithValue("datumEintrag", heutigesDatum);
                cmd.Parameters.AddWithValue("fk_nutzer_id", logNutzer); // ID des eingeloggten Nutzers einfügen
                cmd.Parameters.AddWithValue("fk_klient_id", bearbeiteterKlient.ID);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                Program.conn.Close();
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

            // TODO Einträge sollen auch andere Schriftarten, Größen oder Farben anzeigen, wenn diese bearbeitet werden
        }

        private void buttonGespraechsDokuAbbrechen_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.panelEintragKlientDoku);
            this.Controls.Add(this.panelMainWindow);

            bisherigeGespraeche.Clear();
            listBoxListeBisherigerGespraeche.Items.Clear();
        }

        private Eintrag bearbeiteterEintrag = null;
        private void listBoxListeBisherigerGespraeche_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxListeBisherigerGespraeche.SelectedIndex;
            if (index < 0 || index >= bisherigeGespraeche.Count)
            {
                bearbeiteterEintrag = null;
            }
            else
            {
                bearbeiteterEintrag = bisherigeGespraeche[index];
            }
            textBoxGespraechEintrag.Text = bearbeiteterEintrag == null ? "" : bearbeiteterEintrag.Gespraech;
        }

        private void listBoxListeBisherigerGespraeche_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxListeBisherigerGespraeche.IndexFromPoint(e.Location) < 0)
            {
                listBoxListeBisherigerGespraeche.ClearSelected();
            }
        }

        // TODO Abmelde Button 
        // Zurück zum Login um anderen Nutzer anzumelden

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

            //Platzhalter automatisches Login des ersten Nutzers und Testnutzer
            //Program.conn.Open();
            //MySqlCommand cmd = Program.conn.CreateCommand();
            //cmd.CommandText = "SELECT nutzer_ID, vorname, nachname, mailadresse, arztnummer FROM kds.nutzer WHERE mailadresse = 'a@a.de' AND passwort = 'm8NFSdVl2VBbKH3gzSCsd74dPyw=' LIMIT 1";
            //MySqlDataReader reader = cmd.ExecuteReader();
            //reader.Read();

            //Program.eingeloggterNutzer = new Nutzer(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));

            //reader.Close();
            //Program.conn.Close();
            //KlientenDatenLadenMainWin();
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO Einträge Exportieren als JSON
            // Nutzung vom NuGet-Paket Newtonsoft.JSON
        }

        private void sendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO E-Mail funktion 
            // Wahrscheinlich in eigener Form 
            // Testen mit Gmail, um Googles SMTP-Server zu nutzen
            // oder mit cloudbasierten Alternativen wie AWS
            // JSON mit Einträgen automatisch als Anhang 
        }
    }
}

