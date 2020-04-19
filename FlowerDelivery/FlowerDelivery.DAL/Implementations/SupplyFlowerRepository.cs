using FlowerDelivery.Contex;
using FlowerDelivery.DAL.Interfaces;
using FlowerDelivery.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FlowerDelivery.DAL.Implementations
{
    public class SupplyFlowerRepository : IRepositorySupplyFlower
    {
        private readonly FlowerDeliveryDbContext dbcontext;
        public SupplyFlowerRepository(FlowerDeliveryDbContext _context)
        {
            dbcontext = _context;
        }

        public async Task Create(SupplyFlower value)
        {
            dbcontext.SupplyFlowers.Add(value);
            await dbcontext.SaveChangesAsync();
        }

        public async Task<SupplyFlower> Get(params Guid[] identity)
        {
            var supplyFlower = await dbcontext.SupplyFlowers
                .FirstOrDefaultAsync(sf=> sf.SupplyId == identity[0] && sf.SupplyId == identity[1]);
            return supplyFlower;
        }

        public async Task<ICollection<SupplyFlower>> GetAll()
        {
            var supplyFlowers = await dbcontext.SupplyFlowers.ToListAsync();
            return  supplyFlowers;

        }

        public async Task Remove(SupplyFlower value)
        {
            if (value != null)
            {
                dbcontext.Entry(value).State = EntityState.Deleted;
                await dbcontext.SaveChangesAsync();
            }
        }

        public async Task Update(SupplyFlower value)
        {
            dbcontext.Entry(value).State = EntityState.Modified;
            await dbcontext.SaveChangesAsync();
        }
    }
}
