using FlowerDelivery.Contex;
using FlowerDelivery.DAL.Interfaces;
using FlowerDelivery.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FlowerDelivery.DAL.Implementations
{
    public class WarehouseFlowerRepository : IRepositoryWarehouseFlower
    {

        private readonly FlowerDeliveryDbContext dbcontext;
        public WarehouseFlowerRepository(FlowerDeliveryDbContext _context)
        {
            dbcontext = _context;
        }
        public async  Task Create(WarehouseFlower value)
        {
            dbcontext.WarehouseFlowers.Add(value);
            await dbcontext.SaveChangesAsync();

        }

        public async Task<WarehouseFlower> Get(params Guid[] identity)
        {
            var warehouseFlowers = await dbcontext.WarehouseFlowers
                .FirstOrDefaultAsync(wf => wf.WarehouseId == identity[0] && wf.FlowerId == identity[1]);
            return warehouseFlowers;
        }

        public async Task<ICollection<WarehouseFlower>> GetAll()
        {
            var warehouseFlowers = await dbcontext.WarehouseFlowers.ToListAsync();
            return warehouseFlowers;
        }

        public async Task Remove(WarehouseFlower  value)
        {
            if (value != null)
            {
                dbcontext.Entry(value).State = EntityState.Deleted;
                await dbcontext.SaveChangesAsync();
            }
        }

        public async Task Update(WarehouseFlower value)
        {
            dbcontext.Entry(value).State = EntityState.Modified;
            await dbcontext.SaveChangesAsync();
        }
    }
}
