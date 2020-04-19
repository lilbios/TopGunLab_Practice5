using FlowerDelivery.DAL.Interfaces;
using FlowerDelivery.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerDelivery.DAL.Implementations
{
    public class FlowerRepository : IRepositoryFlower
    {
        public Task Create(Flower value)
        {
            throw new NotImplementedException();
        }

        public Task<Flower> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Flower>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Remove(Flower value)
        {
            throw new NotImplementedException();
        }

        public Task Update(Flower value)
        {
            throw new NotImplementedException();
        }
    }
}
