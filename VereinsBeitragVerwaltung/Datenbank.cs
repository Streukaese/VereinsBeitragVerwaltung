using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VereinsBeitragVerwaltung
{
    internal class Datenbank
    {
        static private MySqlConnection conn = null;
        static public void Open()
        {
            conn = new MySqlConnection("Server=localhost;Uid=root;Pwd=;Database=fußball;");
            conn.Open();
        }

        static public MySqlCommand CreateCommand()
        {
            return conn.CreateCommand();
        }
        static public void Close()
        {
            conn.Close();
            conn = null;
        }
    }
}
