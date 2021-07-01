using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace KDS_1
{
    public partial class FormKlientenRegistrierung : Form
    {

        public FormKDS FormKDS;

        public FormKlientenRegistrierung(FormKDS kds)
        {
            this.FormKDS = kds;
            InitializeComponent();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            string vorname = textBoxVorname.Text;
            if (vorname.Length == 0 || vorname.Length > 45)
            {
                return;
            }

            string nachname = textBoxNachname.Text;
            if (nachname.Length == 0 || nachname.Length > 45)
            {
                return;
            }

            string klientennr = textBoxKlientennr.Text;
            if (klientennr.Length == 0 || klientennr.Length > 12)
            {
                return;
            }

            int alter = DateTime.Today.Year - dateTimePickerGeburtsdatum.Value.Year;
            if (alter < 18)
            {
                MessageBox.Show("Es können ausschließlich erwachsene Klienten angelegt werden.");
                return;
            }

            string erstgespraechEintrag = textBoxErstgespraech.Text;
            if (erstgespraechEintrag.Length == 0)
            {
                MessageBox.Show("Bitte tragen Sie das Erstgespräch oder eine Kurznotiz ein.");
                return;
            }

            Program.conn.Open();

            // TODO Transactions 
            //conn.BeginTransaction();

            //Klient erstellen
            MySqlCommand cmd = Program.conn.CreateCommand();
            cmd.CommandText = "INSERT INTO kds.klient(vorname,nachname,geburtsdatum,klientennr) VALUES (@vorname, @nachname, @geburtsdatum, @klientennr)";
            cmd.Parameters.AddWithValue("vorname", vorname);
            cmd.Parameters.AddWithValue("nachname", nachname);
            cmd.Parameters.AddWithValue("geburtsdatum", DateTime.Parse(dateTimePickerGeburtsdatum.Text));
            cmd.Parameters.AddWithValue("klientennr", klientennr);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            long klient_id = cmd.LastInsertedId;

            // Ersten Eintrag für diesen Klient erstellen
            cmd = Program.conn.CreateCommand();
            cmd.CommandText = "INSERT INTO kds.eintraege (eintrag, fk_nutzer_ID, fk_klient_ID) VALUES (@eintrag, @fk_nutzer_id, @fk_klient_id)";
            cmd.Parameters.AddWithValue("eintrag", erstgespraechEintrag);
            cmd.Parameters.AddWithValue("fk_nutzer_id", Program.eingeloggterNutzer.ID); // ID des eingeloggten Nuters einfügen
            cmd.Parameters.AddWithValue("fk_klient_id", klient_id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            long erstgespraech_id = cmd.LastInsertedId;

            // Ersten Eintrag als Erstgespräch für den Klienten registrieren
            cmd = Program.conn.CreateCommand();
            cmd.CommandText = "UPDATE kds.klient SET fk_erstgespraech_id = @erstgespraech_id WHERE klient_id = @klient_id";
            cmd.Parameters.AddWithValue("erstgespraech_id", erstgespraech_id);
            cmd.Parameters.AddWithValue("klient_id", klient_id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            //conn.EndTransaction();
            Program.conn.Close();

            Klient k = new Klient(klient_id, vorname, nachname, dateTimePickerGeburtsdatum.Value, klientennr, erstgespraech_id);
            FormKDS.AddKlient(k);

            DialogResult = DialogResult.OK;
            this.Close();

            // TODO Datum 
            // evtl Datum hinzufügen... 
        }
    }
}
