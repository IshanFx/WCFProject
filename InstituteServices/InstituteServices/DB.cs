using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace InstituteServices
{
    public class DB
    {
        string con = ConfigurationManager.ConnectionStrings["Studb"].ConnectionString;
        public MySqlConnection conn;
        public MySqlCommand cmd;
        MySqlDataReader read;
        string status;
        byte[] image;

        public DB()
        {
            conn = new MySqlConnection(con);

        }

        public int DMLQuery(string sql)
        {
            int chk = 0;
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
            if(lastId==0)
            {
                lastId = 1;
            }
            else
            {
                lastId += 1;
            }
            return lastId;

        }

        public string GetData(string sql)
        {
            status = null;
            cmd = new MySqlCommand(sql, conn);
            conn.Open();
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                status = read[0].ToString();
            }
            conn.Close();
            return status;
        }

        public void ImageSave(string path, string sql)
        {
            conn.Open();
            FileStream fs;
            Byte[] bindata;
            MySqlParameter picpara;
            cmd = new MySqlCommand(sql, conn);
            picpara = cmd.Parameters.Add("?pic", MySqlDbType.MediumBlob);
            cmd.Prepare();
            fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            bindata = new byte[Convert.ToInt32(fs.Length)];
            fs.Read(bindata, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            picpara.Value = bindata;
            cmd.ExecuteNonQuery();
        }

        public Image GetImage(string sql)
        {
            Image img = null;

            cmd = new MySqlCommand(sql, conn);
            conn.Open();
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                image = (byte[])(read["photo"]);
            }

            MemoryStream mst = new MemoryStream(image);
            img = System.Drawing.Image.FromStream(mst);
            conn.Close();

            return img;
        }
    }
}
