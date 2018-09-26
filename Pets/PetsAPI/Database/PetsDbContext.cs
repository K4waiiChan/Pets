using PetsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetsAPI.Database
{
    public class PetsDbContext : DbContext
    {
        /// <summary>
        /// DataBase initilizador
        /// </summary>
        /// <param name="options"></param>
        public PetsDbContext(DbContextOptions<PetsDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// Account table
        /// </summary>
        public DbSet<Pet> Pets { get; set; }

        /// <summary>
        /// DataBase configuration
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
