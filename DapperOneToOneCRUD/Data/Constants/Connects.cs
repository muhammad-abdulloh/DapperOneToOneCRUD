using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperOneToOneCRUD.Data.Constants
{
    public class Connects
    {
        private const string CONNECTION_STRING_PRIVATE = "Server=(localdb)\\MSSQLLocalDB; Database=najotuz; Trusted_connection=true";

        public static string CONNECTION_STRING
        {
            get { return CONNECTION_STRING_PRIVATE; }
        }
    }
}
