using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador_app
{
    internal class CuentaCorriente : Cuenta, ICuenta
    {
        private decimal montoDescubierto;

        public CuentaCorriente(string nroCuenta, decimal saldo, decimal montoDescubierto) : base(nroCuenta, saldo)
        {
            this.montoDescubierto = montoDescubierto;
        }

        public bool IniciarPlazoFijo(decimal monto, int plazo)
        {
            throw new NotImplementedException();
        }

        public void MoverDinero(decimal monto)
        {
            throw new NotImplementedException();
        }

        public void SimularPlazoFijo(decimal monto, int plazo)
        {
            throw new NotImplementedException();
        }

    }
}
