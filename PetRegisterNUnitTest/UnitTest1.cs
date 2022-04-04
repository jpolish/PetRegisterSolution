using NUnit.Framework;
using PetRegister.Models;
using PetRegister.Controllers;
using PetRegister.Data;
using PetRegister.Dtos;
using PetRegister.Profiles;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PetRegisterNUnitTest
{
    public class Tests
    {
        PetRegisterContext petRegisterContext { get; set;}
        PetRegisterController petRegisterController { get; set;}
        
        [SetUp]
        public void Setup()
        {
            var  config = new MapperConfiguration(cfg => cfg.AddProfile<PetsProfile>());
            var mapper = config.CreateMapper();
            var optionsBuilder = new DbContextOptionsBuilder<PetRegisterContext>();
            optionsBuilder.UseInMemoryDatabase("PetRegDB");
            //optionsBuilder.UseSqlServer("Server=<yourservername>\\SQLEXPRESS;Initial Catalog=PetRegisterDB;Integrated Security=true;");
            petRegisterContext = new PetRegisterContext(optionsBuilder.Options);
            petRegisterController = new PetRegisterController(
            new SqlPetRegisterRepo(petRegisterContext), mapper
            );

        }

        [Test]
        public void PetsTests()
        {
            
            petRegisterContext.Database.EnsureCreated();
            
            var pets = petRegisterController.GetAllPets();

            Assert.IsNotNull(pets,"Pets can't be null.");
            Assert.AreEqual(pets.Result.GetType().ToString(), "Microsoft.AspNetCore.Mvc.OkObjectResult");                        
            int c = ((List<PetReadDto>)((OkObjectResult)pets.Result).Value).Count;
            Assert.Greater(c, 0, "Pets' count can't be 0");
            
            petRegisterContext.Database.EnsureDeleted();
        }
        
        [TearDown]
        public void Tear_Down()
        {
            petRegisterContext = null;
            petRegisterController = null;
        }
    }
}