using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DbFirstApproach.Models
{
    public class ProductMetaData
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product Name can not be empty!"), MaxLength(10, ErrorMessage = "Max Lentgh should be 10"), Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required, Range(0, 1000)]
        public double Price { get; set; }
        
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}