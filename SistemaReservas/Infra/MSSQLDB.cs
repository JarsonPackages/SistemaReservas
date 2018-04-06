using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaReservas.Infra
{
    public class MSSQLDB : IDB
    {
        public IDbConnection getCon()
        {
            return new SqlConnection(@"Data Source=VIRTUAL-PC;Initial Catalog=ReservasDeSala;Integrated Security=true");
        }
    }
}