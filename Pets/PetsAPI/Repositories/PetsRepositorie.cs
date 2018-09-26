using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetsAPI.Database;
using PetsAPI.Models;


namespace PetsAPI.Repositories
{
    public class PetsRepositorie
    {
        public PetsDbContext PetsDbContext { get; set; }

        public PetsRepositorie(PetsDbContext petsDbContext)
        {
            this.PetsDbContext = petsDbContext;
        }

        public void Create(Pet pet)
        {
            this.PetsDbContext.Pets.Add(pet);
            this.PetsDbContext.SaveChanges();
        }

        public IEnumerable<Pet> GetAll()
        {
            return this.PetsDbContext.Pets.ToList();
        }

        public Pet GetOne(int id)
        {
            Pet pet = this.PetsDbContext.Pets.Find(id);
            if (pet == null)
            {
                throw new Exception("Pet with id:" + id + " not found");
            }
            return pet;
        }

        public void Edit(int id, Pet newPet)
        {
            Pet pet = this.GetOne(id);
            pet.Name = newPet.Name;
            this.PetsDbContext.SaveChanges();
        }

        public void delete(int id)
        {
            this.PetsDbContext.Remove(this.GetOne(id));
            this.PetsDbContext.SaveChanges();
        }
    }
}