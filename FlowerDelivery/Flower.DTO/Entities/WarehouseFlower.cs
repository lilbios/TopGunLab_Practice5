using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerDelivery.DTO.Entities
{
    public class WarehouseFlower : IntermediateEntity
    {

        [Key, Column(Order = 0)]
        public Guid WarehouseId { get; set; }
        [Key, Column(Order = 1)]
        public Guid FlowerId { get; set; }
        public Warehouse Warehouse { get; set; }
        public Flower Flower { get; set; }
    }
}
