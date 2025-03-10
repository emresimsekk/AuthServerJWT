﻿using AuthServerJWT.Core.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthServerJWT.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
