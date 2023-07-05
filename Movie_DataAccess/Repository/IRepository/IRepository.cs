using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DataAccess.Repository.IRepository
{
    public interface IRepository<C> where C: class
    {
        // C => Category
        IEnumerable<C> GetAll(string? includeProperties = null);
        C Get(Expression<Func<C, bool>> filter, string? includeProperties = null, bool tracked=false);
        void Add(C entity);
        void Remove(C entity);
        void RemoveRange(IEnumerable<C> entity);
    }
}
