using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

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

        //public void azureconnect()
        //{
        //string constr = "Server=tcp:qgtejfd89g.database.windows.net,1433;Database=db_newton;User ID=grupp4@qgtejfd89g;Password=Newtong4;Trusted_Connection=False;Encrypt=True;Connection Timeout=5;";
        //try { 
        //    using (SqlConnection conn = new SqlConnection(constr))
        //    {
        //        conn.Open();
        //        MessageBox.Show("FUNKAR!!!!");
        //    }
        //}
        //catch (SqlException ex)
        //{

        //    MessageBox.Show(ex.ErrorCode + ex.Message + "funkar INTE!!!");
        //}
        //}
    }
}
