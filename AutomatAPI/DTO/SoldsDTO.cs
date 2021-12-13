using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatAPI.Models
{
    public class SoldsDTO
    {      
        public int Id { get; set; }     
        public string Name { get; set; }    
        public decimal Price { get; set; }       
        public string PriceString { get; set; }        
        public decimal Tax { get; set; }     
        public DateTime SellsDateTime { get; set; }
    }
}
