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
    public partial class EditForm : Form
    {
        SqlDataAdapter da = DataAdapter.dataAd;
        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        DataSet sDs;
        DataTable sTable;
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditSelectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ChosenEdit = EditSelectTable.Text;
            if (ChosenEdit == "Student")
                visaStudtab();
            if (ChosenEdit == "Staff")
                visaPerstab();
            if (ChosenEdit == "LIA")
                visaLiatab();
            if (ChosenEdit == "Company")
                visaComptab();
            if (ChosenEdit == "Contact person")
                visaConttab();
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
            EditdataGridView.DataSource = sDs.Tables["Student"];
            //save_btn.Enabled = false;
            EditdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            EditdataGridView.DataSource = sDs.Tables["Personal"];
            EditdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void visaLiatab()
        {

            string sql = "SELECT * FROM LIA";
            SqlConnection connection = new SqlConnection(AzureCon.ConnectionString);
            connection.Open();
            sCommand = new SqlCommand(sql, connection);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "Lia");
            sTable = sDs.Tables["Lia"];
            connection.Close();
            EditdataGridView.DataSource = sDs.Tables["Lia"];
            //save_btn.Enabled = false;
            EditdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void visaComptab()
        {

            string sql = "SELECT * FROM Företag";
            SqlConnection connection = new SqlConnection(AzureCon.ConnectionString);
            connection.Open();
            sCommand = new SqlCommand(sql, connection);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "Företag");
            sTable = sDs.Tables["Företag"];
            connection.Close();
            EditdataGridView.DataSource = sDs.Tables["Företag"];
            //save_btn.Enabled = false;
            EditdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void visaConttab()
        {

            string sql = "SELECT * FROM KontaktPerson";
            SqlConnection connection = new SqlConnection(AzureCon.ConnectionString);
            connection.Open();
            sCommand = new SqlCommand(sql, connection);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "KontaktPerson");
            sTable = sDs.Tables["KontaktPerson"];
            connection.Close();
            EditdataGridView.DataSource = sDs.Tables["KontaktPerson"];
            //save_btn.Enabled = false;
            EditdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
