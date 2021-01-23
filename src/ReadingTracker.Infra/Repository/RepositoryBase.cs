using ReadingTracker.Domain.Entities;
using ReadingTracker.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Text;
using Dommel;
using System.Linq.Expressions;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace ReadingTracker.Repository.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
    {


        protected readonly string ConnectionString;

        protected RepositoryBase(IConfiguration configuration)
        {
            ConnectionString = configuration["ConnectionStrings:ReadingTrackerConnectionString"].Trim();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            using (var db = new MySqlConnection(ConnectionString))
            {
                return db.GetAll<TEntity>();
            }
        }

        public virtual TEntity GetById(int id)
        {
            using (var db = new MySqlConnection(ConnectionString))
            {
                return db.Get<TEntity>(id);
            }
        }

        public virtual void Insert(ref TEntity entity)
        {
            using (var db = new MySqlConnection(ConnectionString))
            {
                var id = (int)db.Insert(entity);

                entity = GetById(id);
            }
        }

        public virtual bool Update(TEntity entity)
        {
            using (var db = new MySqlConnection(ConnectionString))
            {
                return db.Update(entity);
            }
        }

        public virtual bool Delete(Int32 id)
        {
            using (var db = new MySqlConnection(ConnectionString))
            {
                var entity = GetById(id);

                if (entity == null) throw new Exception("Registro não encontrado");

                return db.Delete(entity);
            }
        }

        public virtual IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate)
        {
            using (var db = new MySqlConnection(ConnectionString))
            {
                return db.Select(predicate);
            }
        }
    }
}

