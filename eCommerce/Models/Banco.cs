using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace eCommerce.Models
{
    public class Banco

    {
        public OleDbConnection getDataBase()
        {

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\miziaf\Catalogo.mdb;";
            return conn;

        }
    }
}