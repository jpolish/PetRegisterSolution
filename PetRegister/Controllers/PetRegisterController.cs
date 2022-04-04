using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetRegister.Data;
using PetRegister.Dtos;
using PetRegister.Models;

namespace PetRegister.Controllers
{
    [Route("api/pets")]
    [ApiController]
    public class PetRegisterController : ControllerBase
    {
        private readonly IPetRegisterRepo _repository;
        private readonly IMapper _mapper;

        public PetRegisterController(IPetRegisterRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PetReadDto>> GetAllPets()
        {
            var pets = _repository.GetAllPets();
            return Ok(pets);
        }
        [HttpGet("{id}", Name="GetPetById")]
        public ActionResult<PetReadDto> GetPetById(int id)
        {
            PetReadDto pet = _repository.GetPetById(id);
            return Ok(pet); 
        }
        [HttpPost]
        public ActionResult<PetReadDto> CreatePet(PetCreateDto petCreateDto)
        {
           var petModel = _mapper.Map<Pet>(petCreateDto);
           _repository.CreatePet(petModel);
           _repository.SaveChanges();
           var petReadDto = _repository.GetPetById(petModel.Id); 
        
           return CreatedAtRoute(nameof(GetPetById), new {id = petModel.Id}, petReadDto);
           //return Ok(petReadDto); 
        }
        [HttpPut("{id}")]
        public ActionResult UpdatePet(int id, PetUpdateDto petUpdateDto)
        {
           var petModelById = _repository.GetRawPetById(id) ;
           _mapper.Map(petUpdateDto, petModelById);

           _repository.SaveChanges();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeletePet(int id)
        {
           var petModelById = _repository.GetRawPetById(id) ;
            _repository.DeletePet(petModelById);

           _repository.SaveChanges();

            return NoContent();
        }
    }
}