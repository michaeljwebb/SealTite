﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ST.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Begin();

        void Commit();

        void Rollback();
    }
}
