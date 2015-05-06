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

        public static DataTable klasstable(string klassN)
        {
            DataTable table = new DataTable("Klassinfo");
            SqlDataAdapter dataA = null;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Namn, PostAdress, PostNummer, Examen, MejlAdress FROM Student WHERE ClassNamn = @KlassN", conn);
                cmd.Parameters.Add(new SqlParameter("KlassN", SqlDbType.VarChar, 10));
                cmd.Parameters["KlassN"].Value = klassN;

                dataA = new SqlDataAdapter(cmd);

                int res = dataA.Fill(table);

                return table;
            }
        }

        public static DataTable LIAtable(string klassLIA)
        {
            DataTable table = new DataTable("LIAinfo");
            SqlDataAdapter dataA = null;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT LIA_Period, Student_Id, StartDate, EndDate, Company, Visit_Id " + 
                "FROM LIA INNER JOIN Student ON LIA.Student_Id = Student.Id " + 
                "WHERE ClassNamn = @LIAinfo", conn);
                cmd.Parameters.Add(new SqlParameter("LIAinfo", SqlDbType.VarChar, 10));
                cmd.Parameters["LIAinfo"].Value = klassLIA;

                dataA = new SqlDataAdapter(cmd);

                int res = dataA.Fill(table);

                return table;
            }
        }
    }
}
