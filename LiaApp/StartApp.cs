﻿using System;
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
    public partial class StartApp : Form
    {
       
        public StartApp()
        {
            InitializeComponent();
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            string var;
            string comvar;
            var = textBox1.Text;
            comvar = comboBox1.Text;
            if(var=="")
                MessageBox.Show("You have to enter a password!");
            else if (var == "student"&&comvar=="Student")
            {               
                this.Hide();
                var form1 = new Form1();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
            else if (var == "personal" && comvar == "Staff")
            {
                this.Hide();
                var PersonalForm = new PersonalForm();
                PersonalForm.Closed += (s, args) => this.Close();
                PersonalForm.Show();
            }
            else 
                MessageBox.Show("Wrong password!");
        }

        private void StartApp_Load(object sender, EventArgs e)
        {

        }

   

       

    }
}
