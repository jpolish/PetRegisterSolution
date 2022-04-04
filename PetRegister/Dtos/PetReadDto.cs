using System.Collections.Generic;
using PetRegister.Models;

namespace PetRegister.Dtos
{
    public class PetReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public float WeightInKg { get; set; }
    }
}