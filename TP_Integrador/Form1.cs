﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dirProyecto = AppDomain.CurrentDomain.BaseDirectory;
            string directorio = Path.Combine(dirProyecto, @"..\..\..\bancos\");
            var bancos = Directory.GetDirectories(directorio);
            foreach (var banco in bancos)
            {
                listaBancos.Items.Add(banco.Remove(0,directorio.Length));
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
            string directorio = Path.Combine(dirProyecto, @"..\..\..\bancos\" + nombreBanco + @"\");
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

        private void BtnCargarSucursal_Click(object sender, EventArgs e)
        {
            listaSucursales.Enabled = false;
            btnCargarSuc.Enabled = false;
            ActivarMenu();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            listaBancos.Enabled = true;
            btnCargarBanco.Enabled = true;
            listaSucursales.Items.Clear();
            DesactivarMenu();
        }

        private void BtnMenuSaldo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saldo en tesorería: $400.00", "Tesorería");
        }

        private void BtnMenuOperar_Click(object sender, EventArgs e)
        {
            DesactivarMenu();
            label3.Visible = true;
            tbCuit.Visible = true;
            btnOperar.Visible = true;
            btnVolver.Visible = true;

        }

        public void DesactivarMenu()
        {
            btnSalir.Enabled = false;
            btnMenuSaldo.Enabled = false;
            btnMenuOperar.Enabled = false;
            btnMenuCrear.Enabled = false;
        }

        public void ActivarMenu()
        {
            btnSalir.Enabled = true;
            btnMenuSaldo.Enabled = true;
            btnMenuOperar.Enabled = true;
            btnMenuCrear.Enabled = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            btnOperar.Visible = false;
            btnVolver.Visible=false;
            tbCuit.Visible = false;
            label3.Visible = false;
            ActivarMenu();
        }
        public static string file = @"C:\C#\Clientes.txt";
        private void btnOperar_Click(object sender, EventArgs e)
        {
            TablaDesdeArchivoTXT(file);
            dataGridView1.DataSource = TablaDesdeArchivoTXT(file);
        }
        private DataTable TablaDesdeArchivoTXT(string ubicacion, char separador = '|')
        {
            DataTable resultado;
            ubicacion = file;

            string[] arregloLinea = File.ReadAllLines(ubicacion);
            resultado = DesdeTabla(arregloLinea, separador);
            return resultado;
        }
        private DataTable DesdeTabla(string[] arregloLinea, char separador)
        {
            DataTable dt = new DataTable();

            for (int c = 1; c < arregloLinea.Length; c++)
            {
                if (tbCuit.Text==arregloLinea[c])
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            btnOperar.Visible = false;
            btnVolver.Visible = false;
            tbCuit.Visible = false;
            label3.Visible = false;
            ActivarMenu();
        }
    }
}
