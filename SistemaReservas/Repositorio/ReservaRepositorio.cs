using SistemaReservas.Infra;
using SistemaReservas.Models;
using SistemaReservas.Repositorio.Core;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SistemaReservas.Repositorio
{
    public class ReservaRepositorio : IRepositorio<Reserva>
    {
        IDB _db;

        public ReservaRepositorio(IDB db)
        {
            _db = db;
        }

        public void Alterar(Reserva item)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"update Reserva set DataInicial = '{0}', DataFinal = '{1}', HoraInicial = '{2}', HoraFinal = '{3}', ID_Usuario = '{4} where ID = {5}", item.DataInicial, item.DataFinal, item.HoraInicial, item.HoraFinal, item.ID_Usuario, item.ID);
                db.Query<Reserva>(sql);
            }
        }

        public Reserva BuscarPorID(int id)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"select * from Reserva where ID = {0}", id);
                return db.Query<Reserva>(sql).FirstOrDefault(x => x.ID == id);
            }
        }

        public IEnumerable<Reserva> BuscarTodos()
        {
            using (var db = _db.getCon())
            {
                return db.Query<Reserva>("select * from Reserva");
            }
        }

        public void Excluir(Reserva item)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"delete from Reserva where ID = {0}", item.ID);
                db.Query<Reserva>(sql);
            }
        }

        public void Inserir(Reserva item)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"insert into Reserva (DataInicial, DataFinal, HoraInicial, HoraFinal, ID_Usuario) values ('{0}', '{1}', '{2}', '{3}', {4})", item.DataInicial, item.DataFinal, item.HoraInicial, item.HoraFinal, item.ID_Usuario);
                db.Query<Reserva>(sql);
            }
        }
    }
}