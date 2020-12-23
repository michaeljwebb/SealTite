using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using ST.Data;
using ST.Models;

namespace ST
{
    public class SqlRepository<T> : IRepository<T> where T : class, IIdentifiable, IAuditable, new()
    {
        private readonly IDbSet<T> dbSet;

        public SqlRepository(UnitOfWork unitOfWork)
        {
            dbSet = unitOfWork.GetSet<T>();
        }

        public IQueryable<T> Select()
        {
            return dbSet.Where(x => !x.IsDeleted);
        }

        public IQueryable<T> SelectWith(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Select();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public T GetByIdWith(int id, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Select();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void InsertOnCommit(T model)
        {
            dbSet.Add(model);
        }

        public void DeleteOnCommit(T model)
        {
            model.IsDeleted = true;
        }
    }
}

