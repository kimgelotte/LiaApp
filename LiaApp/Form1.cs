using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = AzureCon.ConnectionString;
            DataSet ds = new DataSet();
            SqlDataAdapter da = DataAdapter.dataAd;


            using(SqlConnection conn = new SqlConnection(connStr)){
                try
                {
                    conn.Open();
                    da.Fill(ds);

                    MessageBox.Show("Your database Connection Works!");



                    comboBox1.DataSource = ds.Tables[0] ;
                        
                        
                
                    comboBox1.DisplayMember = "Namn";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            Encryption.ToggleConfigEncryption();

        }
    }
}
