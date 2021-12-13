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



    public class AutomatMachineService : IGenericService<AutomatMachine>, IAutomatMachineService
    {
        private readonly ProductContext _context;
        public AutomatMachineService(ProductContext context)
        {
            _context = context;
        }

        public async Task<List<AutomatMachine>> GetAllAsync()
        {
            var automatMachines = await _context.AutomatMachine.Select(x => new AutomatMachine()
            {
                Id = x.Id,
                InventoryId = x.InventoryId,
                Name = x.Name,
                Address = x.Address,
                MaxProductNum = x.MaxProductNum,
                CurrentProdNumber = x.CurrentProdNumber    
            }).ToListAsync();

            if (automatMachines == null) 
                throw new ItemNotFoundException($"{typeof(AutomatMachine).Name} could not found.");
            return automatMachines;
        }


        public async Task<AutomatMachine> GetByIdAsync(int automatMachineId)
        {
            var automatMachines = await _context.AutomatMachine.Where(x => x.Id == automatMachineId).Select(x => new AutomatMachine()
            {
                Id = x.Id,
                CurrentProdNumber = x.CurrentProdNumber,
                InventoryId = x.InventoryId,
                MaxProductNum = x.MaxProductNum,
                Name = x.Name,
                Address = x.Address

            }).FirstOrDefaultAsync();    
            
            if (automatMachines == null) 
                throw new ItemNotFoundException($"{typeof(AutomatMachine).Name} item with id {automatMachineId} not found.");
            return automatMachines;
        }

        public async Task<AutomatMachine> AddAsync(AutomatMachine automatMachineModel)
        {
            var automatMachine = new AutomatMachine()
            {
                Id = automatMachineModel.Id,
                CurrentProdNumber = automatMachineModel.CurrentProdNumber,
                InventoryId = automatMachineModel.InventoryId,
                MaxProductNum = automatMachineModel.MaxProductNum,
                Name = automatMachineModel.Name,
                Address = automatMachineModel.Address

            };

            _context.AutomatMachine.Add(automatMachine);

            await _context.SaveChangesAsync();
            return automatMachine;

        }

        public async Task UpdateAsync(int automatMachineId, AutomatMachine automatMachineModel)
        {
            var product = await _context.AutomatMachine.FindAsync(automatMachineId);
            if (product != null)
            {
                product.CurrentProdNumber = automatMachineModel.CurrentProdNumber;
                product.InventoryId = automatMachineModel.InventoryId;
                product.MaxProductNum = automatMachineModel.MaxProductNum;
                product.Name = automatMachineModel.Name;
                product.Address = automatMachineModel.Address;
                product.Id = automatMachineModel.Id;

                await _context.SaveChangesAsync();
            }

        }

        public async Task DeleteAsync(int automatMachineId)
        {
            var automatMachine = await GetByIdAsync(automatMachineId);           
            if (automatMachine == null) 
                throw new ItemNotFoundException($"{typeof(AutomatMachine).Name} with id {automatMachineId} not found");
            _context.AutomatMachine.Remove(automatMachine);
            await _context.SaveChangesAsync();
        }
    }
}
