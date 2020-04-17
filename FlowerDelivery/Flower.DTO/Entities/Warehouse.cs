using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerDelivery.DTO.Entities
{
    public class Warehouse:Entity
    {
        [Required(ErrorMessage = "Required field")]
        public string Adress { get; set; }

        [Required(ErrorMessage ="Required field")]
        public string Country { get; set; }
        public ICollection<Supply> Supplies { get; set; }
        public ICollection<WarehouseFlower> WarehouseFlowers { get; set; }
    }
}
