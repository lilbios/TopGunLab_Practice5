using Flower.DTO.Entities;
using System;

namespace FlowerDelivery.DTO.Entities
{
     public  class SupplyFlower:IntermediateEntity
    {
        public Guid SupplyId { get; set; }
        public Guid FlowerId { get; set; }

        public Supply Supply { get; set; }
        public Flower Flower { get; set; }
    }
}
