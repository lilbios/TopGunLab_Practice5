using FlowerDelivery.Contex;
using FlowerDelivery.DAL.Interfaces;
using FlowerDelivery.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FlowerDelivery.DAL.Implementations
{
    public class FlowerRepository : IRepositoryFlower
    {
        private readonly FlowerDeliveryDbContext dbcontext;
        public FlowerRepository(FlowerDeliveryDbContext _context)
        {
            dbcontext = _context;
        }
        public async Task Create(Flower value)
        {
            dbcontext.Flowers.Add(value);
            await dbcontext.SaveChangesAsync();
        }

        public async Task<Flower> Get(params Guid[] identeficators)
        {
            var flower = await dbcontext.Flowers.FirstOrDefaultAsync(f => f.Id == identeficators[0]);
            return flower;
        }

        public async Task<ICollection<Flower>> GetAll()
        {
            var flowers = await dbcontext.Flowers.ToListAsync();
            return flowers;
        }

        public async Task Remove(Flower value)
        {
            if (value != null)
            {
                dbcontext.Entry(value).State = EntityState.Deleted;
                await dbcontext.SaveChangesAsync();
            }
        }

        public async Task Update(Flower value)
        {
            dbcontext.Entry(value).State = EntityState.Modified;
            await dbcontext.SaveChangesAsync();

        }
    }
}
