using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28.Context
{
    class AppDbContext
    {
        const string con = " server=DESKTOP-O23G9HC ; database= AB109_Ado;Trusted_connection=true";
        SqlConnection sqlConnection = new SqlConnection(con);
        public int ExecuteNonQuery(string command)
        {

            sqlConnection.Open();
            SqlCommand sql = new SqlCommand(command, sqlConnection);
            int result = sql.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }
        public DataTable ExecuteQuery(string query)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

    }
}
}
