
using System.Data;
using System.Data.SqlClient;


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