using FlowerDelivery.DTO.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerDelivery.DTO.Entities
{
    public class Flower:Entity
    {
        [RegularExpression(@"^[A-Za-z]{4,}$",
         ErrorMessage = "It  should be  contains only latin charactes ")]
        public string LatinNaming { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z]{4,}$",
         ErrorMessage = "It  should be  contains only latin charactes ")]
        public string Class { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z]{4,}$",
        ErrorMessage = "It  should be  contains only latin charactes ")]
        public string Family { get; set; }
        [Required]
        [MinLength(30, ErrorMessage = "Describe more about flower. It would be better for customers")]
        [MaxLength(100, ErrorMessage = "Do not overhead by information. Make it a bit simple ")]
        public string ShortDescripton { get; set; }

        public ICollection<PlantationFlower> PlantationFlowers { get; set; }

        public string Photo { get; set; }
    }
}
