﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Movie_Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int ProductId { get; set;}
        [ForeignKey("ProductId")]
        [ValidateNever]
        public Product Product { get; set; }
        public string Count { get; set;}
        public string ApplicationUserId { get; set;}
        [ForeignKey("ApplicationsUserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }
    }
}