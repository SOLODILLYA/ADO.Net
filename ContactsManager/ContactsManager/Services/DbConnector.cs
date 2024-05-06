using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ContactsManager.Services
{
    public class DbConnector
    {
        protected SqlConnection _connection;
        protected SqlCommand _command;
        protected SqlDataReader _reader;

        public DbConnector()
        {
            _connection = new SqlConnection(
                ConfigurationManager.ConnectionStrings["Default"].ConnectionString
                );
        }
    }
}
