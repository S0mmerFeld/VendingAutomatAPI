using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Client.BlazorDTOs
{
    public class BlazorProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }        
        public string ShortDescription { get; set; }
        public int Sells { get; set; }
        public int CurrentQuantity { get; set; }
    }
}
