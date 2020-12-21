using Agenda.Dominio.Contratos;
using Agenda.Repository.Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly AgendaContext AgendaContext;

        public BaseRepository(AgendaContext agendaContext)
        {
            AgendaContext = agendaContext;
        }
        public void Add(TEntity entity)
        {
            AgendaContext.Set<TEntity>().Add(entity);
            AgendaContext.SaveChanges();
        }

        public void Dispose()
        {
            AgendaContext.Dispose();
        }

        public TEntity ObterId(TEntity entity)
        {
            return AgendaContext.Set<TEntity>().Find(entity);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return AgendaContext.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            AgendaContext.Set<TEntity>().Remove(entity);
            AgendaContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            AgendaContext.Set<TEntity>().Update(entity);
            AgendaContext.SaveChanges();
        }
    }
}
