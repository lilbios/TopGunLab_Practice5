using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerDelivery.DTO.Entities
{
    public abstract class IntermediateEntity
    {
        [Range(1,int.MaxValue,ErrorMessage ="Enter valid number")]
        public int Amount { get; set; }
        [MinLength(11,ErrorMessage ="Write a bit more...")]
        [MaxLength(21,ErrorMessage ="Give short information.Don't overload description")]
        public string Info { get; set; }
    }
}
