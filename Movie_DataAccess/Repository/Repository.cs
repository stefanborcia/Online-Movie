using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            _db.Products.Include(u => u.Category).Include(u =>u.CatId);
        }
        public void Add(C entity)
        {
            dbSet.Add(entity);
        }

        public C Get(Expression<Func<C, bool>> filter, string? includeProperties = null, bool tracked = false)
        {
            IQueryable<C> query = dbSet;

            if (tracked)
            {
                query = dbSet;
            }
            else
            {
                query = dbSet.AsNoTracking();
            }
            query = query.Where(filter);
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.FirstOrDefault();
        }

        public IEnumerable<C> GetAll(string? includeProperties = null)
        {
            IQueryable<C> query = dbSet;
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(new char[]{ ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
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
