using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Connection
    {
        private static string connection = @"Data Source=localhost;Initial Catalog=DBSISCOVE;Integrated Security=SSPI";
        public static string stringConnection
        {
            get
            {
                return connection;
            }
        }
    }
}
