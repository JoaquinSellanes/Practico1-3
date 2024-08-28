using DAL.IDALs;
using DAL.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DALs
{
    public class DAL_Vehiculos_EF : IDAL_Vehiculos
    {
        public List<Vehiculo> GetVehiculos()
        {
            using (var context = new DBContext())
            {
                return context.Vehiculos
                              .Select(v => v.GetEntity())
                              .ToList();
            }
        }

        public Vehiculo GetVehiculo(long id)
        {
            using (var context = new DBContext())
            {
                var vehiculo = context.Vehiculos.Find(id);
                return vehiculo?.GetEntity();
            }
        }

        public Vehiculo AddVehiculo(Vehiculo vehiculo)
        {
            using (var context = new DBContext())
            {
                var vehiculoEntity = Vehiculos.FromEntity(vehiculo);
                context.Vehiculos.Add(vehiculoEntity);
                context.SaveChanges();
                return vehiculoEntity.GetEntity();
            }
        }

        public void DeleteVehiculo(long id)
        {
            using (var context = new DBContext())
            {
                var vehiculo = context.Vehiculos.Find(id);
                if (vehiculo != null)
                {
                    context.Vehiculos.Remove(vehiculo);
                    context.SaveChanges();
                }
            }
        }

        public Vehiculo UpdateVehiculo(Vehiculo vehiculo)
        {
            using (var context = new DBContext())
            {
                var vehiculoEntity = context.Vehiculos.Find(vehiculo.Id);
                if (vehiculoEntity != null)
                {
                    vehiculoEntity.Marca = vehiculo.Marca;
                    vehiculoEntity.Modelo = vehiculo.Modelo;
                    vehiculoEntity.Matricula = vehiculo.Matricula;
                    vehiculoEntity.PersonaId = vehiculo.PersonaId;

                    context.Vehiculos.Update(vehiculoEntity);
                    context.SaveChanges();
                    return vehiculoEntity.GetEntity();
                }
                return null;
            }
        }
    }
}
