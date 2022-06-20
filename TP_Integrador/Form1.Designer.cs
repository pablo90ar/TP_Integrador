namespace WindowsFormsApp1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaBancos
            // 
            this.listaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaBancos.FormattingEnabled = true;
            this.listaBancos.Location = new System.Drawing.Point(63, 7);
            this.listaBancos.Name = "listaBancos";
            this.listaBancos.Size = new System.Drawing.Size(112, 21);
            this.listaBancos.TabIndex = 1;
            // 
            // btnCargarBanco
            // 
            this.btnCargarBanco.Location = new System.Drawing.Point(181, 7);
            this.btnCargarBanco.Name = "btnCargarBanco";
            this.btnCargarBanco.Size = new System.Drawing.Size(82, 21);
            this.btnCargarBanco.TabIndex = 2;
            this.btnCargarBanco.Text = "Abrir Banco";
            this.btnCargarBanco.UseVisualStyleBackColor = true;
            this.btnCargarBanco.Click += new System.EventHandler(this.btnCargarBanco_Click);
            // 
            // listaSucursales
            // 
            this.listaSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaSucursales.Enabled = false;
            this.listaSucursales.FormattingEnabled = true;
            this.listaSucursales.Location = new System.Drawing.Point(63, 34);
            this.listaSucursales.Name = "listaSucursales";
            this.listaSucursales.Size = new System.Drawing.Size(112, 21);
            this.listaSucursales.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Banco";
            // 
            // btnCargarSuc
            // 
            this.btnCargarSuc.Enabled = false;
            this.btnCargarSuc.Location = new System.Drawing.Point(181, 34);
            this.btnCargarSuc.Name = "btnCargarSuc";
            this.btnCargarSuc.Size = new System.Drawing.Size(82, 23);
            this.btnCargarSuc.TabIndex = 5;
            this.btnCargarSuc.Text = "Abrir Sucursal";
            this.btnCargarSuc.UseVisualStyleBackColor = true;
            this.btnCargarSuc.Click += new System.EventHandler(this.btnCargarSucursal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sucursal";
            // 
            // btnSalir
            // 
            this.btnSalir.Enabled = false;
            this.btnSalir.Location = new System.Drawing.Point(713, 7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CUIT";
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(181, 133);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(82, 20);
            this.btnAcceder.TabIndex = 10;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Operar Cliente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label label4;
    }
}

