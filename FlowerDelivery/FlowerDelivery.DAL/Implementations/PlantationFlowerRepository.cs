using FlowerDelivery.Contex;
using FlowerDelivery.DAL.Interfaces;
using FlowerDelivery.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FlowerDelivery.DAL.Implementations
{
    public class PlantationFlowerRepository : IRepositoryPlantationFlower
    {
        private readonly FlowerDeliveryDbContext dbcontext;
        public PlantationFlowerRepository(FlowerDeliveryDbContext _context)
        {
            dbcontext = _context;
        }
        public async Task Create(PlantationFlower value)
        {
            dbcontext.PlantationFlowers.Add(value);
            await dbcontext.SaveChangesAsync();
        }

        public async Task<PlantationFlower> Get(params Guid[] identity)
        {
            var pId = identity[0];
            var fId = identity[1];
            var plantationFlower = await dbcontext.PlantationFlowers
                .FirstOrDefaultAsync(pf => pf.PlantationId == pId && pf.FlowerId == fId);
            return plantationFlower;
        }

        public async Task<ICollection<PlantationFlower>> GetAll()
        {
            var plantationFlowers = await dbcontext.PlantationFlowers.ToListAsync();
            return plantationFlowers;
        }

        public async Task Remove(PlantationFlower value)
        {
            if (value != null)
            {
                dbcontext.Entry(value).State = EntityState.Deleted;
                await dbcontext.SaveChangesAsync();
            }
        }

        public async Task Update(PlantationFlower value)
        {
            dbcontext.Entry(value).State = EntityState.Modified;
            await dbcontext.SaveChangesAsync();
        }
    }
}
