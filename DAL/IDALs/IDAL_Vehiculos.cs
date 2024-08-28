using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IDALs
{
    public interface IDAL_Vehiculos
    {
        List<Vehiculo> GetVehiculos();
        Vehiculo GetVehiculo(long id);
        Vehiculo AddVehiculo(Vehiculo vehiculo);
        void DeleteVehiculo(long id);
        Vehiculo UpdateVehiculo(Vehiculo vehiculo);

    }
}
