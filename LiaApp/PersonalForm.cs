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
    public partial class PersonalForm : Form
    {
        public PersonalForm()
        {
            InitializeComponent();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Createform = new CreateForm();
            Createform.Closed += (s, args) => this.Close();
            Createform.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Editform = new EditForm();
            Editform.Closed += (s, args) => this.Close();
            Editform.Show();
        }

        private void absenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Absenceform = new AbsenceForm();
            Absenceform.Closed += (s, args) => this.Close();
            Absenceform.Show();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Bookingform = new BookingForm();
            Bookingform.Closed += (s, args) => this.Close();
            Bookingform.Show();
        }
    }
}
