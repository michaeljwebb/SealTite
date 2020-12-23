using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using ST.Models;
using ST.Extensions;
using ST.Data;
using IsolationLevel = System.Transactions.IsolationLevel;
using System.Data.Entity;
using System.Data.Objects;

namespace ST
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext dataContext;

        public UnitOfWork(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Begin()
        {
        }

        public void Rollback()
        {
        }

        public void Commit()
        {
            dataContext.SaveChanges();
        }

        public void Dispose()
        {
        }

        public IDbSet<T> GetSet<T>() where T : class
        {
            return dataContext.Set<T>();
        }
    }
}
