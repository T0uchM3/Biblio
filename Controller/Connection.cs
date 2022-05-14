using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

//Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
namespace CONTROLLER
{
    public class Connection
    {
        SqlConnection conn = new SqlConnection(@"database=Biblio;server=LENOVO242\SQL2K14;User ID=sa;pwd=pass");

        public Connection()
        {
            conn.Open();
        }

        public Boolean executeCommand(SqlCommand cmd)
        {
            cmd.Connection = conn;

            if (cmd.ExecuteNonQuery() >= 1)
                return true;
            else
                return false;
        }

        public SqlDataReader SDD(string cmdch)
        {
            SqlCommand command = new SqlCommand(cmdch);
            command.Connection = conn;
            return command.ExecuteReader();
        }

        public SqlDataReader SDD2(SqlCommand cmd)
        {
            cmd.Connection = conn;
            return cmd.ExecuteReader();
        }
    }
}