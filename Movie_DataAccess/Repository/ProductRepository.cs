using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Movie_DataAccess.Data;
using Movie_DataAccess.Repository.IRepository;
using Movie_Models;

namespace Movie_DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.ProductId == obj.ProductId);
            if (objFromDb != null)
            {
                objFromDb.Title = obj.Title;
                objFromDb.Description = obj.Description;
                objFromDb.Category = obj.Category;
                objFromDb.Actors = obj.Actors;
                objFromDb.Price = obj.Price;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Price3 = obj.Price3;
                objFromDb.Price5 = obj.Price5;

                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
