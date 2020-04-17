using Flower.DTO.Entities;
using System;

namespace FlowerDelivery.DTO.Entities
{
    public class WarehouseFlower : IntermediateEntity
    {

        public Guid WarehouseId { get; set; }
        public Guid FlowerId { get; set; }
        public Warehouse Warehouse { get; set; }
        public Flower Flower { get; set; }
    }
}
