using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cafedra
{
    class DB
    {
        SqlConnection connection = new SqlConnection("data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user60_db;persist security info=True;user id=user60_db;password=user60;MultipleActiveResultSets=True;App=EntityFramework");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
