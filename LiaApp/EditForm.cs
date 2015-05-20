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

        //HÄMTAR VALD TABELL IFRÅN DATABASEN
        private void EditSelectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "a";
            string query2 = "a";

            string ChosenEdit = EditSelectTable.Text;

            if (ChosenEdit == "Student")
            {
                query = "SELECT * FROM Student";
                query2 = "Student";
            }
            if (ChosenEdit == "Staff")
            {
                query = "SELECT * FROM Personal";
                query2 = "Personal";
            }
            if (ChosenEdit == "LIA")
            {
                query = "SELECT * FROM LIA";
                query2 = "Lia";
            }
            if (ChosenEdit == "Company")
            {
                query = "SELECT * FROM Företag";
                query2 = "Företag";
            }
            if (ChosenEdit == "Contact person")
            {
                query = "SELECT * FROM KontaktPerson";
                query2 = "KontaktPerson";
            }
            if (ChosenEdit == "Class")
            {
                query = "SELECT * FROM Klass";
                query2 = "Klass";
            }

            string sql = query;
            SqlConnection connection = new SqlConnection(AzureCon.ConnectionString);
            connection.Open();
            sCommand = new SqlCommand(sql, connection);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, query2);
            sTable = sDs.Tables[query2];
            connection.Close();
            EditdataGridView.DataSource = sDs.Tables[query2];
            EditdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }


        private void EditdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //SPARA ÄNDRINGAR
        private void EditSaveChangesButton_Click(object sender, EventArgs e)
        {
            if (EditdataGridView.RowCount == 0)
            {
                MessageBox.Show("You must first load a database table.");
            }
            //Kolla vilken tabell i comboboxen som är markerad och uppdaterar db vid klick på knappen
            else
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

                    if (ChosenEdit == "Class")
                        sAdapter.Update(sDs, "Klass");

                    MessageBox.Show("Database updated.");
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);

                }
            }
        }

        //LADDA OM DATABASEN
        private void EditRevertChangesButton_Click(object sender, EventArgs e)
        {
            if (EditdataGridView.RowCount == 0)
            {

            }
            //Om ändringar har gjorts
            else if (sDs.HasChanges())
            {
                //Dialog om man vill fortsätta ladda om databasen utan att spara ändringar
                var confirmResult = MessageBox.Show("Are you sure you want to reload the database?\nChanges you have made will be lost!",
                            "Reload Database",
                            MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    string ChosenEdit = EditSelectTable.Text;
                    try
                    {

                        //Tömmer datagrid och laddar in igen
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
                        if (ChosenEdit == "Class")
                        {
                            sTable.Clear();
                            sAdapter.Fill(sDs, "Klass");
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

        //SPARA ÄNDRINGAR OCH STÄNG NER
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

                if (ChosenEdit == "Class")
                    sAdapter.Update(sDs, "Klass");

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

        //STÄNG NER FÖNSTER
        private void EditCancelButton_Click(object sender, EventArgs e)
        {
            //Kollar om ändringar har gjorts
            if (EditdataGridView.RowCount == 0)
            {
                this.Hide();
                var PersonalForm = new PersonalForm();
                PersonalForm.Closed += (s, args) => this.Close();
                PersonalForm.Show();
            }

            else if (sDs.HasChanges())
                {
                //Varningsruta om att ändringar kommer gå förlorade
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
