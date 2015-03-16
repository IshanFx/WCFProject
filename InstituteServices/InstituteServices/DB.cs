using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;

namespace InstituteServices
{
    public class DB
    {
        string con = ConfigurationManager.ConnectionStrings["Studb"].ConnectionString;
        public MySqlConnection conn;
        public MySqlCommand cmd;
        public DB()
        {
            conn = new MySqlConnection(con);

        }
        int chk;
        public int DMLQuery(string sql)
        {
            
                chk = 0;
                cmd = new MySqlCommand(sql, conn);
                conn.Open();
                chk = cmd.ExecuteNonQuery();
                conn.Close();
          
            return chk;

        }
        public DataTable SelectQuery(string sql)
        {
            cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            conn.Open();
            adp.Fill(table);
            conn.Close();
            return table;

        }

        public int GetLastIdQuery(string sql) {
            cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int lastId =int.Parse( cmd.ExecuteScalar().ToString());
            conn.Close();
            return lastId;

        }

    }
}
