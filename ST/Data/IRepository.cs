using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace ST.Data
{
    public interface IRepository<T>
    {
        IQueryable<T> Select();

        IQueryable<T> SelectWith(params Expression<Func<T, object>>[] includeProperties);

        T GetById(int id);

        T GetByIdWith(int id, params Expression<Func<T, object>>[] includeProperties);

        void InsertOnCommit(T model);

        void DeleteOnCommit(T model);
    }
}
