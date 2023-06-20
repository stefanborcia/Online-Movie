using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Title{ get; set; }
        [Required]

        public string Description{ get; set; }
        [Required]

        public string Actors{ get; set; }
        [Required]
        [Display(Name = "List Price")]
        [Range(1,1000)]
        public double ListPrice { get; set; }

        [Required]
        [Display(Name = "Price for 1-3")]
        [Range(1, 1000)]
        public double Price { get; set; }

        [Required]
        [Display(Name = "3-5")]
        [Range(1, 1000)]
        public double Price3 { get; set; }

        [Required]
        [Display(Name = "Price for 5+")]
        [Range(1, 1000)]
        public double Price5 { get; set; }

    }
}
