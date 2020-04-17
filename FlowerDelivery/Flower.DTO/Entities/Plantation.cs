using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerDelivery.DTO.Entities
{
    public class Plantation:Entity
    {
        [Required(ErrorMessage ="Required field")]
        public string Adress { get; set; }
        public ICollection<Supply> Supplies { get; set; }
    }
}
