using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Dominio.Contratos
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        IEnumerable<TEntity> ObterTodos();
    }
}
