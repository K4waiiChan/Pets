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

        public void Create(Mascota pet)
        {
            pet.Imagen = "";
            pet.FechaDeRegistro = DateTime.Now;
            this.PetsDbContext.Mascota.Add(pet);
            this.PetsDbContext.SaveChanges();
        }

        public IEnumerable<Mascota> GetAll()
        {
            return this.PetsDbContext.Mascota.ToList();
        }

        public Mascota GetOne(int id)
        {
            Mascota pet = this.PetsDbContext.Mascota.Find(id);
            if (pet == null)
            {
                throw new Exception("Mascota con id:" + id + " no encontrada");
            }
            return pet;
        }

        public void Edit(int id, Mascota newPet)
        {
            Mascota pet = this.GetOne(id);
            pet.Nombre = newPet.Nombre;
            this.PetsDbContext.SaveChanges();
        }

        public void delete(int id)
        {
            this.PetsDbContext.Remove(this.GetOne(id));
            this.PetsDbContext.SaveChanges();
        }
    }
}