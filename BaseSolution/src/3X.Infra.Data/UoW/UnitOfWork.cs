﻿using System;
using X.Infra.Data.Context;
using X.Infra.Data.Interfaces;

namespace X.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CrudModalDDDContext _context;
        private bool _disposed;

        public UnitOfWork(CrudModalDDDContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}