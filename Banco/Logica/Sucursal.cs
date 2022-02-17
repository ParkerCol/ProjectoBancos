using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Datos;

namespace Banco.Logica
{
    
    class Sucursal

    {
        SucursalBD miSucursal = new SucursalBD();
        public string agregarSucursal (int idSucursal,int cantEmpleados,int antiguedadSucursal,int idBancoSucursal,string nombreSucursal,string ubicacionSucursal)
        {

            return miSucursal.agregarSucursal(idSucursal, cantEmpleados, antiguedadSucursal, idBancoSucursal, nombreSucursal, ubicacionSucursal);
        }

        public DataSet consultar (string nombreBanco, string ubicacionSuc )
        {
            DataSet miDataSucursal = new DataSet();
            miDataSucursal = miSucursal.consultar(nombreBanco, ubicacionSuc);
            return miDataSucursal;
        }

    }
}
