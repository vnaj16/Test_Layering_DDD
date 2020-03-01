using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repository
{
    public class ConnectionSQL
    {
        protected SqlConnection Conexion = new SqlConnection(@"Data Source = ARTHUR\VNAJ_DB01; Initial Catalog = dbTestPersona; Integrated Security = true");
    }
}
