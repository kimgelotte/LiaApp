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

        public void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();   
            form1.Show();
        }
    }
}
