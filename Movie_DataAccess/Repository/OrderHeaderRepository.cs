﻿using System;
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
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private ApplicationDbContext _db;

        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader obj)
        {
            _db.OrderHeaders.Update(obj);
        }
    }
}
