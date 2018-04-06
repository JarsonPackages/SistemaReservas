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
    public class UsuarioRepositorio : IRepositorio<Usuario>
    {
        IDB _db;

        public UsuarioRepositorio(IDB db)
        {
            _db = db;
        }

        public void Alterar(Usuario item)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"update Usuario set Nome = '{0}', Email = '{1}', Senha = '{2}', Tipo = '{3}' where ID = {4}", item.Nome, item.Email, item.Senha, item.Tipo, item.ID);
                db.Query<Usuario>(sql);
            }
        }

        public Usuario BuscarPorID(int id)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"select * from Usuario where ID = {0}", id);
                return db.Query<Usuario>(sql).FirstOrDefault(x => x.ID == id);
            }
        }

        public IEnumerable<Usuario> BuscarTodos()
        {
            using(var db = _db.getCon())
            {
                return db.Query<Usuario>("select * from Usuario");
            }
        }

        public void Excluir(Usuario item)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"delete from Usuario where ID = {0}", item.ID);
                db.Query<Usuario>(sql);
            }
        }

        public void Inserir(Usuario item)
        {
            using (var db = _db.getCon())
            {
                string sql = string.Format(@"insert into Usuario (Nome, Email, Senha, Tipo) values ('{0}', '{1}', '{2}', '{3}')", item.Nome, item.Email, item.Senha, item.Tipo);
                db.Query<Usuario>(sql);
            }
        }
    }
}