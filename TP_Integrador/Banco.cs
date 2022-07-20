using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TP_Integrador_app
{
    public class Banco : IValidar
    {
        private List<Cliente> clientes = new List<Cliente>();
        private List<Cuenta> cuentas = new List<Cuenta>();
        private List<PlazoFijo> plazosFijos = new List<PlazoFijo>();

        public string nombreBanco;
        public string nombreSucursal;

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
                    string directorioRecibos = Path.Combine(directorioSucursales, @"recibos_sueldo\");
                    bool recibo_1_ok = File.Exists(directorioRecibos + "suc" + nombreSucursal + "_recibo_" + cuit + "_1.pdf");
                    bool recibo_2_ok = File.Exists(directorioRecibos + "suc" + nombreSucursal + "_recibo_" + cuit + "_2.pdf");
                    bool recibo_3_ok = File.Exists(directorioRecibos + "suc" + nombreSucursal + "_recibo_" + cuit + "_3.pdf");
                    if (recibo_1_ok && recibo_2_ok && recibo_3_ok)
                    {
                        Cliente nuevoCliente = new Persona(cuit, nombre, apellido, sueldoNeto, cuentasCliente);
                        clientes.Add(nuevoCliente);
                    }
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
                    string directorioBalances = Path.Combine(directorioSucursales, @"balances\");
                    bool balance_ok = File.Exists(directorioBalances + "suc" + nombreSucursal + "_bal_" + cuit + ".zip");
                    string directorioActas = Path.Combine(directorioSucursales, @"actas\");
                    bool acta_ok = File.Exists(directorioActas + "suc" + nombreSucursal + "_acta_" + cuit + ".pdf");
                    if (balance_ok && acta_ok)
                    {
                        Cliente nuevoCliente = new Empresa(cuit, razonSocial, condIVA, nroIIBB, cuentasCliente);
                        clientes.Add(nuevoCliente);
                    }
                    
                }
            }

        }

        public void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void AgregarCuentaCorriente(string nroCuenta, decimal descubierto = 0)
        {
            Cuenta nuevaCuentaCorriente = new CuentaCorriente(nroCuenta, 0, descubierto);
            cuentas.Add(nuevaCuentaCorriente);
        }

        public void AgregarCajaAhorro(string nroCuenta)
        {
            Cuenta nuevaCajaAhorro = new CajaAhorro(nroCuenta, 0);
            cuentas.Add(nuevaCajaAhorro);
        }

        public Cliente BuscarCliente(string cuit)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Cuit == cuit)
                {
                    return cliente;
                }
            }
            return null;
        }

        public Cuenta BuscarCuenta(string nro)
        {
            foreach (Cuenta cuenta in cuentas)
            {
                if(cuenta.Nro == nro)
                {
                    return cuenta;
                }
            }
            return null;
        }

        public string NumCuentaNueva()
        {
            int numCuentaNueva = 1;
            while (BuscarCuenta(numCuentaNueva.ToString().PadLeft(13, '0')) != null)
            {
                numCuentaNueva++;
            }
            return numCuentaNueva.ToString().PadLeft(13, '0');
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
