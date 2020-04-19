using FlowerDelivery.DAL.Interfaces;
using FlowerDelivery.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerDelivery.DAL.Implementations
{
    public class PlantationFlowerRepository : IRepositoryPlantationFlower
    {
        public Task Create(PlantationFlower value)
        {
            throw new NotImplementedException();
        }

        public Task<PlantationFlower> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<PlantationFlower>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Remove(PlantationFlower value)
        {
            throw new NotImplementedException();
        }

        public Task Update(PlantationFlower value)
        {
            throw new NotImplementedException();
        }
    }
}
