using Microsoft.EntityFrameworkCore;
using PetRegister.Models;

namespace PetRegister.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>().HasData(
                new Gender {Id=1, GenderName = "male"},
                new Gender {Id=2, GenderName ="female"}
            );
            modelBuilder.Entity<Species>().HasData(
                new Species {Id=1, SpeciesName="cat"},
                new Species {Id=2, SpeciesName="mouse"},
                new Species {Id=3, SpeciesName="dog"}
            );
            modelBuilder.Entity<Pet>().HasData(
                new Pet {Id=1, Name="Tom", SpeciesId=1, GenderId=1, WeightInKg=5},
                new Pet {Id=2, Name="Jerry", SpeciesId=2, GenderId=1, WeightInKg=0.1F},
                new Pet {Id=3, Name="Spike", SpeciesId=3, GenderId=1, WeightInKg=30},
                new Pet {Id=4, Name="Shelkie", SpeciesId=1, GenderId=2, WeightInKg=3}
            );
        }
    }
}