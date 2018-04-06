using SistemaReservas.Infra;
using SistemaReservas.Models;
using SistemaReservas.Repositorio.Core;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaReservas.Respositorio
{
    public class TipoRecursoRepositorio : IRepositorio<TipoRecurso>
    {
        IDB _db;

        public TipoRecursoRepositorio(IDB db)
        {
            _db = db;
        }

        public void Alterar(TipoRecurso item)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"update TipoRecurso set Nome = '{0}', Quantidade = {1} where ID = {2}", item.Nome, item.Quantidade, item.ID);
                db.Query<TipoRecurso>(sql);
            }
        }

        public TipoRecurso BuscarPorID(int id)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"select * from TipoRecurso where ID = {0}", id);
                return db.Query<TipoRecurso>(sql).FirstOrDefault(x => x.ID == id);
            }
        }

        public IEnumerable<TipoRecurso> BuscarTodos()
        {
            using (var db = _db.getCon())
            {
                return db.Query<TipoRecurso>("select * from TipoRecurso");
            }
        }

        public void Excluir(TipoRecurso item)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"delete from TipoRecurso where ID = {0}", item.ID);
                db.Query<TipoRecurso>(sql);
            }
        }

        public void Inserir(TipoRecurso item)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"insert into TipoRecurso (Nome, Quantidade) values ('{0}', {1})", item.Nome, item.Quantidade);
                db.Query<TipoRecurso>(sql);
            }
        }
    }
}