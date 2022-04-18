using Devart.Data.PostgreSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirm
{
    public class Datalayer
    {
        PgSqlConnection conn;
        PgSqlCommand cmd;

        public string getmessage { get; set; }
        public Datalayer()
        {
            string cs = "User Id=postgres;Host=localhost;Database=Firm;Password=12345;Persist Security Info=True;Initial Schema=public";
            conn = new PgSqlConnection(cs);
            cmd = new PgSqlCommand();

        }

        public bool connect()
        {
            try
            {
                conn.Open();
                getmessage = "Connect successfull";
                return true;
            }
            catch (Exception)
            {
                getmessage = "Connection Failed";
                return false;
            }
        }
        public bool close()
        {
            conn.Close();
            return true;
        }
    }
}
