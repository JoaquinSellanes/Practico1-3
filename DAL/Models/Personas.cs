using Shared;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Personas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(8)]
        public string Documento { get; set; } = "";

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; } = "";

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; } = "";

        [Required]
        [StringLength(15)]
        public string Telefono { get; set; } = "";

        [Required]
        [StringLength(100)]
        public string Direccion { get; set; } = "";

        [Required]
        public DateTime FechaNacimiento { get; set; }


        public Persona GetEntity()
        {
            return new Persona()
            {
                Id = Id,
                Documento = Documento,
                Nombres = Nombres,
                Apellidos = Apellidos,
                Telefono = Telefono,
                Direccion = Direccion,
                FechaNacimiento = FechaNacimiento
            };
        }

        public static Personas FromEntity(Persona persona)
        {
            return new Personas()
            {
                Id = persona.Id,
                Documento = persona.Documento,
                Nombres = persona.Nombres,
                Apellidos = persona.Apellidos,
                Telefono = persona.Telefono,
                Direccion = persona.Direccion,
                FechaNacimiento = persona.FechaNacimiento
            };
        }
    }
}
