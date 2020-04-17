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
    }
}
