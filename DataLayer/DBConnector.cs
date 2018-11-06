using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class DBConnector
    {
        public static SqlConnectionStringBuilder GetBuilder()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"dbsys.cs.vsb.cz\STUDENT";   // update me
            builder.UserID = "cer086";              // update me
            builder.Password = "0395Ad2bd3";      // update me
            builder.InitialCatalog = "cer0386";
            return builder;
        }
    }
}
