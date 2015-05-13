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
    public partial class PersonalForm : Form
    {
        SqlDataAdapter da = DataAdapter.dataAd;
        public PersonalForm()
        {
            InitializeComponent();
        }
  

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ChosenTbl = comboBoxCreate.Text;
            if (ChosenTbl == "Student")
            {
                visaStudab();
            }
            else if (ChosenTbl =="Personal")
                visaPerstab();
          

        }

        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        DataSet sDs;
        DataTable sTable;  
        private void visaStudab()
        {
            string connectionString = AzureCon.ConnectionString;
            string sql = "SELECT * FROM Student";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            sCommand = new SqlCommand(sql, connection);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "Student");
            sTable = sDs.Tables["Student"];
            connection.Close();
            dataGridViewCreate.DataSource = sDs.Tables["Student"];
            
            dataGridViewCreate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void visaPerstab()
        {
            string connectionString = AzureCon.ConnectionString;
            string sql = "SELECT * FROM Personal";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            sCommand = new SqlCommand(sql, connection);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "Personal");
            sTable = sDs.Tables["Personal"];
            connection.Close();
            dataGridViewCreate.DataSource = sDs.Tables["Personal"];

            dataGridViewCreate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
    }
}
