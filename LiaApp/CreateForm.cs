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
        DataSet cDs;

        public CreateForm()
        {
            InitializeComponent();
        }

        private DataSet GetData(string query, string table)
        {

            using (SqlConnection con = new SqlConnection(AzureCon.ConnectionString))
            {
                SqlDataAdapter sApt;
                DataSet sD = new DataSet();
                sCommand = new SqlCommand(query, con);
                sApt = new SqlDataAdapter(sCommand);
                sBuilder = new SqlCommandBuilder(sApt);
                sD = new DataSet();
                sApt.Fill(sD, table);
                return sD;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ChosenCreate = comboBoxCreate.Text;
            if (ChosenCreate == "Student")
                visaStudtab();

            else if (ChosenCreate == "Personal")
                visaPerstab();
            else if (ChosenCreate == "Company")
                visaCompanytab();
        }

        private void visaStudtab()
        {
            panelCreateStudent.Show();
            panelCreatePersonal.Hide();
            panelCreateCompany.Hide();
            cDs = GetData("SELECT * FROM Klass", "Klass");
            comboBoxCrSt.DataSource = cDs.Tables[0].DefaultView;
            comboBoxCrSt.DisplayMember = "ClassName";
            comboBoxCrSt.ValueMember = "ClassName";
        }
        private void visaPerstab()
        {
            panelCreatePersonal.Show();
            panelCreateStudent.Hide();
            panelCreateCompany.Hide();

        }
        private void visaCompanytab()
        {
            panelCreatePersonal.Hide();
            panelCreateStudent.Hide();
            panelCreateCompany.Show();

        }

        private void buttonCreateSave_Click(object sender, EventArgs e)
        {
            string ChosenCr = comboBoxCreate.Text;
            if (ChosenCr == "Student")
            {
                string sql = "SELECT * FROM Student";
                SqlConnection connection = new SqlConnection(AzureCon.ConnectionString);
                //connection.Open();
                sCommand = new SqlCommand(sql, connection);
                sAdapter = new SqlDataAdapter(sCommand);
                sBuilder = new SqlCommandBuilder(sAdapter);
                sDs = new DataSet();
                sAdapter.Fill(sDs, "Student");




                DataRow row = sDs.Tables["Student"].NewRow();
                row["Id"] = Int32.Parse(textBoxcREATEid.Text);
                row["Namn"] = textBoxcREATEnAME.Text;
                row["PersonNummer"] = textBoxcREATEpERSNR.Text;
                row["Adress"] = textBoxcREATEADRESS.Text;
                row["PostAdress"] = textBoxCreatePadress.Text;
                row["PostNummer"] = textBoxCreatePnummer.Text;
                row["Examen"] = checkBoxCreateExamen.Checked;
                row["MejlAdress"] = textBoxCteateMail.Text;
                row["ClassNamn"] = comboBoxCrSt.Text;
                //row["ClassNamn"] = textBoxCreateClass.Text;

                sDs.Tables["Student"].Rows.Add(row);

                try
                {
                    sAdapter.Update(sDs, "Student");
                    MessageBox.Show("Database updated.");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);

                }
            }
            else if (ChosenCr == "Personal")
            {
                string sql = "SELECT * FROM Personal";
                SqlConnection connection = new SqlConnection(AzureCon.ConnectionString);
                //connection.Open();
                sCommand = new SqlCommand(sql, connection);
                sAdapter = new SqlDataAdapter(sCommand);
                sBuilder = new SqlCommandBuilder(sAdapter);
                sDs = new DataSet();
                sAdapter.Fill(sDs, "Personal");


                DataRow row = sDs.Tables["Personal"].NewRow();
                row["P_Id"] = Int32.Parse(textBoxP_Id.Text);
                row["PNamn"] = textBoxCreateNamn.Text;
                row["Telefon"] = textBoxCreateTele.Text;
                row["MejlAdress"] = textBoxCreateMail.Text;

                sDs.Tables["Personal"].Rows.Add(row);

                try
                {
                    sAdapter.Update(sDs, "Personal");
                    MessageBox.Show("Database updated.");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);

                }

            }

        }

        private void panelCreateStudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCancelCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            var PersonalForm = new PersonalForm();
            PersonalForm.Closed += (s, args) => this.Close();
            PersonalForm.Show();
        }



    }
}
