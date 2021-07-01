using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace KDS_1
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabelNutzerRegistrieren_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NutzerRegistrierung nutzerReg = new NutzerRegistrierung(this);
            nutzerReg.ShowDialog();
        }

        public bool MailadressePruefen(string s)
        {
            // TODO evtl. in REGEX ändern 
            if (s.Length == 0)
            {
                return false;
            }
            int iat = s.IndexOf('@');
            if (iat < 0)
            {
                return false;
            }
            int iat2 = s.IndexOf('@', iat + 1);
            if (iat2 >= 0)
            {
                return false;
            }
            int ipunkt = s.IndexOf('.', iat + 1);
            if (ipunkt < 0)
            {
                return false;
            }
            if (ipunkt == iat + 1)
            {
                return false;
            }
            if (s[s.Length - 1] == '.')
            {
                return false;
            }
            return true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // TODO Bedingungen passwort
            string mailadresse = textBoxEmailAsNutzername.Text;
            if (!MailadressePruefen(mailadresse))
            {
                MessageBox.Show("Bitte eine valide Mailadresse eingeben.");
                return;
            }

            string passwort = textBoxNutzerPasswort.Text;

            Program.conn.Open();
            MySqlCommand cmd = Program.conn.CreateCommand();
            cmd.CommandText = "SELECT nutzer_ID, vorname, nachname, mailadresse, arztnummer FROM kds.nutzer WHERE mailadresse = @mailadresse AND passwort = @passwort LIMIT 1";
            cmd.Parameters.AddWithValue("mailadresse", mailadresse);
            cmd.Parameters.AddWithValue("passwort", HashClass.SHA1HashPasswort(passwort));
            cmd.Prepare();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Program.eingeloggterNutzer = new Nutzer(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Nutzer nicht vorhanden oder falsches Passwort eingegeben!");
            }

            reader.Close();
            Program.conn.Close();
        }
    }
}
