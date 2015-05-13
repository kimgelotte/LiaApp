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
    public partial class PersonalForm : Form
    {
        SqlDataAdapter da = DataAdapter.dataAd;
        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        DataSet sDs;
        DataTable sTable;    
        public PersonalForm()
        {
            InitializeComponent();
        }

        private void PersonalForm_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            dataGridViewOrderVisit.DataSource = AzureCon.tableFrom();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Startapp = new StartApp();
            Startapp.Closed += (s, eventA) => this.Close();
            Startapp.Show();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Startapp = new StartApp();
            Startapp.Closed += (s, eventA) => this.Close();
            Startapp.Show();
        }

        private void comboBoxCreate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ChosenCreate = comboBoxCreate.Text;
            if (ChosenCreate == "Student")
                visaStudtab();
        }

        private void visaStudtab()
        {
            
            string sql = "SELECT * FROM Student";
            SqlConnection connection = new SqlConnection(AzureCon.ConnectionString);
            connection.Open();
            sCommand = new SqlCommand(sql, connection);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "Student");
            sTable = sDs.Tables["Student"];
            connection.Close();
            dataGridViewCreate.DataSource = sDs.Tables["Student"];
            
            //save_btn.Enabled = false;
            dataGridViewCreate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
    }
}
