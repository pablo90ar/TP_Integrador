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
        private List<PlazoFijo> plazosfijos;
        public string Nro { get => nro; }
        public decimal Saldo { get => saldo; set => saldo = value; }

        public decimal GetDisponible()
        {
            decimal disponible = Saldo;
            if (plazosfijos != null)
            {
                foreach (var plazoFijo in plazosfijos)
                {
                    disponible -= plazoFijo.Monto;
                }
            }
            return disponible;
            
        }
        public List<PlazoFijo> PlazoFijo { get => plazosfijos; }

        public Cuenta(string nroCuenta, decimal saldoCuenta)
        {
            nro = nroCuenta;
            saldo = saldoCuenta;
            plazosfijos = null;
        }
    }
}
