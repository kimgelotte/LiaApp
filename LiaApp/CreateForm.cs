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
    public partial class CreateForm : Form
    {
        SqlDataAdapter da = DataAdapter.dataAd;
        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        DataSet sDs;
        DataTable sTable;
        public CreateForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ChosenCreate = comboBoxCreate.Text;
            if (ChosenCreate == "Student")
                visaStudtab();
            if (ChosenCreate == "Personal")
                visaPerstab();
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
        private void visaPerstab()
        {

            string sql = "SELECT * FROM Personal";
            SqlConnection connection = new SqlConnection(AzureCon.ConnectionString);
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

        private void buttonCreateSave_Click(object sender, EventArgs e)
        {
            sAdapter.Update(sTable);

        }

 

    }
}
