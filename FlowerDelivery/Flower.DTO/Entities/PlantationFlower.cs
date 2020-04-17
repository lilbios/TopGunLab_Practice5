using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerDelivery.DTO.Entities
{
    public class PlantationFlower: IntermediateEntity
    {

        [Key, Column(Order = 0)]
        public Guid PlantationId { get; set; }
        [Key, Column(Order = 1)]
        public Guid FlowerId { get; set; }

        public Plantation Plantation { get; set; }
        public Flower Flower { get; set; }
    }
}
