using FlowerDelivery.Contex;
using FlowerDelivery.DAL.Interfaces;
using FlowerDelivery.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FlowerDelivery.DAL.Implementations
{
    public class PlantationRepository : IRepositoryPlantation
    {

        private readonly FlowerDeliveryDbContext dbcontext;
        public PlantationRepository(FlowerDeliveryDbContext _context)
        {
            dbcontext = _context;
        }
        public async Task Create(Plantation value)
        {
            dbcontext.Plantations.Add(value);
            await dbcontext.SaveChangesAsync();
        }

        public async Task<Plantation> Get(params Guid[] identity)
        {
            var id = identity[0];
            var plantation = await dbcontext.Plantations.FirstOrDefaultAsync(p => p.Id == id);
            return plantation;
        }

        public async Task<ICollection<Plantation>> GetAll()
        {
            var plantations = await dbcontext.Plantations.ToListAsync();
            return plantations;
        }

        public async Task Remove(Plantation value)
        {
            if (value != null)
            {
                dbcontext.Entry(value).State = EntityState.Deleted;
                await dbcontext.SaveChangesAsync();
            }
        }

        public async Task Update(Plantation value)
        {
            dbcontext.Entry(value).State = EntityState.Modified;
            await dbcontext.SaveChangesAsync();
        }
    }
}
