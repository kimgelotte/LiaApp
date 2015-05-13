using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Data.SqlClient;
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
    }
}
