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

        private void EditdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditSaveChangesButton_Click(object sender, EventArgs e)
        {
            string ChosenEdit = EditSelectTable.Text;
            try
            {
                if (ChosenEdit == "Student")
                    sAdapter.Update(sDs, "Student");

                if (ChosenEdit == "Staff")
                    sAdapter.Update(sDs, "Personal");
                
                if (ChosenEdit == "LIA")
                    sAdapter.Update(sDs, "Lia");

                if (ChosenEdit == "Company")
                    sAdapter.Update(sDs, "Företag");

                if (ChosenEdit == "Contact person")
                    sAdapter.Update(sDs, "KontaktPerson");

                
                MessageBox.Show("Database updated.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void EditRevertChangesButton_Click(object sender, EventArgs e)
        {

            if (sDs.HasChanges())
            {
                var confirmResult = MessageBox.Show("Are you sure you want to reload the database?\nChanges you have made will be lost!",
                            "Reload Database",
                            MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    string ChosenEdit = EditSelectTable.Text;
                    try
                    {
                        if (ChosenEdit == "Student")
                        {
                            sTable.Clear();
                            sAdapter.Fill(sDs, "Student");
                        }
                        if (ChosenEdit == "Staff")
                        {
                            sTable.Clear();
                            sAdapter.Fill(sDs, "Personal");
                        }
                        if (ChosenEdit == "LIA")
                        {
                            sTable.Clear();
                            sAdapter.Fill(sDs, "Lia");
                        }
                        if (ChosenEdit == "Company")
                        {
                            sTable.Clear();
                            sAdapter.Fill(sDs, "Företag");
                        }
                        if (ChosenEdit == "Contact person")
                        {
                            sTable.Clear();
                            sAdapter.Fill(sDs, "KontaktPerson");
                        }

                        MessageBox.Show("Database reloaded.");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);

                    }
                }
                else
                {
                    MessageBox.Show("Database reloaded.");
                }

            }
            else
            {
                MessageBox.Show("Database reloaded.");
            }
            
            
        }

        private void EditOKButton_Click(object sender, EventArgs e)
        {
            string ChosenEdit = EditSelectTable.Text;
            try
            {
                if (ChosenEdit == "Student")
                    sAdapter.Update(sDs, "Student");

                if (ChosenEdit == "Staff")
                    sAdapter.Update(sDs, "Personal");

                if (ChosenEdit == "LIA")
                    sAdapter.Update(sDs, "Lia");

                if (ChosenEdit == "Company")
                    sAdapter.Update(sDs, "Företag");

                if (ChosenEdit == "Contact person")
                    sAdapter.Update(sDs, "KontaktPerson");

                this.Hide();
                var PersonalForm = new PersonalForm();
                PersonalForm.Closed += (s, args) => this.Close();
                PersonalForm.Show();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void EditCancelButton_Click(object sender, EventArgs e)
        {
            if (sDs.HasChanges())
                {
                         var confirmResult = MessageBox.Show("Are you sure you want to close this window?\nChanges you have made will be lost!",
                                     "Close window",
                                     MessageBoxButtons.YesNo);
                         if (confirmResult == DialogResult.Yes)
                            {
                                this.Hide();
                                var PersonalForm = new PersonalForm();
                                PersonalForm.Closed += (s, args) => this.Close();
                                PersonalForm.Show();
                            }
                        else
                            {
                
                            }       
       
                }
            else
            {
                this.Hide();
                var PersonalForm = new PersonalForm();
                PersonalForm.Closed += (s, args) => this.Close();
                PersonalForm.Show();
            }
            
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
