using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Client.BlazorDTOs
{
    public class BlazorServiceManDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public BlazorServiceCardDTO SMCard { get; set; }
    }
}
