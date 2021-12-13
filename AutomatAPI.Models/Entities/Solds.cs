using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatAPI.Models
{
    public class Solds
    {
        [DisplayName("Sold id")] 
        public int Id { get; set; }

        [DisplayName("Product Name")]
        public string Name { get; set; }

        [DisplayName("Cost to customer")]
        public decimal Price { get; set; }
       
        [DisplayName("PriceString")]
        public string PriceString { get; set; }
      
        [DisplayName("Taxes")]
        public decimal Tax { get; set; }

        [DisplayName("SellsDate and Time")]
        public DateTime SellsDateTime { get; set; }

    }
}
