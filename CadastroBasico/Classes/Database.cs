using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestaoUnipResort.Classes
{
    class Database
    {
        public SqlConnection con = new SqlConnection();

        public Database ()
        {
            con.ConnectionString = @"Data Source=localhost;Initial Catalog=UNIP_RESORT;Integrated Security=True"; 
        }

        public SqlConnection conectar ()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }   

        public void desconectar ()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
