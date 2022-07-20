using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador_app
{
    public abstract class Cliente
    {
        private string cuit;
        private List<Cuenta> cuentas;

        public string Cuit { get => cuit; }
        public List<Cuenta> Cuentas { get => cuentas; }

        public string CuentasCsv()
        {
            string listaCuentas = "";
            foreach (Cuenta cuenta in Cuentas)
            {
                listaCuentas += int.Parse(cuenta.Nro).ToString() + ",";
            }
            return listaCuentas.Remove(listaCuentas.Length - 1);
        }

        public Cliente(string cuit, List<Cuenta> cuentas)
        {
            this.cuit = cuit;
            this.cuentas = cuentas;
        }
    }
}
