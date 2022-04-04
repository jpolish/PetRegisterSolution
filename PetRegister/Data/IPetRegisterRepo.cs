using System.Collections.Generic;
using PetRegister.Dtos;
using PetRegister.Models;

namespace PetRegister.Data
{
    public interface IPetRegisterRepo
    {
        IEnumerable<PetReadDto> GetAllPets();
        PetReadDto GetPetById(int id);
        Pet GetRawPetById(int id);
        void CreatePet(Pet pet);
        void DeletePet(Pet pet);
        bool SaveChanges();
    }
}