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
                return ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
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

        public static DataTable StudentSearchFor(string SocialNumber)
        {
            DataTable table = new DataTable("Studentinfo");
            SqlDataAdapter dataA = null;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT PersonNummer, Student.Namn, Company, LIA.Visit_Id, VisitDate, Personal.PNamn, Personal.Telefon " +
                "FROM Student INNER JOIN LIA ON Student.Id = LIA.Student_Id " +
                "INNER JOIN PersonalVisits ON LIA.Visit_Id = PersonalVisits.Visit_Id " +
                "INNER JOIN Personal ON PersonalVisits.P_Id = Personal.P_Id " +
                "WHERE PersonNummer = @SocialNumber", conn);
                cmd.Parameters.Add(new SqlParameter("SocialNumber", SqlDbType.VarChar, 12));
                cmd.Parameters["SocialNumber"].Value = SocialNumber;

                dataA = new SqlDataAdapter(cmd);
                int res = dataA.Fill(table);
                return table;
            }
        }

        public static DataTable PersonalFormQuery(string Klass)
        {
            DataTable table = new DataTable("PersonalQuery");
            SqlDataAdapter dataA = null;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Student.Namn AS 'Student Name', LIA.Company AS Company, KontaktPerson.Namn AS Mentor, VisitDate as 'Visit Date', Personal.PNamn AS 'Staff Name', Student.MejlAdress AS 'Student E-mail' " +
                "FROM Student INNER JOIN LIA ON Student.Id = LIA.Student_Id " +
                "INNER JOIN PersonalVisits ON LIA.Visit_Id = PersonalVisits.Visit_Id " +
                "INNER JOIN Personal ON PersonalVisits.P_Id = Personal.P_Id " +
                "INNER JOIN Företag ON Lia.Company = Företag.Företag " +
                "INNER JOIN KontaktPerson ON Företag.Företag = KontaktPerson.Företag " +
                "WHERE ClassNamn = @Klass", conn);
                cmd.Parameters.Add(new SqlParameter("Klass", SqlDbType.VarChar, 12));
                cmd.Parameters["Klass"].Value = Klass;

                dataA = new SqlDataAdapter(cmd);
                int res = dataA.Fill(table);
                return table;
            }
        }

        public static DataTable tableFrom()
        {
            DataTable table = new DataTable("dbTable");
            SqlDataAdapter dataA = null;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM PersonalVisits", conn);
                //cmd.Parameters.Add(new SqlParameter("databasetable", table));
                //cmd.Parameters["databasetable"].Value = dbTable;

                dataA = new SqlDataAdapter(cmd);
                int res = dataA.Fill(table);
                return table;
            }
        }

        public static void BookingNewMeeting(int VisitId, int PersonalId, string Date, string IsDone)
        {
            DataTable table = new DataTable("newBooking");
            SqlDataAdapter dataA = null;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO PersonalVisits " +
                    "VALUES (@VisitId,@PersonalId,@Date,@IsDone);", conn);
                cmd.Parameters.AddWithValue("@VisitId", VisitId);
                cmd.Parameters.AddWithValue("@PersonalId", PersonalId);
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@IsDone", IsDone);

                dataA = new SqlDataAdapter(cmd);
                int res = dataA.Fill(table);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public static DataTable BookingPNamnForms()
        {
            DataTable table = new DataTable("fact");
            SqlDataAdapter dataA = null;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Personal.PNamn FROM Personal", conn);
                dataA = new SqlDataAdapter(cmd);
                int res = dataA.Fill(table);
                
                return table;
            }
        }

        public static DataTable BookingElevNamnForms()
        {
            DataTable table = new DataTable("ElevNamnWithLia");
            SqlDataAdapter dataA = null;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Namn FROM Student INNER JOIN LIA ON Student.Id = LIA.Student_Id", conn);
                dataA = new SqlDataAdapter(cmd);
                int res = dataA.Fill(table);
                return table;
            }
        }

        
        public static DataTable FindPersonal(string StaffName)
        {
            DataTable table = new DataTable("StaffInfo");
            SqlDataAdapter dataA = null;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Personal WHERE PNamn = @PersonNamn", conn);
                cmd.Parameters.AddWithValue("PersonNamn", StaffName);
                dataA = new SqlDataAdapter(cmd);
                int res = dataA.Fill(table);
                return table;
            }
        }

        public static int CountBook()
        {
            DataTable table = new DataTable("Visitcounts");
            SqlDataAdapter dataA = null;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Visit_Id FROM PersonalVisits", conn);
                dataA = new SqlDataAdapter(cmd);
                int res = dataA.Fill(table);
                return res;
            }
        }

        public static DataTable FindClass(string klass)
        {
            DataTable table = new DataTable("dbTable");
            SqlDataAdapter dataA = null;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM @table", conn);
                cmd.Parameters.AddWithValue("@table", klass);

                dataA = new SqlDataAdapter(cmd);
                int res = dataA.Fill(table);
                return table;
            }
        }

        public static void BookingNewMeeting2(int VisitId, int PersonalId, string Date, string IsDone)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"AddMeeting";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("VisitId", SqlDbType.Int);
                    SqlParameter p2 = new SqlParameter("PersonalId", SqlDbType.Int);
                    SqlParameter p3 = new SqlParameter("Date", SqlDbType.Date);
                    SqlParameter p4 = new SqlParameter("IsDone", SqlDbType.Bit);
                    p1.Value = VisitId;
                    p2.Value = PersonalId;
                    p3.Value = Date;
                    p4.Value = IsDone;

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);

                    try
                    {
                        int res = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }
    }
}
