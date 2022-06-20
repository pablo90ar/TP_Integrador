using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador_app
{
    internal interface ICuenta
    {
        void SimularPlazoFijo(decimal monto, int plazo);

        bool IniciarPlazoFijo(decimal monto, int plazo);

        void MoverDinero(decimal monto);
    }
}