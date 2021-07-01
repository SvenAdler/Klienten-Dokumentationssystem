using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace KDS_1
{
    static class Program
    {
        public static MySqlConnection conn = new MySqlConnection("Server=localhost;Uid=root;Pwd=root;Database=kds;");
        public static Nutzer eingeloggterNutzer = null;
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new KDSMainWindow());
            
            // Neues Hauptfenster festlegen nach login !! 
        }
    }
}
