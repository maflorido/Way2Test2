using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GitApi.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IList<T> Listar();

        T Obter(long id);

        List<T> Filtrar(Expression<Func<T, bool>> filtro);

        void Incluir(T objeto);

        void Editar(T objeto);

        void Excluir(T objeto);
    }
}
