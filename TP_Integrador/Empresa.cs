using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador_app
{
    internal class Empresa : Cliente
    {
        string razonSocial;
        bool condIVA;
        string nroIIBB;

        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public bool CondIVA { get => condIVA; set => condIVA = value; }
        public string NroIIBB { get => nroIIBB; set => nroIIBB = value; }
        public Empresa(string cuit, string razonSocial, bool condIVA, string nroIIBB, List<Cuenta> cuentas) : base(cuit, cuentas)
        {
            this.razonSocial = razonSocial;
            this.condIVA = condIVA;
            this.nroIIBB = nroIIBB;
        }

        public string getFullName()
        {
            return razonSocial;
        }
    }
}