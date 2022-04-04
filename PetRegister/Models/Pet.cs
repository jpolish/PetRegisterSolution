using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetRegister.Models
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public int SpeciesId { get; set; }
        public Species Species { get; set; }
        [Required]
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public IEnumerable<VetVisit> VetVisites  { get; set; }
        public float WeightInKg { get; set; }
    }
}