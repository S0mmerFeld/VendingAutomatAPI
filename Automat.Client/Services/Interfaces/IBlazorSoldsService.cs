﻿using Automat.Client.BlazorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automat.Client.Services.Interfaces
{
    public interface IBlazorSoldsService
    {
        Task<IEnumerable<BlazorSoldsDTO>> GetSolds();
    }
}
