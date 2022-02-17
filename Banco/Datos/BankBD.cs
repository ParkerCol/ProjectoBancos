using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace Banco.Datos
{
     class BankBD
    {
        OracleConnection miConexion = new OracleConnection("Data Source = localhost:1521/orcl; User ID = SEBASTIAN; Password = 12345;");
        //USER ID = SEBASTIAN; DATA SOURCE = localhost:1521/orcl
        public string agregarBanco (int idBanco, string nombreBanco, string fechaCreacion)
        {
            try
            {
                miConexion.Open();
                OracleCommand commandBanco = new OracleCommand("SEBASTIAN.pcrRegistrarBanco", miConexion);
                commandBanco.Parameters.Add("v_NitBanco", OracleDbType.Decimal, idBanco, ParameterDirection.Input);
                commandBanco.Parameters.Add("v_Nombre", OracleDbType.Varchar2, 256, nombreBanco, ParameterDirection.Input);
                commandBanco.Parameters.Add("v_Fecha", OracleDbType.Varchar2, 256, fechaCreacion, ParameterDirection.Input);
                commandBanco.CommandType = CommandType.StoredProcedure;
                commandBanco.ExecuteNonQuery();

                return " Ingresado Correctamente el banco con nombre ; " + nombreBanco + " con id ; " + idBanco;
            }

            catch (Exception e)
            {
                return " No se pudo ingresar el banco correctamente revise datos a ingresar";
            }
             finally
            {
                if ( miConexion.State == ConnectionState.Open)
                {
                    miConexion.Close();
                }
            }
            
           
            
        }
    }
}
