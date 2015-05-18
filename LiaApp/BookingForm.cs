using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiaApp
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            BookingdataGridView.DataSource = AzureCon.tableFrom();

            BookingPersonalcomboBox.DataSource = AzureCon.BookingForms().DefaultView;
            BookingPersonalcomboBox.DisplayMember = "PNamn";

            BookingStudentcomboBox.DataSource = AzureCon.BookingForms().DefaultView;
            BookingStudentcomboBox.DisplayMember = "Namn";
        }

        private void BookingCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var PersonalForm = new PersonalForm();
            PersonalForm.Closed += (s, args) => this.Close();
            PersonalForm.Show();
        }

        private void BookingOkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var PersonalForm = new PersonalForm();
            PersonalForm.Closed += (s, args) => this.Close();
            PersonalForm.Show();
        }
    }
}
