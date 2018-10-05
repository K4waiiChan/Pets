using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace PetsAPI.Models
{
    public class Mascota
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Origen { get; set; }
        public string Emfermedades { get; set; }
        public bool Estado { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public DateTime FechaDeRegistro { get; set; }
    }
}
