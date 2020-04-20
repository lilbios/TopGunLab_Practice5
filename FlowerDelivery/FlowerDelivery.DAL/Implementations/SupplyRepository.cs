using FlowerDelivery.Contex;
using FlowerDelivery.DAL.Interfaces;
using FlowerDelivery.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FlowerDelivery.DAL.Implementations
{
    public class SupplyRepository : IRepositorySupply
    {

        private readonly FlowerDeliveryDbContext dbcontext;
        public SupplyRepository(FlowerDeliveryDbContext _context)
        {
            dbcontext = _context;
        }
        public async Task Create(Supply value)
        {
            dbcontext.Supplies.Add(value);
            await dbcontext.SaveChangesAsync();
        }

        public async Task<Supply> Get(params Guid[] identity)
        {
            var supply = await dbcontext.Supplies
                .Include(sf=> sf.SupplyFlower)
                .FirstOrDefaultAsync(s=> s.Id == identity[0]);
            return supply;
        }

        public async  Task<ICollection<Supply>> GetAll()
        {
            var supplies = await dbcontext.Supplies.ToListAsync();
            return supplies;
        }

        public async Task Remove(Supply value)
        {
            if (value != null)
            {
                dbcontext.Entry(value).State = EntityState.Deleted;
                await dbcontext.SaveChangesAsync();
            }
        }

        public async  Task Update(Supply value)
        {
            dbcontext.Entry(value).State = EntityState.Modified;
            await dbcontext.SaveChangesAsync();
        }
    }
}
