using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiaApp
{
    public partial class AbsenceForm : Form
    {
        SqlDataAdapter da = DataAdapter.dataAd;
        public AbsenceForm()
        {
            InitializeComponent();
        }
        private void AbsenceForm_Load_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(AzureCon.ConnectionString))
            {
                try
                {
                    conn.Open();
                    da.Fill(ds);

                    comboBox1.DataSource = ds.Tables[0].DefaultView;

                    comboBox1.DisplayMember = "ClassNamn";
                    comboBox1.ValueMember = "ClassNamn";

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

            DataTable Classtable = AzureCon.klasstable(ChosenClass);
            dataGridViewClass.DataSource = Classtable;

            //DataTable Liatable = AzureCon.LIAtable(ChosenClass);
            //dataGridViewLIA.DataSource = Liatable;
        }

        private void dataGridViewClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {
         
        }

        
    }
}
