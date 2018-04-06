using System.Data;

namespace SistemaReservas.Infra
{
    public interface IDB
    {
        IDbConnection getCon();
    }
}
