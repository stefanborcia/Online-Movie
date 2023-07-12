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

        public void UpdateStatus(int id, string orderStatus, string? paymentStatus = null)
        {
	        var orderFromDb = _db.OrderHeaders.FirstOrDefault(u => u.Id == id);
	        if (orderFromDb != null)
	        {
                orderFromDb.OrderStatus= orderStatus;
                if (!string.IsNullOrEmpty(paymentStatus))
                {
                    orderFromDb.PaymentStatus= paymentStatus;
                }
	        }
        }

        public void UpdateStripePaymentID(int id, string sessionId, string paymentIntentId)
        {
            var orderFromDb=_db.OrderHeaders.FirstOrDefault(u=>u.Id == id);
            if (!string.IsNullOrEmpty(sessionId))
            {
                orderFromDb.SessionId=sessionId;
            }

            if (!string.IsNullOrEmpty(sessionId))
            {
	            orderFromDb.PaymentIntentId = paymentIntentId;
                orderFromDb.PaymentDate=DateTime.Now;
            }
		}
    }
}
