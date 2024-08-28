using System;

namespace Shared
{
    public class Vehiculo
    {
        public long Id { get; set; }

        public string Marca { get; set; } = "-- Sin Marca --";

        public string Modelo { get; set; } = "-- Sin Modelo --";

        private string matricula = "";
        public string Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                if (value.Length < 6)
                    throw new Exception("Formato de matrícula incorrecto.");
                else
                    matricula = value.ToUpper();
            }
        }

        public long PersonaId { get; set; } // Referencia al ID de Persona asociada

        public string GetString()
        {
            return $"Id: {Id}, Marca: {Marca}, Modelo: {Modelo}, Matrícula: {Matricula}, PersonaId: {PersonaId}";
        }
    }
}
