using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Dapper;

namespace DbBrowser
{
    static class DbAccess
    {
        public static string GetConnsectionString()
        {
            return ConfigurationManager.ConnectionStrings["base1"].ToString();
        }
        public static System.Data.SqlClient.SqlConnection GetDbCon()
        {
            return new System.Data.SqlClient.SqlConnection(GetConnsectionString());
        }
    }
}
