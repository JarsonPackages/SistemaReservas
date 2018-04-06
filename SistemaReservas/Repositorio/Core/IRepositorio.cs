using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaReservas.Repositorio.Core
{
    interface IRepositorio<T>
    {
        void Inserir(T item);
        void Excluir(T item);
        void Alterar(T item);
        T BuscarPorID(int id);
        IEnumerable<T> BuscarTodos();
    }
}