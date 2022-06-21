using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Integrador;

namespace TP_Integrador_app
{
    internal abstract class Cuenta
    {
        private string nro;
        private decimal saldo;
        private PlazoFijo plazofijo;
        public string Nro { get => nro; }
        public decimal Saldo { get => saldo; set => saldo = value; }

        public decimal GetDisponible()
        {
            if (plazofijo != null)
            {
                return Saldo - plazofijo.Monto;
            } 
            else
            {
                return Saldo;
            }
        }
        public PlazoFijo PlazoFijo { get => plazofijo; }

        public Cuenta(string nroCuenta, decimal saldoCuenta)
        {
            nro = nroCuenta;
            saldo = saldoCuenta;
            plazofijo = null;
        }
    }
}
