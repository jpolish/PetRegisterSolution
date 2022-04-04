using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetRegister.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string GenderName { get; set; }
        public IEnumerable<Pet> Pets  { get; set; }
    }

}