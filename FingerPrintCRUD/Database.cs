using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace FingerPrintCRUD
{
    internal class Database
    {
        public static string connection_string = "User Id=root;Password=Bismillah098;Data Source=127.0.0.1;Port=3308;Database=fingerprint;";
        public MySqlConnection connectdb = new MySqlConnection(connection_string);

    }
}
