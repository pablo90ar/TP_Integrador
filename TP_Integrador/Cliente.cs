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

        public string Cuit { get => cuit; set => cuit = value; }

        public Cliente(string cuit)
        {
            Cuit = cuit;
        }

        public bool CrearCuenta()
        {
            return true;
        }

        public decimal Saldo()
        {
            return 0;
        }
    }
}
