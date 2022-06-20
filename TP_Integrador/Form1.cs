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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var directorio = @"D:\Drive\UTN\_Programacion 3\Práctica\Proyectos VS\TP_Integrador\bancos\";
            var bancos = Directory.GetDirectories(directorio);
            foreach (var banco in bancos)
            {
                listaBancos.Items.Add(banco.Remove(0,directorio.Length));
            }
            listaBancos.SelectedIndex = 0;
        }

        private void btnCargarBanco_Click(object sender, EventArgs e)
        {
            listaSucursales.Enabled = true;
            btnCargarSuc.Enabled = true;
            listaBancos.Enabled = false;
            btnCargarBanco.Enabled = false; 
            var indexBancoElegido = listaBancos.SelectedIndex;
            var nombreBanco = listaBancos.Items[indexBancoElegido];
            var directorio = @"D:\Drive\UTN\_Programacion 3\Práctica\Proyectos VS\TP_Integrador\bancos\" + nombreBanco + @"\";
            var archivosFull = Directory.GetFiles(directorio);
            var archivos = new List<string>();
            foreach (var arch in archivosFull)
            {
                archivos.Add(arch.Remove(0, directorio.Length));
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

        private void btnCargarSucursal_Click(object sender, EventArgs e)
        {
            listaSucursales.Enabled = false;
            btnCargarSuc.Enabled = false;
            btnSalir.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            listaBancos.Enabled = true;
            btnCargarBanco.Enabled = true;
            btnSalir.Enabled = false;
            listaSucursales.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
