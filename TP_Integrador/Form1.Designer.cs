﻿namespace TP_Integrador_app
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaBancos = new System.Windows.Forms.ComboBox();
            this.btnCargarBanco = new System.Windows.Forms.Button();
            this.listaSucursales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarSuc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMenuSaldo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMenuOperar = new System.Windows.Forms.Button();
            this.btnMenuCrear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaBancos
            // 
            this.listaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaBancos.FormattingEnabled = true;
            this.listaBancos.Location = new System.Drawing.Point(12, 25);
            this.listaBancos.Name = "listaBancos";
            this.listaBancos.Size = new System.Drawing.Size(115, 21);
            this.listaBancos.TabIndex = 1;
            // 
            // btnCargarBanco
            // 
            this.btnCargarBanco.Location = new System.Drawing.Point(12, 52);
            this.btnCargarBanco.Name = "btnCargarBanco";
            this.btnCargarBanco.Size = new System.Drawing.Size(115, 24);
            this.btnCargarBanco.TabIndex = 2;
            this.btnCargarBanco.Text = "Abrir Banco";
            this.btnCargarBanco.UseVisualStyleBackColor = true;
            this.btnCargarBanco.Click += new System.EventHandler(this.BtnCargarBanco_Click);
            // 
            // listaSucursales
            // 
            this.listaSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaSucursales.Enabled = false;
            this.listaSucursales.FormattingEnabled = true;
            this.listaSucursales.Location = new System.Drawing.Point(12, 110);
            this.listaSucursales.Name = "listaSucursales";
            this.listaSucursales.Size = new System.Drawing.Size(115, 21);
            this.listaSucursales.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Banco";
            // 
            // btnCargarSuc
            // 
            this.btnCargarSuc.Enabled = false;
            this.btnCargarSuc.Location = new System.Drawing.Point(12, 137);
            this.btnCargarSuc.Name = "btnCargarSuc";
            this.btnCargarSuc.Size = new System.Drawing.Size(115, 26);
            this.btnCargarSuc.TabIndex = 5;
            this.btnCargarSuc.Text = "Abrir Sucursal";
            this.btnCargarSuc.UseVisualStyleBackColor = true;
            this.btnCargarSuc.Click += new System.EventHandler(this.BtnCargarSucursal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sucursal";
            // 
            // btnSalir
            // 
            this.btnSalir.Enabled = false;
            this.btnSalir.Location = new System.Drawing.Point(12, 562);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnMenuSaldo
            // 
            this.btnMenuSaldo.Enabled = false;
            this.btnMenuSaldo.Location = new System.Drawing.Point(12, 206);
            this.btnMenuSaldo.Name = "btnMenuSaldo";
            this.btnMenuSaldo.Size = new System.Drawing.Size(115, 41);
            this.btnMenuSaldo.TabIndex = 10;
            this.btnMenuSaldo.Text = "Saldo Tesorería";
            this.btnMenuSaldo.UseVisualStyleBackColor = true;
            this.btnMenuSaldo.Click += new System.EventHandler(this.BtnMenuSaldo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Menú Principal";
            // 
            // btnMenuOperar
            // 
            this.btnMenuOperar.Enabled = false;
            this.btnMenuOperar.Location = new System.Drawing.Point(12, 253);
            this.btnMenuOperar.Name = "btnMenuOperar";
            this.btnMenuOperar.Size = new System.Drawing.Size(115, 41);
            this.btnMenuOperar.TabIndex = 12;
            this.btnMenuOperar.Text = "Operar Cliente";
            this.btnMenuOperar.UseVisualStyleBackColor = true;
            this.btnMenuOperar.Click += new System.EventHandler(this.BtnMenuOperar_Click);
            // 
            // btnMenuCrear
            // 
            this.btnMenuCrear.Enabled = false;
            this.btnMenuCrear.Location = new System.Drawing.Point(12, 300);
            this.btnMenuCrear.Name = "btnMenuCrear";
            this.btnMenuCrear.Size = new System.Drawing.Size(115, 41);
            this.btnMenuCrear.TabIndex = 13;
            this.btnMenuCrear.Text = "Crear Cliente";
            this.btnMenuCrear.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 371);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "CUIT";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(12, 397);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(115, 23);
            this.btnOperar.TabIndex = 16;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 597);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMenuCrear);
            this.Controls.Add(this.btnMenuOperar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMenuSaldo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCargarSuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaSucursales);
            this.Controls.Add(this.btnCargarBanco);
            this.Controls.Add(this.listaBancos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listaBancos;
        private System.Windows.Forms.Button btnCargarBanco;
        private System.Windows.Forms.ComboBox listaSucursales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarSuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMenuSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMenuOperar;
        private System.Windows.Forms.Button btnMenuCrear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOperar;
    }
}

