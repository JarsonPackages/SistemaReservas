using SistemaReservas.Infra;
using SistemaReservas.Repositorio.Core;
using Dapper;
using System.Collections.Generic;
using System.Linq;

using SistemaReservas.Models;

namespace SistemaReservas.Respositorio
{
    public class RecursoRepositorio : IRepositorio<Recurso>
    {
        IDB _db;

        public RecursoRepositorio(IDB db)
        {
            _db = db;
        }

        public void Alterar(Recurso item)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"update Recurso set Nome = '{0}', Descricao = '{1}', Disponivel = '{2}', Quantidade = {3}, Marca = '{4}', Modelo = '{5}', ID_Tipo = {6}  where ID = {7}", item.Nome, item.Descricao, item.Disponivel, item.Quantidade, item.Marca, item.Modelo, item.ID_Tipo, item.ID);
                db.Query<Recurso>(sql);
            }
        }

        public Recurso BuscarPorID(int id)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"select * from Recurso where ID = {0}", id);
                return db.Query<Recurso>(sql).FirstOrDefault(x => x.ID == id);
            }
        }

        public IEnumerable<Recurso> BuscarTodos()
        {
            using (var db = _db.getCon())
            {
                return db.Query<Recurso>("select * from Recurso");
            }
        }

        public void Excluir(Recurso item)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"delete from Recurso where ID = {0}", item.ID);
                db.Query<Recurso>(sql);
            }
        }

        public void Inserir(Recurso item)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"insert into Recurso (Nome, Descricao, Disponivel, Quantidade, Marca, Modelo, ID_Tipo) values ('{0}', '{1}', '{2}', {3}, '{4}', '{5}', {6})", item.Nome, item.Descricao, item.Quantidade, item.Marca, item.Modelo, item.ID_Tipo);
                db.Query<Recurso>(sql);
            }
        }
    }
}