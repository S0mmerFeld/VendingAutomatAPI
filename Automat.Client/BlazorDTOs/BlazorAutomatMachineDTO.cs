using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Client.BlazorDTOs
{
    public class BlazorAutomatMachineDTO
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int MaxProductNum { get; set; }
        public int CurrentProdNumber { get; set; }
    }
}
