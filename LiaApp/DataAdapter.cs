using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LiaApp
{
     class DataAdapter
    {
        public static SqlDataAdapter dataAd
        {
            get
            {
                SqlDataAdapter dA = new SqlDataAdapter
                ("SELECT * FROM Student", AzureCon.ConnectionString);
                return dA;
            }
    }
    }
}

