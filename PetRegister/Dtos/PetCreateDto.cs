using System.ComponentModel.DataAnnotations;

namespace PetRegister.Dtos
{
    public class PetCreateDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public int SpeciesId { get; set; }
        [Required]
        public int GenderId { get; set; }
        [Required]
        public float WeightInKg { get; set; }
    }
}