using System;

namespace Shared
{
    public class Persona
    {
        public long Id { get; set; }

        private string documento = "";
        public string Documento
        {
            get
            {
                return documento;
            }
            set
            {
                if (value.Length < 7)
                    throw new Exception("Formato de documento incorrecto.");
                else
                    documento = value.ToUpper();
            }
        }

        public string Nombres { get; set; } = "-- Sin Nombre --";
        public string Apellidos { get; set; } = "-- Sin Apellido --";

        private string telefono = "";
        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                if (value.Length < 7)
                    throw new Exception("Formato de teléfono incorrecto.");
                else
                    telefono = value;
            }
        }

        public string Direccion { get; set; } = "-- Sin Dirección --";

        public DateTime FechaNacimiento { get; set; } = DateTime.MinValue;

        public string GetString()
        {
            return $"Id: {Id}, Documento: {Documento}, Nombres: {Nombres}, Apellidos: {Apellidos}, Telefono: {Telefono}, Direccion: {Direccion}, Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}";
        }
    }
}
