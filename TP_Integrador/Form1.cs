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
using TP_Integrador;

namespace TP_Integrador_app
{
    public partial class Form1 : Form
    {
        Banco banco;
        Cliente cliente;
        Cuenta cuenta;
        int operacion;
        public Form1()
        {
            InitializeComponent();
        }

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

        public void ActivarMenu(bool toogle)
        {
            btnSalir.Enabled = toogle;
            btnMenuSaldo.Enabled = toogle;
            btnMenuOperar.Enabled = toogle;
            btnMenuCrear.Enabled = toogle;
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
                MostrarDatosCliente(true);
                if (cliente.GetType() == typeof(Persona))
                {
                    Persona clientePersona = (Persona)cliente;
                    tbxNombreCliente.Text = clientePersona.getFullName();
                    cliente = clientePersona;
                }
                else if (cliente.GetType() == typeof(Empresa))
                {
                    Empresa clienteEmpresa = (Empresa)cliente;
                    tbxNombreCliente.Text = clienteEmpresa.getFullName();
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
            }
            else
            {
                MessageBox.Show("No se encontró el cliente con ese CUIT", "Error");
            }
            //TablaDesdeArchivoTXT(file);
            //dataGridView1.DataSource = TablaDesdeArchivoTXT(file);
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
            grupoCuenta.Visible=toggle;
            montoDisponible.Visible = toggle;
        }

        private decimal LeerMontoCuenta(int index)
        {
            return cliente.Cuentas[index].Saldo;
        }

        private decimal LeerMontoPlazoFijo(int index)
        {
            PlazoFijo plazoFijo = cliente.Cuentas[index].PlazoFijo;

            if (plazoFijo != null)
            {
                return plazoFijo.Monto;
            }
            return 0;
        }

        private void ListaCuentasCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listaCuentasCliente.SelectedIndex;
            montoCuenta.Text = LeerMontoCuenta(index).ToString();
            montoDisponible.Text = (decimal.Parse(montoCuenta.Text) - LeerMontoPlazoFijo(index)).ToString();
        }

        private void BtnOperarCuenta_Click(object sender, EventArgs e)
        {
            OperarCuenta();
        }

        private void OperarCuenta()
        {
            btnOperarCuenta.Enabled = false;
            listaCuentasCliente.Enabled = false;
            grupoMovimientos.Visible = true;
            grupoPlazoFijo.Visible = true;
            grupoMovimientos.Enabled = true;
            grupoPlazoFijo.Enabled = true;
            btnExtraer.Enabled = true;
            btnDepositar.Enabled = true;
            btnSimularPF.Enabled = true;
            btnAltaPF.Enabled = true;
            label10.Visible = false;
            tbMontoOperacion.Visible = false;
            btnConfirmarOperacion.Visible = false;
            cuenta = cliente.Cuentas[listaCuentasCliente.SelectedIndex];
        }

        private void MostrarOperacionesCuenta(bool toggle)
        {

        }


        // TABLA //
        private DataTable TablaDesdeArchivoTXT(string ubicacion, char separador = '|')
        {
            DataTable resultado;
            //ubicacion = file;

            string[] arregloLinea = File.ReadAllLines(ubicacion);
            resultado = DesdeTabla(arregloLinea, separador);
            return resultado;
        }

        private DataTable DesdeTabla(string[] arregloLinea, char separador)
        {
            DataTable dt = new DataTable();

            for (int c = 1; c < arregloLinea.Length; c++)
            {
                if (tbCuitBuscado.Text == arregloLinea[c])
                {
                    AddColumnToTable(arregloLinea, separador, ref dt);
                    AddRowToTable(arregloLinea, separador, ref dt);
                }
            }
            return dt;
        }

        private void AddRowToTable(string[] value, char separador, ref DataTable dt)
        {
            for (int i = 1; i < value.Length; i++)
            {
                string[] values = value[i].Split(separador);
                DataRow dr = dt.NewRow();
                for (int j = 0; j < values.Length; j++)
                {
                    dr[j] = values[j];
                }
                dt.Rows.Add(dr);
            }
        }

        private void AddColumnToTable(string[] columna, char separador, ref DataTable dt)
        {
            string[] columnas = columna[0].Split(separador);
            foreach (string columnaNombre in columnas)
            {
                DataColumn dc = new DataColumn(columnaNombre, typeof(string));
                dt.Columns.Add(dc);
            }
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            btnExtraer.Enabled = false;
            btnDepositar.Enabled = false;
            grupoPlazoFijo.Enabled = false;
            label10.Text = "Monto a extraer";
            label10.Visible = true;
            tbMontoOperacion.Visible = true;
            btnConfirmarOperacion.Visible=true;
            btnConfirmarOperacion.Enabled=true;
            operacion = 1;
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            btnExtraer.Enabled = false;
            btnDepositar.Enabled = false;
            grupoPlazoFijo.Enabled = false;
            label10.Text = "Monto a depositar";
            label10.Visible = true;
            tbMontoOperacion.Visible = true;
            btnConfirmarOperacion.Visible = true;
            btnConfirmarOperacion.Enabled = true;
            operacion = 2;
        }

        private void btnConfirmarOperacion_Click(object sender, EventArgs e)
        {
            int extraccion = 1;
            int deposito = 2;
            bool resultadoOperacion = false;
            decimal monto = decimal.Parse(tbMontoOperacion.Text);
            if (operacion == extraccion && monto <= cuenta.GetDisponible() && monto > 0)
            {
                cuenta.Saldo -= monto;
                resultadoOperacion=true;
            }
            else if (operacion == deposito && monto > 0)
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
                montoDisponible.Text = cuenta.GetDisponible().ToString();
                montoCuenta.Text = cuenta.Saldo.ToString();
                MessageBox.Show("Operación exitosa. :)");
                OperarCuenta();
            }
        }

        private void btnSimularPF_Click(object sender, EventArgs e)
        {
            int simulacionPF = 3;
            if (operacion == simulacionPF)
            {

            }
        }

        private void btnAltaPF_Click(object sender, EventArgs e)
        {
            int altaPF = 4;
            if (operacion == altaPF)
            {

            }
        }

        //public static string file = @"C:\C#\Clientes.txt";
    }
}
