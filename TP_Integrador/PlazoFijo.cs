using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador_app
{
    internal class PlazoFijo
    {
        private string cuenta;
        private decimal monto;
        private DateTime fechaInicio;
        private int duracion;

        public string Cuenta { get => cuenta; }
        public decimal Monto { get => monto; }
        public DateTime FechaInicio { get => fechaInicio; }
        public int Duracion { get => duracion; }
        public PlazoFijo (string cuentaOrigen, decimal monto, int duracion)
        {
            cuenta = cuentaOrigen;
            this.monto = monto;
            fechaInicio = DateTime.Now;
            this.duracion = duracion;
        }
        public PlazoFijo(string cuentaOrigen, decimal monto, int duracion, DateTime fechaInicio)
        {
            this.cuenta = cuentaOrigen;
            this.monto = monto;
            this.fechaInicio = fechaInicio;
            this.duracion = duracion;
        }
    }
}
