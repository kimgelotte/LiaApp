using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LiaApp
{
    public partial class PersonalForm : Form
    {
        SqlDataAdapter da = DataAdapter.dataAd;
        public PersonalForm()
        {
            InitializeComponent();
        }


        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Createform = new CreateForm();
            Createform.Closed += (s, args) => this.Close();
            Createform.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Editform = new EditForm();
            Editform.Closed += (s, args) => this.Close();
            Editform.Show();
        }

        private void absenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Absenceform = new AbsenceForm();
            Absenceform.Closed += (s, args) => this.Close();
            Absenceform.Show();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Bookingform = new BookingForm();
            Bookingform.Closed += (s, args) => this.Close();
            Bookingform.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var StartApp = new StartApp();
            StartApp.Closed += (s, args) => this.Close();
            StartApp.Show();

        }
        private void PersonalForm_Load_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(AzureCon.ConnectionString))
            {
                try
                {
                    conn.Open();
                    da.Fill(ds);

                    TabellcomboBox.DataSource = ds.Tables[0].DefaultView;

                    TabellcomboBox.DisplayMember = "ClassNamn";
                    TabellcomboBox.ValueMember = "ClassNamn";

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }


        private void TabellcomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string ChosenClass = TabellcomboBox.Text;

            DataTable Classtable = AzureCon.PersonalFormQuery(ChosenClass);
            dataGridViewTabells.DataSource = Classtable;


        }



    }
}
