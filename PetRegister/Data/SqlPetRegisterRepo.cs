using System.Collections.Generic;
using System.Linq;
using PetRegister.Dtos;
using PetRegister.Models;

namespace PetRegister.Data
{
    public class SqlPetRegisterRepo : IPetRegisterRepo
    {
        private readonly PetRegisterContext _context;

        public SqlPetRegisterRepo(PetRegisterContext context)
        {
            _context = context;
        }

        public void CreatePet(Pet pet)
        {
            _context.Add(pet);
        }

        public void DeletePet(Pet pet)
        {
            _context.Remove(pet);
        }

        public IEnumerable<PetReadDto> GetAllPets()
        {
            var pets = _context.Pets.Select(p => 
                new PetReadDto {
                    Id = p.Id,
                    Name = p.Name,
                    Species = p.Species.SpeciesName,
                    Gender = p.Gender.GenderName,
                    WeightInKg = p.WeightInKg
                    }
            ).ToList();

            return pets;
        }

        public PetReadDto GetPetById(int id)
        {
            return GetAllPets().FirstOrDefault(p => p.Id == id);
        }

        public Pet GetRawPetById(int id)
        {
            return _context.Pets.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}