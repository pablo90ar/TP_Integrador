using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
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
