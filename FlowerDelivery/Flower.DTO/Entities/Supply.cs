using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FlowerDelivery.DTO.Entities
{
    public class Supply
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ScheduledDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ClosedDate { get; set; }

        
        [DefaultValue(Status.InPogress)]
        public Status Status { get; set; }

        public Guid PlantationId { get; set; }
        public Guid Warehouser { get; set; }
        public Plantation Plantation { get; set; }
        public Warehouse Warehouse { get; set; }


    }
}
