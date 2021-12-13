using Blazor.Client.BlazorDTOs;
using Blazor.Client.Clients.Interfaces;
using Blazor.Client.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Client.Services
{
    public class BlazorDiscountCardsService : IBlazorDiscountCardsService
    {
        private readonly IDiscountCardClient _iDiscountCardsClient;
        public BlazorDiscountCardsService(IDiscountCardClient iDiscountCardsClient)
        {
            _iDiscountCardsClient = iDiscountCardsClient;
        }

        public async Task<IEnumerable<BlazorDiscountCardDTO>> GetDiscountCards()
        {
            return await _iDiscountCardsClient.GetAllItems();
        }

        public async Task<BlazorDiscountCardDTO> GetDiscountCardById(int id)
        {
            return await _iDiscountCardsClient.GetById(id);
        }

        public async Task<bool> CreateDiscountCard(BlazorDiscountCardDTO discountcard)
        {
            return await _iDiscountCardsClient.Create(discountcard);
        }

        public async Task<bool> DeleteDiscountCard(int discountcardid)
        {
            return await _iDiscountCardsClient.Delete(discountcardid);
        }

        public async Task<bool> UpdateDiscountCard(int discountcardid, BlazorDiscountCardDTO discountcard)
        {
            return await _iDiscountCardsClient.Update(discountcardid, discountcard);
        }

    }
}
