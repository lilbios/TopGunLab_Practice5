using FlowerDelivery.DAL.Interfaces;
using FlowerDelivery.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerDelivery.DAL.Implementations
{
    public class SupplyRepository : IRepositorySupply
    {
        public Task Create(Supply value)
        {
            throw new NotImplementedException();
        }

        public Task<Supply> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Supply>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Remove(Supply value)
        {
            throw new NotImplementedException();
        }

        public Task Update(Supply value)
        {
            throw new NotImplementedException();
        }
    }
}
