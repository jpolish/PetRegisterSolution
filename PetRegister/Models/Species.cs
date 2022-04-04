using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetRegister.Models
{
    public class Species
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string SpeciesName { get; set; }
        public IEnumerable<Pet> Pets { get; set; }
    }

}