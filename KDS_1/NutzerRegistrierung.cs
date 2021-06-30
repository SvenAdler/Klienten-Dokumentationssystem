using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace KDS_1
{
    public partial class NutzerRegistrierung : Form
    {
        public LoginForm LoginForm;

        public NutzerRegistrierung(LoginForm loginForm)
        {
            this.LoginForm = loginForm;
            InitializeComponent();
        }

        private void buttonRegistrierungSpeichern_Click(object sender, EventArgs e)
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

            string mailadresse = textBoxMailadresse.Text;
            if (mailadresse.Length == 0 || mailadresse.Length > 50)
            {
                return;
            }

            string arztnummer = textBoxArztnummer.Text;
            if (arztnummer.Length == 0 || arztnummer.Length > 9)
            {
                MessageBox.Show("Länge einer Arztnummer ist höchstens 9 Zeichen!");
                return;
            }

            string passwort = textBoxPasswort.Text;
            if (passwort.Length == 0 || passwort.Length < 8 || passwort.Length > 200)
            {
                MessageBox.Show("Bitte geben Sie ein Passwort mit mindestens 8 und höchstens 200 Zeichen ein.");
                return;
            }

            Program.conn.Open();

            //Klient erstellen
            MySqlCommand cmd = Program.conn.CreateCommand();
            cmd.CommandText = "INSERT INTO kds.nutzer(vorname,nachname,mailadresse,arztnummer, passwort) VALUES (@vorname, @nachname, @mailadresse, @arztnummer, @passwort)";
            cmd.Parameters.AddWithValue("vorname", vorname);
            cmd.Parameters.AddWithValue("nachname", nachname);
            cmd.Parameters.AddWithValue("arztnummer", arztnummer);
            cmd.Parameters.AddWithValue("mailadresse", mailadresse);
            cmd.Parameters.AddWithValue("passwort", passwort); // TODO Passwort hashen!  
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            Program.conn.Close();

            this.Close();
        }
    }
}
