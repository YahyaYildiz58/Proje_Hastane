﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    internal class SQLbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=YAHYA\\YAHYAMSSQL;Initial Catalog=HastaneProje;Integrated Security=True;TrustServerCertificate=True");
            baglan.Open();
            return baglan;
        }
    }
}
