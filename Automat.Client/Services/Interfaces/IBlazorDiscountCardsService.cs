using Automat.Client.BlazorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automat.Client.Services.Interfaces
{
    public interface IBlazorDiscountCardsService
    {
        Task<IEnumerable<BlazorDiscountCardDTO>> GetDiscountCards();

        Task<BlazorDiscountCardDTO> GetDiscountCardById(int discountcardId);
        Task<bool> CreateDiscountCard(BlazorDiscountCardDTO automatMachine);
        Task<bool> UpdateDiscountCard(int discountcardId, BlazorDiscountCardDTO discountcard);
        Task<bool> DeleteDiscountCard(int discountcardId);
    }
}
