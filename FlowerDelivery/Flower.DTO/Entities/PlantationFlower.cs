using Flower.DTO.Entities;
using System;

namespace FlowerDelivery.DTO.Entities
{
    public class PlantationFlower: IntermediateEntity
    {
        public Guid PlantationId { get; set; }
        public Guid FlowerId { get; set; }

        public Plantation Plantation { get; set; }
        public Flower Flower { get; set; }
    }
}
