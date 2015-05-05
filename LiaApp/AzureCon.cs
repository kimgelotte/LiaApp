using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace LiaApp
{
    class AzureCon
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["AzureConnection"].ToString();
            }
        }

        public static DataTable GetKlasses(string klass)
        {
            DataTable table = new DataTable("Student");
            SqlDataAdapter dataA = null;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student WHERE ClassNamn = @Cnamn", conn);
                cmd.Parameters.Add(new SqlParameter("Cnamn", SqlDbType.VarChar, 10));
                cmd.Parameters["Cnamn"].Value = klass;

                dataA = new SqlDataAdapter(cmd);

                int res = dataA.Fill(table);
            }

            return table;
        }
    }
}
