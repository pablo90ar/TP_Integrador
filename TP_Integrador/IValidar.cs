using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal interface IValidar
    {
        bool ValidarString(string stringValidable);

        bool ValidarCuit(string cuitValidable);
    }
}
