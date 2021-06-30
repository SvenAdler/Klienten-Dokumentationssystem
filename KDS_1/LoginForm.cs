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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string mailadresse = textBoxEmailAsNutzername.Text;

            string passwort = textBoxNutzerPasswort.Text;

            Program.conn.Open();
            MySqlCommand cmd = Program.conn.CreateCommand();
            cmd.CommandText = "SELECT nutzer_ID, vorname, nachname, mailadresse, arztnummer FROM kds.nutzer WHERE mailadresse = @mailadresse AND passwort = @passwort LIMIT 1";
            cmd.Parameters.AddWithValue("mailadresse", mailadresse);
            cmd.Parameters.AddWithValue("passwort", passwort);
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
