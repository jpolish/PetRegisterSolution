using AutoMapper;
using PetRegister.Models;
using PetRegister.Dtos;

namespace PetRegister.Profiles
{
    public class PetsProfile : Profile
    {
        public PetsProfile()
        {
            //source --> target
           CreateMap<PetCreateDto, Pet>();
           CreateMap<PetUpdateDto, Pet>();
        }
    }
}