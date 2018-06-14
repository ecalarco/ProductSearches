using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductSearches.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Display(Name = "ID")]
        public int ProductID { get; set; }
        public string Description { get; set; }

        [Display(Name = "Last Sold")]
        [DataType(DataType.Date)]
        public DateTime LastSold { get; set; }

        [Display(Name = "Shelf Life")]
        public string ShelfLife { get; set; }

        public string Department { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string Unit { get; set; }
        public int XFor { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Cost { get; set; }
    }
}
