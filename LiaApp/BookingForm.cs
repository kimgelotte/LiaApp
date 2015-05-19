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
            // TODO: This line of code loads data into the 'databaseDataSetBooking.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.databaseDataSetBooking.Student);
            // TODO: This line of code loads data into the 'databaseDataSetBooking.LIA' table. You can move, or remove it, as needed.
            this.lIATableAdapter.Fill(this.databaseDataSetBooking.LIA);
            // TODO: This line of code loads data into the 'databaseDataSetBooking.Personal' table. You can move, or remove it, as needed.
            this.personalTableAdapter.Fill(this.databaseDataSetBooking.Personal);
            // TODO: This line of code loads data into the 'databaseDataSetBooking.PersonalVisits' table. You can move, or remove it, as needed.
            this.personalVisitsTableAdapter.Fill(this.databaseDataSetBooking.PersonalVisits);
            
            
            //BookingdataGridView.DataSource = AzureCon.tableFrom();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookingNewButton_Click(object sender, EventArgs e)
        {
            bool IsChecked = false;
            if(BookingcheckBox.Checked)
                IsChecked = true;

            int count = AzureCon.CountBook();
            AzureCon.BookingNewMeeting(++count, (int)comboBox1.SelectedValue, BookingdateTimePicker.Value, IsChecked);

            MessageBox.Show("Booking Complete!");
            BookinglistBox.Update();
        }

        private void BookingcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
