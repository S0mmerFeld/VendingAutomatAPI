using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Models.Statistics
{
    public class TotalSells
    {
       
        [DisplayName("Product Name")]
        public string Name { get; set; }

        [DisplayName("Cost to customer")]
        public decimal Price { get; set; }

        [DisplayName("Total sells")]
        public int Sells { get; set; }

        [DisplayName("Money")]
        public int Income { get; set; }

    }
}
