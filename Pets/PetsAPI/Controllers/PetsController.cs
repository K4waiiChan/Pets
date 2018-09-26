using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetsAPI.Repositories;
using PetsAPI.Database;
using PetsAPI.Models;


namespace PetsAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/pets")]
    public class PetsController : Controller
    {
        private PetsRepositorie petsRepositorie;
        public PetsController(PetsDbContext petsDbContext)
        {
            this.petsRepositorie = new PetsRepositorie(petsDbContext);
        }

        [HttpGet]
        public IEnumerable<Pet> GetAll()
        {
            return this.petsRepositorie.GetAll();
        }

        [HttpGet("{id}")]
        public Pet Get(int id)
        {
            return this.petsRepositorie.GetOne(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Pet pet)
        {
            IActionResult response;
            try
            {
                this.petsRepositorie.Create(pet);
                response = Ok();
            }
            catch(Exception exe)
            {
                response = BadRequest(exe.Message);
            }
            return response;
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody]Pet pet, int id)
        {
            IActionResult response;
            try
            {
                this.petsRepositorie.Edit(id, pet);
                response = Ok();
            }
            catch (Exception exe)
            {
                response = BadRequest(exe.Message);
            }
            return response;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            IActionResult response;
            try
            {
                this.petsRepositorie.delete(id);
                response = Ok();
            }
            catch (Exception exe)
            {
                response = BadRequest(exe.Message);
            }
            return response;
        }
    }
}