using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerDelivery.DTO.Entities
{
    public abstract class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [MinLength(4,ErrorMessage ="Length cannot be less than 4 charactes")]
        [MaxLength(30, ErrorMessage = "Allowed 30 charactes")]
        [Required(ErrorMessage ="Required filed")]
        public string Name { get; set; }
    }
}
