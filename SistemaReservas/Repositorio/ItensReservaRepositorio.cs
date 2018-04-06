using Dapper;
using SistemaReservas.Infra;
using SistemaReservas.Models;
using SistemaReservas.Repositorio.Core;
using System.Collections.Generic;
using System.Linq;

namespace SistemaReservas.Respositorio
{
    public class ItensReservaRepositorio : IRepositorio<ItensReserva>
    {
        IDB _db;

        public ItensReservaRepositorio(IDB db)
        {
            _db = db;
        }

        public void Alterar(ItensReserva item)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"update ItensReserva set ID_Reserva = {0}, ID_Recurso = {1} where ID = {2}", item.ID_Reserva, item.ID_Recurso, item.ID);
                db.Query<ItensReserva>(sql);
            }
        }

        public ItensReserva BuscarPorID(int id)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"select * from ItensReserva where ID = {0}", id);
                return db.Query<ItensReserva>(sql).FirstOrDefault(x => x.ID == id);
            }
        }

        public IEnumerable<ItensReserva> BuscarTodos()
        {
            using (var db = _db.getCon())
            {
                return db.Query<ItensReserva>("select * from ItensReserva");
            }
        }

        public void Excluir(ItensReserva item)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"delete from ItensReserva where ID = {0}", item.ID);
                db.Query<ItensReserva>(sql);
            }
        }

        public void Inserir(ItensReserva item)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"insert into ItensReserva (ID_Reserva, ID_Recurso) values ({0}, {1})", item.ID_Reserva, item.ID_Recurso);
                db.Query<ItensReserva>(sql);
            }
        }
    }
}