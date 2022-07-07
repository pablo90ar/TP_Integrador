using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Integrador_app;

namespace TP_Integrador_app
{
    internal class CajaAhorro : Cuenta, ICuenta
    {

        public CajaAhorro(string nroCuenta, decimal saldo) : base(nroCuenta, saldo)
        {

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
