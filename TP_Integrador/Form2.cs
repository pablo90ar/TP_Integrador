using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Integrador_app
{
    public partial class Form2 : Form
    {
        public string directorioBanco;
        public string directorioRecibos;
        public string directorioActas;
        public string directorioBalances;
        public string nombreSucursal;
        public string numNuevaCajaAhorro;
        public string numNuevaCuentaCorriente;
        public string descubiertoNuevaCuentaCorriente = "0";
        public string numCuentaExistente;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string dirProyecto = AppDomain.CurrentDomain.BaseDirectory;
            string nombreBanco = Form1.banco.nombreBanco;
            directorioBanco = Path.Combine(dirProyecto, @"..\..\..\bancos\", nombreBanco);
            directorioRecibos = Path.Combine(directorioBanco, @"recibos_sueldo\");
            directorioActas = Path.Combine(directorioBanco, @"actas\");
            directorioBalances = Path.Combine(directorioBanco, @"balances\");
            nombreSucursal = Form1.banco.nombreSucursal;
        }
        private string CargarArchivo(string titlulo = "Cargar archivo", string fileType = "PDF files | *.pdf")
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = fileType,
                Title = titlulo,
                Multiselect = false
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return String.Empty;
        }

        private bool ValidarCuit(string cuit)
        {
            if (string.IsNullOrEmpty(cuit)) throw new ArgumentNullException(nameof(cuit));
            if (cuit.Length != 13) throw new ArgumentException(nameof(cuit));
            bool rv = false;
            int verificador;
            int resultado = 0;
            string cuit_nro = cuit.Replace("-", string.Empty);
            string codes = "6789456789";
            if (long.TryParse(cuit_nro, out _))
            {
                verificador = int.Parse(cuit_nro[cuit_nro.Length - 1].ToString());
                int x = 0;
                while (x < 10)
                {
                    int digitoValidador = int.Parse(codes.Substring((x), 1));
                    int digito = int.Parse(cuit_nro.Substring((x), 1));
                    int digitoValidacion = digitoValidador * digito;
                    resultado += digitoValidacion;
                    x++;
                }
                resultado %= 11;
                rv = (resultado == verificador);
            }
            return rv;
        }

        private bool EsNuevoCuit(string cuit)
        {
            if (Form1.banco.BuscarCliente(cuit) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtCargarRecibo1_Click(object sender, EventArgs e)
        {
                tbRecibo1.Text = CargarArchivo("Cargar Recibo 1");
        }
        
        private void BtCargarRecibo2_Click(object sender, EventArgs e)
        {
            tbRecibo2.Text = CargarArchivo("Cargar Recibo 2");
        }
        
        private void BtCargarRecibo3_Click(object sender, EventArgs e)
        {
            tbRecibo3.Text = CargarArchivo("Cargar Recibo 3");
        }

        private void BtCargarBalance_Click(object sender, EventArgs e)
        {
            tbBalance.Text = CargarArchivo("Cargar Balace", "ZIP files | *.zip");
        }

        private void BtCargarActa_Click(object sender, EventArgs e)
        {
            tbActa.Text = CargarArchivo("Cargar Acta");
        }

        private void BtCrearCliente_Click(object sender, EventArgs e)
        {
            Cuenta asignarCuenta()
            {
                
                string cuentaCliente = null;
                if (rbCajaAhorro.Checked)
                {
                    Form1.banco.AgregarCajaAhorro(numNuevaCajaAhorro);
                    cuentaCliente = numNuevaCajaAhorro;
                }
                else if (rbCuentaCorriente.Checked)
                {
                    bool descubiertoOk = decimal.TryParse(descubiertoNuevaCuentaCorriente, out decimal descubiertoCC);
                    if (descubiertoOk)
                    {
                        Form1.banco.AgregarCuentaCorriente(numNuevaCuentaCorriente, descubiertoCC);
                        cuentaCliente = numNuevaCuentaCorriente;
                    }                   
                }
                else if (rbCuentaExistente.Checked)
                {
                    if (Form1.banco.BuscarCuenta(tbCuentaExistente.Text) == null)
                    {
                        cuentaCliente = tbCuentaExistente.Text.PadLeft(13, '0');
                    }
                }
                if (cuentaCliente != null)
                {
                    return Form1.banco.BuscarCuenta(cuentaCliente);
                }
                else
                { 
                    return null;
                }
            }

            bool cuentaOk = false;
            if (rbCajaAhorro.Checked)
            {
                cuentaOk = true;
            }
            else if (rbCuentaCorriente.Checked)
            {
                cuentaOk = decimal.TryParse(descubiertoNuevaCuentaCorriente, out _);
            }
            else if (rbCuentaExistente.Checked)
            {
                cuentaOk = Form1.banco.BuscarCuenta(tbCuentaExistente.Text) == null;
            }

            if (rbPersona.Checked)
            {
                bool nombreOk = tbNombre.Text != String.Empty && Regex.IsMatch(tbNombre.Text, @"^[a-zA-Z]+$"); 
                bool apellidoOk = tbApellido.Text != String.Empty && Regex.IsMatch(tbApellido.Text, @"^[a-zA-Z]+$");
                bool cuitPersonaOk = tbCuitPersona.Text != String.Empty && ValidarCuit(tbCuitPersona.Text) && EsNuevoCuit(tbCuitPersona.Text);
                bool sueldoOk = decimal.TryParse(tbSueldo.Text, out decimal sueldoNeto);
                bool recibosOk = File.Exists(tbRecibo1.Text) && File.Exists(tbRecibo2.Text) && File.Exists(tbRecibo3.Text);
                if (nombreOk && apellidoOk && cuitPersonaOk && sueldoOk && recibosOk && cuentaOk)
                {
                    File.Copy(tbRecibo1.Text, directorioRecibos + "suc" + nombreSucursal + "_recibo_" + tbCuitPersona.Text + "_1.pdf", true);
                    File.Copy(tbRecibo2.Text, directorioRecibos + "suc" + nombreSucursal + "_recibo_" + tbCuitPersona.Text + "_2.pdf", true);
                    File.Copy(tbRecibo3.Text, directorioRecibos + "suc" + nombreSucursal + "_recibo_" + tbCuitPersona.Text + "_3.pdf", true);

                    Cuenta cuentaAsignada = asignarCuenta();
                    List<Cuenta> cuentasNuevoCliente = new List<Cuenta>{cuentaAsignada};

                    Persona nuevoCliente = new Persona(tbCuitPersona.Text, tbNombre.Text, tbApellido.Text, sueldoNeto, cuentasNuevoCliente);
                    Form1.banco.AgregarCliente(nuevoCliente);
                    MessageBox.Show("Creación de persona "+ nuevoCliente.GetFullName() +" exitosa!", "Creación de PERSONA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error en la creación de la persona. Verifique los campos", "Creación de PERSONA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbEmpresa.Checked)
            {
                bool razonSocialOk = tbRazonSocial.Text != String.Empty && Regex.IsMatch(tbRazonSocial.Text, @"^[a-zA-Z ]+$");
                bool cuitEmpresaOk = tbCuitEmpresa.Text != String.Empty && ValidarCuit(tbCuitEmpresa.Text) && EsNuevoCuit(tbCuitEmpresa.Text);
                bool inscripcionIibbOk = tbIibb.Text != String.Empty && Regex.IsMatch(tbIibb.Text, @"^[0-9]+$");
                bool condicionIva = rbIvaInscripto.Checked;
                bool archivosOk = File.Exists(tbActa.Text) && File.Exists(tbBalance.Text);
                if (razonSocialOk && cuitEmpresaOk && inscripcionIibbOk && archivosOk && cuentaOk)
                {

                    File.Copy(tbBalance.Text, directorioBalances + "suc" + nombreSucursal + "_bal_" + tbCuitEmpresa.Text + ".zip", true);
                    File.Copy(tbActa.Text, directorioActas + "suc" + nombreSucursal + "_acta_" + tbCuitEmpresa.Text + ".pdf", true);
                    
                    Cuenta cuentaAsignada = asignarCuenta();
                    List<Cuenta> cuentasNuevoCliente = new List<Cuenta>{cuentaAsignada};

                    Empresa nuevoCliente = new Empresa(tbCuitEmpresa.Text, tbRazonSocial.Text, condicionIva, tbIibb.Text, cuentasNuevoCliente);
                    Form1.banco.AgregarCliente(nuevoCliente);
                    MessageBox.Show("Creación de empresa "+ nuevoCliente.GetFullName() +" exitosa!", "Creación de EMPRESA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error en la creación de la empresa. Verifique los campos", "Creación de EMPRESA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void RbCajaAhorro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCajaAhorro.Checked)
            {
                numNuevaCajaAhorro = Form1.banco.NumCuentaNueva();
            }
        }

        private void RbCuentaCorriente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCuentaCorriente.Checked)
            {
                tbDescubierto.Enabled = true;
                numNuevaCuentaCorriente = Form1.banco.NumCuentaNueva();
            }
            else
            {
                tbDescubierto.Text = "0";
            }
        }

        private void RbCuentaExistente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCuentaExistente.Checked)
            {
                numCuentaExistente = tbCuentaExistente.Text.PadLeft(13, '0');
            }
        }

        private void TbCuentaExistente_TextChanged(object sender, EventArgs e)
        {
            numCuentaExistente = tbCuentaExistente.Text.PadLeft(13, '0');
        }

        private void TbDescubierto_TextChanged(object sender, EventArgs e)
        {
            descubiertoNuevaCuentaCorriente = tbDescubierto.Text;
        }
    }
}
