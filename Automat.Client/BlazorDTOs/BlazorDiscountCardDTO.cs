using Automat.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Client.BlazorDTOs
{
    public class BlazorDiscountCardDTO: BlazorCard
    {
        public float PurchaseSum { get; set; }
    }
}
