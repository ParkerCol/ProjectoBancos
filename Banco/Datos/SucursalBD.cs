using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace Banco.Datos
{
    class SucursalBD
    {

        OracleConnection miConexion = new OracleConnection("Data Source = localhost:1521/orcl; User ID = SEBASTIAN; Password = 12345;");
        //USER ID = SEBASTIAN; DATA SOURCE = localhost:1521/orcl

        public string agregarSucursal (int idSucursal, int cantEmpleados, int antiguedadSucursal, int idBancoSucursal, string nombreSucursal, string ubicacionSucursal)

        {
            string resultado = "";
            try
            {
                miConexion.Open();
                OracleCommand commandSucursal = new OracleCommand("SEBASTIAN.pcrRegistrarSucursal", miConexion);
                commandSucursal.Parameters.Add("(v_CodSucural", OracleDbType.Decimal, idSucursal, ParameterDirection.Input);
                commandSucursal.Parameters.Add("v_NombreSucursal", OracleDbType.Varchar2, 256, nombreSucursal, ParameterDirection.Input);
                commandSucursal.Parameters.Add("v_Ubicacion", OracleDbType.Varchar2, 256, ubicacionSucursal, ParameterDirection.Input);
                commandSucursal.Parameters.Add("(v_NumEmp", OracleDbType.Decimal, cantEmpleados, ParameterDirection.Input);
                commandSucursal.Parameters.Add("(v_AntigAnyos", OracleDbType.Decimal, antiguedadSucursal, ParameterDirection.Input);
                commandSucursal.Parameters.Add("(v_idBanco", OracleDbType.Decimal, idBancoSucursal, ParameterDirection.Input);

                commandSucursal.CommandType = CommandType.StoredProcedure;
                commandSucursal.ExecuteNonQuery();

                resultado = ("Sucursal con nombre: " + nombreSucursal + " con ID :" + idSucursal + " se a ingresado correctamente");
                return resultado;
            }

            catch (Exception)
            {
                resultado = " No se pudo ingresar la sucursal porfavor revisar datos al ingresar ";
                miConexion.Close();
                return resultado;
            }

            finally
            {
                if (miConexion.State == ConnectionState.Open)
                {
                    miConexion.Close();
                }
            }
        }

        public DataSet consultar (string nombreBanco, string ubicacionSuc)
        {
            try
            {
                miConexion.Open();
                OracleCommand commandSucursal = new OracleCommand("SEBASTIAN.prcConsultaSucursales", miConexion);
                commandSucursal.Parameters.Add("o_cursor", OracleDbType.RefCursor, ParameterDirection.Output);
                commandSucursal.Parameters.Add("v_nomBanco", OracleDbType.Varchar2, 256, nombreBanco, ParameterDirection.Input);
                commandSucursal.Parameters.Add("v_ubiSucursal", OracleDbType.Varchar2, 256, ubicacionSuc, ParameterDirection.Input);
                commandSucursal.CommandType = CommandType.StoredProcedure;

                // Data Adapter permite llenar dataset
                OracleDataAdapter da = new OracleDataAdapter(commandSucursal);
                DataSet ds = new DataSet();
                da.Fill(ds, " Sucursales");
                return ds;
            }

            
            catch (Exception e)
            {
                DataSet ds = new DataSet();
                ds = null;
                return ds;
            }
            finally
            {
                if (miConexion.State == ConnectionState.Open)
                {
                    miConexion.Close();
                }
            }           
                      
                                    
        }

    }

        
}
