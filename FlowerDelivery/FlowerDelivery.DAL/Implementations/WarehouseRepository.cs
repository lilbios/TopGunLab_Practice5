using FlowerDelivery.Contex;
using FlowerDelivery.DAL.Interfaces;
using FlowerDelivery.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerDelivery.DAL.Implementations
{
    public class WarehouseRepository : IRepositoryWarehouse
    {

        private readonly FlowerDeliveryDbContext dbcontext;
        public WarehouseRepository(FlowerDeliveryDbContext _context)
        {
            dbcontext = _context;
        }
        public async Task Create(Warehouse value)
        {
            dbcontext.Warehouses.Add(value);
            await dbcontext.SaveChangesAsync();
        }

        public async Task<Warehouse> Get(params Guid[] identity)
        {
            var warehouse = await dbcontext.Warehouses
                .Include(wf=> wf.WarehouseFlowers).Include(s=> s.Supplies)
                .FirstOrDefaultAsync(w => w.Id == identity[0]);
            return warehouse;
        }

        public async Task<ICollection<Warehouse>> GetAll()
        {
            var warehouses = await dbcontext.Warehouses.ToListAsync();
            return warehouses;
        }

        public async Task Remove(Warehouse value)
        {
            if (value != null)
            {
                dbcontext.Entry(value).State = EntityState.Deleted;
                await dbcontext.SaveChangesAsync();
            }
        }

        public async Task Update(Warehouse value)
        {
            dbcontext.Entry(value).State = EntityState.Modified;
            await dbcontext.SaveChangesAsync();
        }
    }
}
