using System;
using System.Collections.Generic;
using DAL.DALs;
using DAL.IDALs;
using Shared;

class Program
{
    static void Main()
    {
        IDAL_Personas dal_Personas = new DAL_Personas_EF();
        IDAL_Vehiculos dal_Vehiculos = new DAL_Vehiculos_EF();

        string comando = string.Empty;

        do
        {
            imprimirMenu();
            try
            {
                comando = Console.ReadLine().ToUpper();

                switch (comando)
                {
                    case "NUEVA_PERSONA":
                        Persona persona = new Persona();
                        Console.WriteLine("Ingrese los nombres de la persona: ");
                        persona.Nombres = Console.ReadLine();
                        Console.WriteLine("Ingrese los apellidos de la persona: ");
                        persona.Apellidos = Console.ReadLine();
                        Console.WriteLine("Ingrese el documento de la persona: ");
                        persona.Documento = Console.ReadLine();
                        Console.WriteLine("Ingrese el teléfono de la persona: ");
                        persona.Telefono = Console.ReadLine();
                        Console.WriteLine("Ingrese la dirección de la persona: ");
                        persona.Direccion = Console.ReadLine();
                        Console.WriteLine("Ingrese la fecha de nacimiento de la persona (yyyy-mm-dd): ");
                        persona.FechaNacimiento = DateTime.Parse(Console.ReadLine());

                        dal_Personas.AddPersona(persona);
                        Console.WriteLine("Persona agregada con éxito.");
                        break;

                    case "IMPRIMIR_PERSONAS":
                        List<Persona> listaPersonas = dal_Personas.GetPersonas();
                        foreach (Persona p in listaPersonas)
                        {
                            Console.WriteLine($"Id: {p.Id} - Nombre: {p.Nombres} {p.Apellidos} - Documento: {p.Documento}");
                        }
                        break;

                    case "CONSULTAR_PERSONA":
                        Console.WriteLine("Ingrese el ID de la persona a buscar...");
                        long personaId = long.Parse(Console.ReadLine());
                        Persona consultaPersona = dal_Personas.GetPersona(personaId);
                        if (consultaPersona != null)
                        {
                            Console.WriteLine($"Id: {consultaPersona.Id} - Nombre: {consultaPersona.Nombres} {consultaPersona.Apellidos} - Documento: {consultaPersona.Documento}");
                        }
                        else
                        {
                            Console.WriteLine("Persona no encontrada.");
                        }
                        break;

                    case "MODIFICAR_PERSONA":
                        Console.WriteLine("Ingrese el ID de la persona a modificar...");
                        long idModificar = long.Parse(Console.ReadLine());
                        Persona personaMod = dal_Personas.GetPersona(idModificar);
                        if (personaMod != null)
                        {
                            Console.WriteLine("Ingrese el nuevo nombre de la persona: ");
                            personaMod.Nombres = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo apellido de la persona: ");
                            personaMod.Apellidos = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo documento de la persona: ");
                            personaMod.Documento = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo teléfono de la persona: ");
                            personaMod.Telefono = Console.ReadLine();
                            Console.WriteLine("Ingrese la nueva dirección de la persona: ");
                            personaMod.Direccion = Console.ReadLine();
                            Console.WriteLine("Ingrese la nueva fecha de nacimiento de la persona (yyyy-mm-dd): ");
                            personaMod.FechaNacimiento = DateTime.Parse(Console.ReadLine());

                            dal_Personas.UpdatePersona(personaMod);
                            Console.WriteLine("Persona actualizada con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("Persona no encontrada.");
                        }
                        break;

                    case "ELIMINAR_PERSONA":
                        Console.WriteLine("Ingrese el ID de la persona a eliminar...");
                        long idEliminar = long.Parse(Console.ReadLine());
                        dal_Personas.DeletePersona(idEliminar);
                        Console.WriteLine("Persona eliminada con éxito.");
                        break;

                    case "NUEVO_VEHICULO":
                        Vehiculo vehiculo = new Vehiculo();
                        Console.WriteLine("Ingrese la marca del vehículo: ");
                        vehiculo.Marca = Console.ReadLine();
                        Console.WriteLine("Ingrese el modelo del vehículo: ");
                        vehiculo.Modelo = Console.ReadLine();
                        Console.WriteLine("Ingrese la matrícula del vehículo: ");
                        vehiculo.Matricula = Console.ReadLine();
                        Console.WriteLine("Ingrese el ID de la persona asociada al vehículo: ");
                        vehiculo.PersonaId = long.Parse(Console.ReadLine());

                        dal_Vehiculos.AddVehiculo(vehiculo);
                        Console.WriteLine("Vehículo agregado con éxito.");
                        break;

                    case "IMPRIMIR_VEHICULOS":
                        List<Vehiculo> listaVehiculos = dal_Vehiculos.GetVehiculos();
                        foreach (Vehiculo v in listaVehiculos)
                        {
                            Console.WriteLine($"Id: {v.Id} - Marca: {v.Marca} - Modelo: {v.Modelo} - Matrícula: {v.Matricula} - PersonaId: {v.PersonaId}");
                        }
                        break;

                    case "CONSULTAR_VEHICULO":
                        Console.WriteLine("Ingrese el ID del vehículo a buscar...");
                        long vehiculoId = long.Parse(Console.ReadLine());
                        Vehiculo consultaVehiculo = dal_Vehiculos.GetVehiculo(vehiculoId);
                        if (consultaVehiculo != null)
                        {
                            Console.WriteLine($"Id: {consultaVehiculo.Id} - Marca: {consultaVehiculo.Marca} - Modelo: {consultaVehiculo.Modelo} - Matrícula: {consultaVehiculo.Matricula} - PersonaId: {consultaVehiculo.PersonaId}");
                        }
                        else
                        {
                            Console.WriteLine("Vehículo no encontrado.");
                        }
                        break;

                    case "MODIFICAR_VEHICULO":
                        Console.WriteLine("Ingrese el ID del vehículo a modificar...");
                        long idModificarVehiculo = long.Parse(Console.ReadLine());
                        Vehiculo vehiculoMod = dal_Vehiculos.GetVehiculo(idModificarVehiculo);
                        if (vehiculoMod != null)
                        {
                            Console.WriteLine("Ingrese la nueva marca del vehículo: ");
                            vehiculoMod.Marca = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo modelo del vehículo: ");
                            vehiculoMod.Modelo = Console.ReadLine();
                            Console.WriteLine("Ingrese la nueva matrícula del vehículo: ");
                            vehiculoMod.Matricula = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo ID de la persona asociada al vehículo: ");
                            vehiculoMod.PersonaId = long.Parse(Console.ReadLine());

                            dal_Vehiculos.UpdateVehiculo(vehiculoMod);
                            Console.WriteLine("Vehículo actualizado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("Vehículo no encontrado.");
                        }
                        break;

                    case "ELIMINAR_VEHICULO":
                        Console.WriteLine("Ingrese el ID del vehículo a eliminar...");
                        long idEliminarVehiculo = long.Parse(Console.ReadLine());
                        dal_Vehiculos.DeleteVehiculo(idEliminarVehiculo);
                        Console.WriteLine("Vehículo eliminado con éxito.");
                        break;

                    case "EXIT":
                        break;

                    default:
                        Console.WriteLine("Comando no reconocido.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine("");
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
        while (comando != "EXIT");

        Console.WriteLine("Hasta luego!!!");
        Console.ReadLine();
    }

    static void imprimirMenu()
    {
        Console.WriteLine("=========== PRACTICO 1 ===========");
        Console.WriteLine("NUEVA_PERSONA: Agregar una nueva persona");
        Console.WriteLine("IMPRIMIR_PERSONAS: Imprimir personas");
        Console.WriteLine("CONSULTAR_PERSONA: Consultar una persona");
        Console.WriteLine("MODIFICAR_PERSONA: Modificar una persona");
        Console.WriteLine("ELIMINAR_PERSONA: Eliminar una persona");
        Console.WriteLine("NUEVO_VEHICULO: Agregar un nuevo vehículo");
        Console.WriteLine("IMPRIMIR_VEHICULOS: Imprimir vehículos");
        Console.WriteLine("CONSULTAR_VEHICULO: Consultar un vehículo");
        Console.WriteLine("MODIFICAR_VEHICULO: Modificar un vehículo");
        Console.WriteLine("ELIMINAR_VEHICULO: Eliminar un vehículo");
        Console.WriteLine("EXIT: Salir");
        Console.WriteLine("==================================");
    }
}
