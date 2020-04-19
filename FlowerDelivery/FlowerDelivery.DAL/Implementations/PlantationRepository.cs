using FlowerDelivery.DAL.Interfaces;
using FlowerDelivery.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerDelivery.DAL.Implementations
{
    public class PlantationRepository : IRepositoryPlantation
    {
        public Task Create(Plantation value)
        {
            throw new NotImplementedException();
        }

        public Task<Plantation> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Plantation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Remove(Plantation value)
        {
            throw new NotImplementedException();
        }

        public Task Update(Plantation value)
        {
            throw new NotImplementedException();
        }
    }
}
