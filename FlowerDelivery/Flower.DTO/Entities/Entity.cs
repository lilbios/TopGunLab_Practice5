using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerDelivery.DTO.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
