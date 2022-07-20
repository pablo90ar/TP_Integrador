using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Integrador_app;

namespace TP_Integrador_app
{
    public partial class Form1 : Form
    {
        public static Banco banco;
        public static Cliente cliente;
        public static Cuenta cuenta;
        public static int operacion;
        public static bool montoValido;
        public static bool duracionValida;
        public Form1()
        {
            InitializeComponent();
        }

        // Formulario principal //
        private void Form1_Load(object sender, EventArgs e)
        {
            string dirProyecto = AppDomain.CurrentDomain.BaseDirectory;
            string directorioBancos = Path.Combine(dirProyecto, @"..\..\..\bancos\");
            var bancos = Directory.GetDirectories(directorioBancos);
            foreach (var banco in bancos)
            {
                listaBancos.Items.Add(banco.Remove(0, directorioBancos.Length));
            }
            listaBancos.SelectedIndex = 0;
        }


        // Eventos Click
        private void BtnCargarBanco_Click(object sender, EventArgs e)
        {
            listaSucursales.Enabled = true;
            btnCargarSuc.Enabled = true;
            listaBancos.Enabled = false;
            btnCargarBanco.Enabled = false;
            var indexBancoElegido = listaBancos.SelectedIndex;
            var nombreBanco = listaBancos.Items[indexBancoElegido];
            string dirProyecto = AppDomain.CurrentDomain.BaseDirectory;
            string directorioSucursales = Path.Combine(dirProyecto, @"..\..\..\bancos\" + nombreBanco + @"\");
            var archivosFull = Directory.GetFiles(directorioSucursales);
            var archivos = new List<string>();
            foreach (var arch in archivosFull)
            {
                archivos.Add(arch.Remove(0, directorioSucursales.Length));
            }
            var listaSucursalesRep = new List<string>();
            foreach (var arch in archivos)
            {
                listaSucursalesRep.Add(arch.Remove(7));
            }
            List<string> listaSucursalesUnicas = listaSucursalesRep.Distinct().ToList();
            foreach (var suc in listaSucursalesUnicas)
            {
                listaSucursales.Items.Add(suc);
            }
            listaSucursales.SelectedIndex = 0;
        }

        private void BtnCargarSucursal_Click(object sender, EventArgs e)
        {
            listaSucursales.Enabled = false;
            btnCargarSuc.Enabled = false;
            ActivarMenu(true);
            banco = new Banco(listaBancos.Text, listaSucursales.Text);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            listaBancos.Enabled = true;
            btnCargarBanco.Enabled = true;
            listaSucursales.Items.Clear();
            ActivarMenu(false);
        }

        private void BtnMenuSaldo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saldo en tesorería: $400.00", "Tesorería");
        }

        private void BtnMenuOperar_Click(object sender, EventArgs e)
        {
            ActivarMenu(false);
            label3.Visible = true;
            tbCuitBuscado.Visible = true;
            btnOperarCliente.Visible = true;
            btnVolverAlBanco.Visible = true;

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            btnOperarCliente.Visible = false;
            btnOperarCliente.Enabled = true;
            btnOperarCuenta.Enabled = true;
            btnVolverAlBanco.Visible = false;
            tbCuitBuscado.Enabled = true;
            tbCuitBuscado.Visible = false;
            tbCuitBuscado.Text = "";
            label3.Visible = false;
            grupoCuenta.Visible = false;
            grupoMovimientos.Visible = false;
            grupoPlazoFijo.Visible = false;
            ActivarMenu(true);
            MostrarDatosCliente(false);
        }

        private void BtnOperarCliente_Click(object sender, EventArgs e)
        {
            var cuitBuscado = tbCuitBuscado.Text;
            cliente = banco.BuscarCliente(cuitBuscado);
            if (cliente != null)
            {
                
                if (cliente.GetType() == typeof(Persona))
                {
                    Persona clientePersona = (Persona)cliente;
                    tbxNombreCliente.Text = clientePersona.GetFullName();
                    cliente = clientePersona;
                }
                else if (cliente.GetType() == typeof(Empresa))
                {
                    Empresa clienteEmpresa = (Empresa)cliente;
                    tbxNombreCliente.Text = clienteEmpresa.GetFullName();
                    cliente = clienteEmpresa;
                }
                listaCuentasCliente.Items.Clear();
                foreach (Cuenta cuenta in cliente.Cuentas)
                {
                    string tipo;
                    _ = cuenta.GetType() == typeof(CuentaCorriente) ? tipo = "01" : tipo = "02";
                    listaCuentasCliente.Items.Add(banco.NombreSucursal + "-" + cuenta.Nro + "-" + tipo);
                }
                listaCuentasCliente.SelectedIndex = 0;
                montoCuenta.Text = LeerMontoCuenta(0).ToString();
                btnOperarCliente.Enabled = false;
                tbCuitBuscado.Enabled = false;
                grupoCuenta.Visible = true;
                cuenta = cliente.Cuentas[listaCuentasCliente.SelectedIndex];
                MostrarDatosCliente(true);
                MostrarDescubiertoSiExiste();
            }
            else
            {
                MessageBox.Show("No se encontró el cliente con ese CUIT", "Error");
            }
        }

        private void BtnOperarCuenta_Click(object sender, EventArgs e)
        {
            OperarCuenta();
        }

        private void BtnExtraer_Click(object sender, EventArgs e)
        {
            btnExtraer.Enabled = false;
            btnDepositar.Enabled = false;
            grupoPlazoFijo.Enabled = false;
            label10.Text = "Monto a extraer";
            label10.Visible = true;
            tbMontoOperacion.Visible = true;
            btnConfirmarOperacion.Visible = true;
            operacion = 1;
        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            btnExtraer.Enabled = false;
            btnDepositar.Enabled = false;
            grupoPlazoFijo.Enabled = false;
            label10.Text = "Monto a depositar";
            label10.Visible = true;
            tbMontoOperacion.Visible = true;
            btnConfirmarOperacion.Visible = true;
            operacion = 2;
        }

        private void BtnConfirmarOperacion_Click(object sender, EventArgs e)
        {
            int extraccion = 1;
            int deposito = 2;
            bool resultadoOperacion = false;
            decimal monto = decimal.Parse(tbMontoOperacion.Text);
            if (operacion == extraccion)
            {
                cuenta.Saldo -= monto;
                resultadoOperacion = true;
            }
            else if (operacion == deposito)
            {
                cuenta.Saldo += monto;
                resultadoOperacion = true;
            }
            if (!resultadoOperacion)
            {
                MessageBox.Show("Error en la operación");
            }
            else
            {
                tbMontoOperacion.Text = string.Empty;
                montoDisponible.Text = cuenta.ObtenerDisponible().ToString();
                montoCuenta.Text = cuenta.Saldo.ToString();
                MessageBox.Show("Operación exitosa. :)");
                OperarCuenta();
            }
        }

        private void BtnSimulacionPF_Click(object sender, EventArgs e)
        {
            operacion = 3;
            int simulacionPF = 3;
            if (operacion == simulacionPF)
            {
                grupoMovimientos.Enabled = false;
                btnSimulacionPF.Enabled = false;
                btnAltaPF.Enabled = false;
                tbMontoPF.Visible = true;
                tbDuracionPf.Visible = true;
                tbMontoPF.Text = string.Empty;
                tbDuracionPf.Text = string.Empty;
                label11.Visible = true;
                label12.Visible = true;
                btnSimularPF.Visible = true;

            }
        }

        private void BtnAltaPF_Click(object sender, EventArgs e)
        {
            operacion = 4;
            int altaPF = 4;
            if (operacion == altaPF)
            {
                grupoMovimientos.Enabled = false;
                btnSimulacionPF.Enabled = false;
                btnAltaPF.Enabled = false;
                tbMontoPF.Visible = true;
                tbDuracionPf.Visible = true;
                tbMontoPF.Text = string.Empty;
                tbDuracionPf.Text = string.Empty;
                label11.Visible = true;
                label12.Visible = true;
                btnCrearPF.Visible = true;

            }
        }

        private void BtnSimularPF_Click(object sender, EventArgs e)
        {
            decimal duracion = int.Parse(tbDuracionPf.Text);
            decimal monto = decimal.Parse(tbMontoPF.Text);
            decimal ganancia = (monto * 0.30M / 365 * duracion);
            ganancia = decimal.Round(ganancia, 2);
            MessageBox.Show("Constituyendo un Plazo Fijo por un monto de $" + monto + ", al término de " + duracion + " días, tendrá una ganacia de $" + ganancia + ".-", "Simulación de plazo fijo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbDuracionPf.Text = String.Empty;
            tbMontoPF.Text = String.Empty;
            OperarCuenta();
        }

        private void BtnCrearPF_Click(object sender, EventArgs e)
        {
            int duracion = int.Parse(tbDuracionPf.Text);
            decimal monto = decimal.Parse(tbMontoPF.Text);
            PlazoFijo plazoFijo = new PlazoFijo(cuenta.Nro, monto, duracion);
            cuenta.AgrerarPlazoFijo(plazoFijo);
            montoDisponible.Text = cuenta.ObtenerDisponible().ToString();
            MessageBox.Show("Plazo fijo creado de manera Exitosa", "Creación de Plazo Fijo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbDuracionPf.Text = String.Empty;
            tbMontoPF.Text = String.Empty;
            OperarCuenta();
        }


        // Eventos Select
        private void ListaCuentasCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listaCuentasCliente.SelectedIndex;
            montoCuenta.Text = LeerMontoCuenta(index).ToString();
            cuenta = cliente.Cuentas[listaCuentasCliente.SelectedIndex];
            montoDisponible.Text = (decimal.Parse(montoCuenta.Text) - LeerMontoPlazoFijo(index)).ToString();
            MostrarDescubiertoSiExiste();
        }


        // Operaciones auxiliares
        private void OperarCuenta()
        { 
            btnOperarCuenta.Enabled = false;
            listaCuentasCliente.Enabled = false;
            grupoMovimientos.Visible = true;
            grupoPlazoFijo.Visible = true;
            grupoMovimientos.Enabled = true;
            grupoPlazoFijo.Enabled = true;
            btnDepositar.Enabled = true;
            label10.Visible = false;
            tbMontoOperacion.Visible = false;
            btnConfirmarOperacion.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            tbMontoPF.Visible = false;
            tbDuracionPf.Visible = false;
            btnSimularPF.Visible = false;
            btnCrearPF.Visible = false;
            btnExtraer.Enabled = true;
            if (cuenta.GetType() == typeof(CuentaCorriente))
            {
                CuentaCorriente cc = (CuentaCorriente)cuenta;
                if (cc.MontoDescubierto + cc.ObtenerDisponible() == 0)
                {
                    btnExtraer.Enabled = false;
                }
            }

            if (cuenta.ObtenerDisponible() > 0)
            {
                btnSimulacionPF.Enabled = true;
                btnAltaPF.Enabled = true;
            }
            else
            {
                btnSimulacionPF.Enabled = false;
                btnAltaPF.Enabled = false;
            }
        }

        public void ActivarMenu(bool toogle)
        {
            btnSalir.Enabled = toogle;
            btnMenuSaldo.Enabled = toogle;
            btnMenuOperar.Enabled = toogle;
            btnMenuCrear.Enabled = toogle;
        }

        private void MostrarDatosCliente(bool toggle)
        {
            tbxNombreCliente.Visible = toggle;
            listaCuentasCliente.Visible = toggle;
            listaCuentasCliente.Enabled = toggle;
            label5.Visible = toggle;
            label6.Visible = toggle;
            label7.Visible = toggle;
            label8.Visible = toggle;
            btnOperarCuenta.Visible = toggle;
            montoCuenta.Visible = toggle;
            grupoCuenta.Visible = toggle;
            montoDisponible.Visible = toggle;

        }

        private void MostrarDescubiertoSiExiste()
        {
            labelDesc.Visible = false;
            montoDescubierto.Visible = false;
            CuentaCorriente cc = Es_cc(cuenta);
            if (cc != null)
            {
                labelDesc.Visible = true;
                montoDescubierto.Visible = true;
                montoDescubierto.Text = cc.MontoDescubierto.ToString();
            }
        }

        private decimal LeerMontoCuenta(int index)
        {
            return cliente.Cuentas[index].Saldo;
        }

        private decimal LeerMontoPlazoFijo(int index)
        {
            return cliente.Cuentas[index].Saldo - cliente.Cuentas[index].ObtenerDisponible();

        }

        private void TbMontoPF_TextChanged(object sender, EventArgs e)
        {
            decimal monto;
            try
            {
                monto = decimal.Parse(tbMontoPF.Text);
            }
            catch
            {
                monto = 0;
            }
            
            if (monto > 0 && monto <= cuenta.ObtenerDisponible())
            {
                montoValido = true;
            }
            else
            {
                montoValido = false;
            }
            ValidacionPlazoFijo();            
        }
        
        private void TbDuracionPf_TextChanged(object sender, EventArgs e)
        {
            int duracion;
            try
            {
                duracion = int.Parse(tbDuracionPf.Text);
            }
            catch
            {
                duracion = 0;
            }
            if (duracion > 0 && duracion <= 240)
            {
                duracionValida = true;
            }
            else
            {
                duracionValida = false;
            }
            ValidacionPlazoFijo();
        }

        private void ValidacionPlazoFijo()
        {
            if (montoValido && duracionValida)
            {
                btnCrearPF.Enabled = true;
                btnSimularPF.Enabled = true;
            }
            else
            {
                btnCrearPF.Enabled = false;
                btnSimularPF.Enabled = false;

            }
        }

        private CuentaCorriente Es_cc(Cuenta cuenta)
        {
            if (cuenta.GetType() == typeof(CuentaCorriente))
            {
                CuentaCorriente cc = (CuentaCorriente)cuenta;
                return cc;
            }
            return null;
        }

        private void TbCuitBuscado_TextChanged(object sender, EventArgs e)
        {
            string cuit = tbCuitBuscado.Text;
            bool largoValido = cuit.Length == 13 || cuit.Length == 12;
            bool formatoValido; 
            try
            {
                Int64 numero = Int64.Parse(cuit.Replace("-",""));
                formatoValido = (2 == cuit.Length - cuit.Replace("-","").Length);
            }
            catch
            {
                formatoValido = false;
            }
            if (largoValido && formatoValido)
            {
                btnOperarCliente.Enabled = true;
            }
            else
            {
                btnOperarCliente.Enabled = false;
            }
        }

        private void TbMontoOperacion_TextChanged(object sender, EventArgs e)
        {
            bool montoOperacionValido;
            bool extraccionValida = false;
            decimal monto;
            try
            {
                monto = decimal.Parse(tbMontoOperacion.Text);
                montoOperacionValido = (monto > 0);
                if (cuenta.GetType() == typeof(CuentaCorriente))
                {
                    CuentaCorriente cuentaCorriente = (CuentaCorriente)cuenta;
                    extraccionValida = monto <= cuenta.ObtenerDisponible() + cuentaCorriente.MontoDescubierto;
                }
                else
                {
                    CajaAhorro cajaAhorro = (CajaAhorro)cuenta;
                    extraccionValida = monto <= cajaAhorro.ObtenerDisponible();
                }
            }
            catch
            {
                montoOperacionValido = false;
            }
            if (montoOperacionValido)
            { 
                if(operacion == 1)
                {
                    if (extraccionValida)
                    {
                        btnConfirmarOperacion.Enabled = true;
                    }
                    else
                    {
                        btnConfirmarOperacion.Enabled = false;
                    }
                }
                else
                {
                    btnConfirmarOperacion.Enabled = true;
                }
                
            }
            else
            {
                btnConfirmarOperacion.Enabled = false;
            }
        }

        private void BtnMenuCrear_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
