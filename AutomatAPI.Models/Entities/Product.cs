using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatAPI.Models
{
    public class Product
    {

        [DisplayName("Product code id")] 
        public int Id { get; set; }

        [DisplayName("Product Name")]
        public string Name { get; set; }

        [DisplayName("Cost to customer")]
        public decimal Price { get; set; }

        [DisplayName("Section number")]
        public string Location { get; set; }
        
        [DisplayName("Product description")]
        public string Description { get; set; }

        [DisplayName("Number of sells")]
        public int Sells { get; set; }

        [DisplayName("PriceString")]
        public string PriceString { get; set; }

        [DisplayName("ShortDescription")]
        public string ShortDescription { get; set; }

        [DisplayName("Current quantity")]
        public int CurrentQuantity { get; set; }

    }
}
