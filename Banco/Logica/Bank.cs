using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Datos;

namespace Banco.Logica
{
     class Bank
    {
        BankBD bank = new BankBD();

        public string agregarBanco (int idBanco , string nombreBanco, string fechaCreacion)
        {

            return bank.agregarBanco(idBanco , nombreBanco , fechaCreacion);

        }
    }
}
