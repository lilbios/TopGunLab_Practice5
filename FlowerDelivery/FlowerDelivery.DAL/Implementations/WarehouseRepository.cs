using FlowerDelivery.DAL.Interfaces;
using FlowerDelivery.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlowerDelivery.DAL.Implementations
{
    public class WarehouseRepository : IRepositoryWarehouse
    {
        public Task Create(Warehouse value)
        {
            throw new NotImplementedException();
        }

        public Task<Warehouse> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Warehouse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Remove(Warehouse value)
        {
            throw new NotImplementedException();
        }

        public Task Update(Warehouse value)
        {
            throw new NotImplementedException();
        }
    }
}
