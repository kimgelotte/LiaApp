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
        public PersonalForm()
        {
            InitializeComponent();
        }

        private void PersonalForm_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            OrderVisitdataGridView.DataSource = AzureCon.tableFrom();
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
    }
}
