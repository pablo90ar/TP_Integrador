using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Empresa : Cliente
    {
        string razonSocial;

        bool condicionIva;

        string nroIIBB;

        string actaSocios;

        string ultimoBalance;

        public Empresa(string cuit) : base(cuit)
        {
        }
    }
}
