using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TP_Integrador_app
{
    internal class Banco : IValidar
    {
        private List<Cliente> clientes = new List<Cliente>();
        private List<Cuenta> cuentas = new List<Cuenta>();
        private List<PlazoFijo> plazosFijos = new List<PlazoFijo>();

        private string nombreBanco;
        private string nombreSucursal;

        public string NombreSucursal { get => nombreSucursal; }

        public Banco(string nombreBanco, string nombreSucursal)
        {
            this.nombreBanco = nombreBanco;
            this.nombreSucursal = nombreSucursal;

            string dirProyecto = AppDomain.CurrentDomain.BaseDirectory;
            string directorioSucursales = Path.Combine(dirProyecto, @"..\..\..\bancos\" + this.nombreBanco + @"\");
            
            using (StreamReader sr_plazosFijos = new StreamReader(directorioSucursales + nombreSucursal + "-plazosfijos.txt"))
            {
                string datos_plazofijo = "";
                while ((datos_plazofijo = sr_plazosFijos.ReadLine()) != null)
                {
                    string[] campos = datos_plazofijo.Split('|');
                    string nroCuenta = campos[0].Split('-')[0];
                    decimal monto = decimal.Parse(campos[1]);
                    int duracion = int.Parse(campos[2]);
                    DateTime fechaInicio = DateTime.ParseExact(campos[3], "yyyyMMdd", CultureInfo.InvariantCulture);
                    PlazoFijo nuevoPlazoFijo = new PlazoFijo(nroCuenta, monto, duracion, fechaInicio);
                    plazosFijos.Add(nuevoPlazoFijo);
                }
            }

            using (StreamReader sr_cuentas = new StreamReader(directorioSucursales + nombreSucursal + "-cuentas.txt"))
            {
                string datos_cuenta = "";
                while((datos_cuenta = sr_cuentas.ReadLine()) != null)
                {
                    string[] campos = datos_cuenta.Split('|');
                    string nroCuenta = campos[0].Split('-')[0];
                    string tipo = campos[0].Split('-')[1];
                    decimal saldo = decimal.Parse(campos[1]);
                    Cuenta nuevaCuenta;
                    if (tipo == "01")
                    {
                        decimal descubierto = decimal.Parse(campos[2]);
                        nuevaCuenta = new CuentaCorriente(nroCuenta, saldo, descubierto);
                    }
                    else
                    {
                        nuevaCuenta = new CajaAhorro(nroCuenta, saldo);
                    }
                    foreach(PlazoFijo plazoFijo in plazosFijos)
                    {
                        if (plazoFijo.Cuenta == nuevaCuenta.Nro)
                        {
                            nuevaCuenta.AgrerarPlazoFijo(plazoFijo);
                        }
                    }
                    cuentas.Add(nuevaCuenta);
                }
            }

            using (StreamReader sr_personas = new StreamReader(directorioSucursales + nombreSucursal + "-personas.txt"))
            {
                string datos_cliente = "";
                while ((datos_cliente = sr_personas.ReadLine()) != null)
                {
                    string[] campos = datos_cliente.Split('|');
                    string cuit = campos[0];
                    string nombre = campos[1];
                    string apellido = campos[2];
                    decimal sueldoNeto = decimal.Parse(campos[3]);
                    List<string> nrosCuentasCliente = new List<string>(campos[4].Split(','));
                    List<Cuenta> cuentasCliente = new List<Cuenta>();
                    foreach (Cuenta cuenta in cuentas)
                    {
                        foreach (string nroCuentaCliente in nrosCuentasCliente)
                        {
                            if (int.Parse(nroCuentaCliente) == int.Parse(cuenta.Nro))
                            {
                                cuentasCliente.Add(cuenta);
                            }
                        }
                    }
                    Cliente nuevoCliente = new Persona(cuit, nombre, apellido, sueldoNeto, cuentasCliente);
                    clientes.Add(nuevoCliente);
                }
            }

            using (StreamReader sr_empresas = new StreamReader(directorioSucursales + nombreSucursal + "-empresas.txt"))
            {
                string datos_cliente = "";
                while ((datos_cliente = sr_empresas.ReadLine()) != null)
                {
                    string[] campos = datos_cliente.Split('|');
                    string cuit = campos[0];
                    string razonSocial = campos[1];
                    bool condIVA = false;
                    if (campos[2] == "inscripto")
                    {
                        condIVA = true;
                    }
                    string nroIIBB = campos[3];

                    List<string> nrosCuentasCliente = new List<string>(campos[4].Split(','));
                    List<Cuenta> cuentasCliente = new List<Cuenta>();
                    foreach (Cuenta cuenta in cuentas)
                    {
                        foreach(string nroCuentaCliente in nrosCuentasCliente)
                        {
                            if (int.Parse(nroCuentaCliente) == int.Parse(cuenta.Nro))
                            {
                                cuentasCliente.Add(cuenta);
                            }
                        }
                    }
                    Cliente nuevoCliente = new Empresa(cuit, razonSocial, condIVA, nroIIBB, cuentasCliente);
                    clientes.Add(nuevoCliente);
                }
            }

        }

        public bool AgregarCliente()
        {
            return true;
        }

        public Cliente BuscarCliente(string cuit)
        {
            foreach (var cliente in clientes)
            {
                if (cliente.Cuit == cuit)
                {
                    return cliente;
                }
            }
            return null;
        }

        public List<PlazoFijo> BuscarPlazosFijosDeCuenta(string nroCuenta)
        {
            List<PlazoFijo> plazosFijosCuenta = new List<PlazoFijo>();
            foreach(PlazoFijo plazoFijo in plazosFijos)
            {
                if (plazoFijo.Cuenta == nroCuenta)
                {
                    plazosFijosCuenta.Add(plazoFijo);
                }
            }
            return plazosFijosCuenta;
        }

        public decimal SaldoTesoreria()
        {
            return 10;
        }

        public void OperarCliente()
        {

        }

        public void Cerrar()
        {

        }

        public bool ValidarString(string stringValidable)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCuit(string cuitValidable)
        {
            throw new NotImplementedException();
        }
    }
}
