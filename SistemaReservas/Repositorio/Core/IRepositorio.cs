
using System.Collections.Generic;


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