using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador_app
{
    internal abstract class Cliente
    {
        private string cuit;
        private List<Cuenta> cuentas;

        public string Cuit { get => cuit; }
        public List<Cuenta> Cuentas { get => cuentas; }

        public Cliente(string cuit, List<Cuenta> cuentas)
        {
            this.cuit = cuit;
            this.cuentas = cuentas;
        }

        public bool CrearCuenta()
        {
            return true;
        }

        public bool AgregarTitular(Cliente nuevoTitular, Cuenta cuenta)
        {
            return true;
        }

        public decimal Saldo(string nroCuenta)
        {
            return 0;
        }
    }
}
