using Microsoft.EntityFrameworkCore;
using PetRegister.Models;

namespace PetRegister.Data
{
    public class PetRegisterContext : DbContext
    {
        public PetRegisterContext(DbContextOptions<PetRegisterContext> opt) : base(opt)
        {

        }

         public DbSet<Gender> Genders { get; set;}
         public DbSet<Species> Specieses { get; set;}
         public DbSet<Pet> Pets { get; set;}
         public DbSet<VetVisit> VetVisits { get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Seed();
        }
    }
}