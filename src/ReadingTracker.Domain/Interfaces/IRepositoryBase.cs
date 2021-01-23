using ReadingTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ReadingTracker.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : Entity
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(ref TEntity entity);
        bool Update(TEntity entity);
        bool Delete(Int32 id);
        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate);
    }
}
