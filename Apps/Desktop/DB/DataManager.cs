using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Desktop.DB
{
    public static class DataManager
    {
        private static string _connection;

        static DataManager() 
        {
            _connection = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion; Trusted_Connection=True;";
        }
        
    }
}
