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
        SqlDataAdapter da = DataAdapter.dataAd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string connStr = AzureCon.ConnectionString;
            DataSet ds = new DataSet();

            using(SqlConnection conn = new SqlConnection(connStr)){
                try
                {
                    conn.Open();
                    da.Fill(ds);

                    comboBox1.DataSource = ds.Tables[0].DefaultView ;

                    comboBox1.DisplayMember = "ClassNamn";
                    comboBox1.ValueMember = "Namn";
   
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            Encryption.ToggleConfigEncryption();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ChosenClass = comboBox1.Text;

            DataTable table = AzureCon.klasstable(ChosenClass);
            dataGridViewClass.DataSource = table; 
        }
    }
}
