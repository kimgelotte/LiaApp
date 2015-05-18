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
            DataSet ds = new DataSet();

            using(SqlConnection conn = new SqlConnection(AzureCon.ConnectionString)){
                try
                {
                    conn.Open();
                    da.Fill(ds);

                    comboBox1.DataSource = ds.Tables[0].DefaultView ;

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

            DataTable Liatable = AzureCon.LIAtable(ChosenClass);
            dataGridViewLIA.DataSource = Liatable;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string SearchResult = SearchBox.Text;

            DataTable Searchtable = AzureCon.StudentSearchFor(SearchResult);

            if (Searchtable.Rows.Count == 0)
            {
                MessageBox.Show(SearchResult + " Finns ingen elev med det personnumret på LIA för tillfället.");
            }
            else
            {
                ResultStudentName.Text = Searchtable.Rows[0].ItemArray[1].ToString();
                ResultCompanyName.Text = Searchtable.Rows[0].ItemArray[2].ToString();
                ResultVisitId.Text = Searchtable.Rows[0].ItemArray[3].ToString();
                ResultDatelabel.Text = Searchtable.Rows[0].ItemArray[4].ToString();
                ResultPersonalName.Text = Searchtable.Rows[0].ItemArray[5].ToString();
                ResultPersonaltele.Text = Searchtable.Rows[0].ItemArray[6].ToString();
            }
        }

        private void dataGridViewClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ElevBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Startapp = new StartApp();
            Startapp.Closed += (s, args) => this.Close();
            Startapp.Show();
        }
    }
}
