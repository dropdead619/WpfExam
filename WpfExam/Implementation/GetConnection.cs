using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExam.Implementation
{
    public class GetConnection
    {
        protected IDbConnection dbConnection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["WpfExamDb"].ToString());
            }
        }

    }
}
