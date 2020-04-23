﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FlowerDelivery.DTO.Entities
{
    public class Supply:Entity
    {
  
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Sheduled date")]
        public DateTime ScheduledDate { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Closed date")]
        public DateTime ClosedDate { get; set; }

       
        [Display(Name ="Supply status")]
        public Status Status { get; set; }

        public Guid PlantationId { get; set; }
        public Guid WarehouseId { get; set; }
        public Plantation Plantation { get; set; }
        public Warehouse Warehouse { get; set; }
        public ICollection<SupplyFlower> SupplyFlower { get; set; }


    }
}
