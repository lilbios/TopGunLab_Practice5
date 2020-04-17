using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerDelivery.DTO.Entities
{
     public  class SupplyFlower:IntermediateEntity
    {
         [Key,Column(Order = 0)]
        public Guid SupplyId { get; set; }
        [Key, Column(Order = 1)]
        public Guid FlowerId { get; set; }

        public Supply Supply { get; set; }
        public Flower Flower { get; set; }
    }
}
