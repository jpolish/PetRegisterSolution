using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetRegister.Models
{
    public class VetVisit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PetId { get; set; }
        public Pet Pet { get; set; }
        [Required]
        public DateTime VetVisitDate { get; set; }
    }

}