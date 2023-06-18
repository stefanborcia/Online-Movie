﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movie_DataAccess.Data;
using Movie_DataAccess.Repository.IRepository;

namespace Movie_DataAccess.Repository
{
    public class Repository<C> : IRepository<C> where C : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<C> dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<C>();  //_db.Categories == dbSet
        }
        public void Add(C entity)
        {
            dbSet.Add(entity);
        }

        public C Get(System.Linq.Expressions.Expression<Func<C, bool>> filter)
        {
            IQueryable<C> query = dbSet;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public IEnumerable<C> GetAll()
        {
            IQueryable<C> query = dbSet;
            return query.ToList();
        }

        public void Remove(C entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<C> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}