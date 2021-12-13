using Automat.BLL.Exceptions;
using Automat.DAL.Context;
using AutomatAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.DAL.Repositories
{
    public class DiscountCardService : IGenericService<DiscountCard>, IDiscountCardService
    {
        private readonly ProductContext _context;
        public DiscountCardService(ProductContext context)
        {
            _context = context;
        }

        public async Task<List<DiscountCard>> GetAllAsync()
        {
            var discountCards = await _context.DiscountCard.Select(x => new DiscountCard()
            {
                Id = x.Id,
                PurchaseSum = x.PurchaseSum,
                Discount = x.Discount,

            }).ToListAsync();

            if (discountCards == null)
                throw new ItemNotFoundException($"{typeof(DiscountCard).Name} could not found.");

            return discountCards;
        }

        public async Task<DiscountCard> GetByIdAsync(int discountCardId)
        {
            var discountCards = await _context.DiscountCard.Where(x => x.Id == discountCardId).Select(x => new DiscountCard()
            {
                Id = x.Id,
                PurchaseSum = x.PurchaseSum,
                Discount = x.Discount

            }).FirstOrDefaultAsync();

            if (discountCards == null)
                throw new ItemNotFoundException($"{typeof(DiscountCard).Name} item with id {discountCardId} not found.");

            return discountCards;
        }

        public async Task<DiscountCard> AddAsync(DiscountCard discountCardModel)
        {
            var discountCard = new DiscountCard()
            {
                Id = discountCardModel.Id,
                PurchaseSum = discountCardModel.PurchaseSum,
                Discount = discountCardModel.Discount
            };

            _context.DiscountCard.Add(discountCard);


            await _context.SaveChangesAsync();
            return discountCard;

        }

        public async Task UpdateAsync(int discountCardId, DiscountCard discountCardModel)
        {
            var discountCard = await _context.DiscountCard.FindAsync(discountCardId);
            if (discountCard != null)
            {
                discountCard.Discount = discountCardModel.Discount;
                discountCard.PurchaseSum = discountCardModel.PurchaseSum;

                await _context.SaveChangesAsync();
            }

        }

        public async Task DeleteAsync(int discountCardId)
        {            
            var discountCard = await GetByIdAsync(discountCardId);
            if (discountCard == null)
                throw new ItemNotFoundException($"{typeof(AutomatMachine).Name} with id {discountCardId} not found");

            _context.DiscountCard.Remove(discountCard);

            await _context.SaveChangesAsync();
        }







    }
}
