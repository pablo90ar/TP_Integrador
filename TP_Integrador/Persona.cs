using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador_app
{
    internal class Persona : Cliente
    {
        string nombre;
        string apellido;
        decimal sueldoNeto;

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public decimal SueldoNeto { get => sueldoNeto; set => sueldoNeto = value; }

        public Persona(string cuit, string nombre, string apellido, decimal sueldoNeto, List<Cuenta> cuentas) : base(cuit, cuentas)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldoNeto = sueldoNeto;
        }

        public string GetFullName()
        {
            return nombre + " " + apellido;
        }
    }
}
