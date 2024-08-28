﻿using Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Vehiculos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Marca { get; set; } = "";

        [Required]
        [StringLength(50)]
        public string Modelo { get; set; } = "";

        [Required]
        [StringLength(20)]
        public string Matricula { get; set; } = "";


        public long PersonaId { get; set; }

        [ForeignKey("PersonaId")]
        public Personas Persona { get; set; }


        public Vehiculo GetEntity()
        {
            return new Vehiculo()
            {
                Id = Id,
                Marca = Marca,
                Modelo = Modelo,
                Matricula = Matricula,
                PersonaId = PersonaId
            };
        }

        public static Vehiculos FromEntity(Vehiculo vehiculo)
        {
            return new Vehiculos()
            {
                Id = vehiculo.Id,
                Marca = vehiculo.Marca,
                Modelo = vehiculo.Modelo,
                Matricula = vehiculo.Matricula,
                PersonaId = vehiculo.PersonaId
            };
        }
    }
}
