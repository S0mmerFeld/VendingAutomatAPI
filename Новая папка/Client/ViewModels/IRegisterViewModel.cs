using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Client.ViewModels
{
    public interface IRegisterViewModel
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string ReenterPassword { get; set; }


        public Task RegisterUser();
    }
}