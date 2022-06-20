using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Persona : Cliente
    {
        string nombre;
        string apellido;
        decimal sueldoNeto;
        decimal capacidadCredito;
        List<string> recibosSueldo;
        public Persona(string cuit) : base(cuit)
        {
        }
    }
}
