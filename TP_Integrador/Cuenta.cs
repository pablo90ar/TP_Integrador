using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador_app
{
    public abstract class Cuenta
    {
        private string nro;
        private decimal saldo;
        private List<PlazoFijo> plazosfijosCuenta;
        public string Nro { get => nro; }
        public decimal Saldo { get => saldo; set => saldo = value; }

        public decimal ObtenerDisponible()
        {
            decimal disponible = Saldo;
            if (plazosfijosCuenta != null)
            {
                foreach (var plazoFijo in plazosfijosCuenta)
                {
                    disponible -= plazoFijo.Monto;
                }
            }
            return disponible;
        }
        public List<PlazoFijo> PlazosFijos { get => plazosfijosCuenta; }

        public void AgrerarPlazoFijo(PlazoFijo plazoFijo)
        {
            plazosfijosCuenta.Add(plazoFijo);
        }

        public Cuenta(string nroCuenta, decimal saldoCuenta)
        {
            nro = nroCuenta;
            saldo = saldoCuenta;
            plazosfijosCuenta = new List<PlazoFijo>();
        }
    }
}
