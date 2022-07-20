namespace TP_Integrador_app
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCrearCliente = new System.Windows.Forms.Button();
            this.labelCuitPersona = new System.Windows.Forms.Label();
            this.tbCuitPersona = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.rbPersona = new System.Windows.Forms.RadioButton();
            this.grupoPersona = new System.Windows.Forms.GroupBox();
            this.btCargarRecibo3 = new System.Windows.Forms.Button();
            this.btCargarRecibo2 = new System.Windows.Forms.Button();
            this.btCargarRecibo1 = new System.Windows.Forms.Button();
            this.tbRecibo3 = new System.Windows.Forms.TextBox();
            this.tbRecibo2 = new System.Windows.Forms.TextBox();
            this.tbRecibo1 = new System.Windows.Forms.TextBox();
            this.labelRecibo3 = new System.Windows.Forms.Label();
            this.labelRecibo2 = new System.Windows.Forms.Label();
            this.labelRecibo1 = new System.Windows.Forms.Label();
            this.labelSueldo = new System.Windows.Forms.Label();
            this.tbSueldo = new System.Windows.Forms.TextBox();
            this.grupoEmpresa = new System.Windows.Forms.GroupBox();
            this.labelIibb = new System.Windows.Forms.Label();
            this.tbIibb = new System.Windows.Forms.TextBox();
            this.btCargarActa = new System.Windows.Forms.Button();
            this.tbActa = new System.Windows.Forms.TextBox();
            this.labelActa = new System.Windows.Forms.Label();
            this.btCargarBalance = new System.Windows.Forms.Button();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.labelCuitEmpresa = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.tbCuitEmpresa = new System.Windows.Forms.TextBox();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.tbRazonSocial = new System.Windows.Forms.TextBox();
            this.grupoCuenta = new System.Windows.Forms.GroupBox();
            this.rbCuentaExistente = new System.Windows.Forms.RadioButton();
            this.tbCuentaExistente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbDescubierto = new System.Windows.Forms.TextBox();
            this.rbCuentaCorriente = new System.Windows.Forms.RadioButton();
            this.rbCajaAhorro = new System.Windows.Forms.RadioButton();
            this.rbIvaInscripto = new System.Windows.Forms.RadioButton();
            this.rbIvaExento = new System.Windows.Forms.RadioButton();
            this.grupoPersona.SuspendLayout();
            this.grupoEmpresa.SuspendLayout();
            this.grupoCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCrearCliente
            // 
            this.btCrearCliente.Location = new System.Drawing.Point(810, 498);
            this.btCrearCliente.Name = "btCrearCliente";
            this.btCrearCliente.Size = new System.Drawing.Size(149, 41);
            this.btCrearCliente.TabIndex = 2;
            this.btCrearCliente.Text = "Crear Cliente";
            this.btCrearCliente.UseVisualStyleBackColor = true;
            this.btCrearCliente.Click += new System.EventHandler(this.BtCrearCliente_Click);
            // 
            // labelCuitPersona
            // 
            this.labelCuitPersona.AutoSize = true;
            this.labelCuitPersona.Location = new System.Drawing.Point(18, 110);
            this.labelCuitPersona.Name = "labelCuitPersona";
            this.labelCuitPersona.Size = new System.Drawing.Size(32, 13);
            this.labelCuitPersona.TabIndex = 17;
            this.labelCuitPersona.Text = "CUIT";
            // 
            // tbCuitPersona
            // 
            this.tbCuitPersona.Location = new System.Drawing.Point(72, 107);
            this.tbCuitPersona.Name = "tbCuitPersona";
            this.tbCuitPersona.Size = new System.Drawing.Size(141, 20);
            this.tbCuitPersona.TabIndex = 16;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(18, 66);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 15;
            this.labelApellido.Text = "Apellido";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(72, 63);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(141, 20);
            this.tbApellido.TabIndex = 14;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(18, 24);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 13;
            this.labelNombre.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(72, 21);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(141, 20);
            this.tbNombre.TabIndex = 12;
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.Location = new System.Drawing.Point(470, 12);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(66, 17);
            this.rbEmpresa.TabIndex = 11;
            this.rbEmpresa.Text = "Empresa";
            this.rbEmpresa.UseVisualStyleBackColor = true;
            // 
            // rbPersona
            // 
            this.rbPersona.AutoSize = true;
            this.rbPersona.Checked = true;
            this.rbPersona.Location = new System.Drawing.Point(12, 12);
            this.rbPersona.Name = "rbPersona";
            this.rbPersona.Size = new System.Drawing.Size(64, 17);
            this.rbPersona.TabIndex = 10;
            this.rbPersona.TabStop = true;
            this.rbPersona.Text = "Persona";
            this.rbPersona.UseVisualStyleBackColor = true;
            // 
            // grupoPersona
            // 
            this.grupoPersona.Controls.Add(this.btCargarRecibo3);
            this.grupoPersona.Controls.Add(this.btCargarRecibo2);
            this.grupoPersona.Controls.Add(this.btCargarRecibo1);
            this.grupoPersona.Controls.Add(this.tbRecibo3);
            this.grupoPersona.Controls.Add(this.tbRecibo2);
            this.grupoPersona.Controls.Add(this.tbRecibo1);
            this.grupoPersona.Controls.Add(this.labelRecibo3);
            this.grupoPersona.Controls.Add(this.labelRecibo2);
            this.grupoPersona.Controls.Add(this.labelRecibo1);
            this.grupoPersona.Controls.Add(this.labelSueldo);
            this.grupoPersona.Controls.Add(this.tbSueldo);
            this.grupoPersona.Controls.Add(this.labelNombre);
            this.grupoPersona.Controls.Add(this.tbNombre);
            this.grupoPersona.Controls.Add(this.labelCuitPersona);
            this.grupoPersona.Controls.Add(this.tbApellido);
            this.grupoPersona.Controls.Add(this.tbCuitPersona);
            this.grupoPersona.Controls.Add(this.labelApellido);
            this.grupoPersona.Location = new System.Drawing.Point(12, 35);
            this.grupoPersona.Name = "grupoPersona";
            this.grupoPersona.Size = new System.Drawing.Size(452, 326);
            this.grupoPersona.TabIndex = 18;
            this.grupoPersona.TabStop = false;
            // 
            // btCargarRecibo3
            // 
            this.btCargarRecibo3.Location = new System.Drawing.Point(338, 280);
            this.btCargarRecibo3.Name = "btCargarRecibo3";
            this.btCargarRecibo3.Size = new System.Drawing.Size(91, 24);
            this.btCargarRecibo3.TabIndex = 30;
            this.btCargarRecibo3.Text = "Explorar...";
            this.btCargarRecibo3.UseVisualStyleBackColor = true;
            this.btCargarRecibo3.Click += new System.EventHandler(this.BtCargarRecibo3_Click);
            // 
            // btCargarRecibo2
            // 
            this.btCargarRecibo2.Location = new System.Drawing.Point(338, 249);
            this.btCargarRecibo2.Name = "btCargarRecibo2";
            this.btCargarRecibo2.Size = new System.Drawing.Size(91, 24);
            this.btCargarRecibo2.TabIndex = 29;
            this.btCargarRecibo2.Text = "Explorar...";
            this.btCargarRecibo2.UseVisualStyleBackColor = true;
            this.btCargarRecibo2.Click += new System.EventHandler(this.BtCargarRecibo2_Click);
            // 
            // btCargarRecibo1
            // 
            this.btCargarRecibo1.Location = new System.Drawing.Point(338, 218);
            this.btCargarRecibo1.Name = "btCargarRecibo1";
            this.btCargarRecibo1.Size = new System.Drawing.Size(91, 24);
            this.btCargarRecibo1.TabIndex = 28;
            this.btCargarRecibo1.Text = "Explorar...";
            this.btCargarRecibo1.UseVisualStyleBackColor = true;
            this.btCargarRecibo1.Click += new System.EventHandler(this.BtCargarRecibo1_Click);
            // 
            // tbRecibo3
            // 
            this.tbRecibo3.Location = new System.Drawing.Point(72, 283);
            this.tbRecibo3.Name = "tbRecibo3";
            this.tbRecibo3.ReadOnly = true;
            this.tbRecibo3.Size = new System.Drawing.Size(260, 20);
            this.tbRecibo3.TabIndex = 27;
            // 
            // tbRecibo2
            // 
            this.tbRecibo2.Location = new System.Drawing.Point(72, 252);
            this.tbRecibo2.Name = "tbRecibo2";
            this.tbRecibo2.ReadOnly = true;
            this.tbRecibo2.Size = new System.Drawing.Size(260, 20);
            this.tbRecibo2.TabIndex = 26;
            // 
            // tbRecibo1
            // 
            this.tbRecibo1.Location = new System.Drawing.Point(72, 221);
            this.tbRecibo1.Name = "tbRecibo1";
            this.tbRecibo1.ReadOnly = true;
            this.tbRecibo1.Size = new System.Drawing.Size(260, 20);
            this.tbRecibo1.TabIndex = 25;
            // 
            // labelRecibo3
            // 
            this.labelRecibo3.AutoSize = true;
            this.labelRecibo3.Location = new System.Drawing.Point(18, 286);
            this.labelRecibo3.Name = "labelRecibo3";
            this.labelRecibo3.Size = new System.Drawing.Size(50, 13);
            this.labelRecibo3.TabIndex = 24;
            this.labelRecibo3.Text = "Recibo 3";
            // 
            // labelRecibo2
            // 
            this.labelRecibo2.AutoSize = true;
            this.labelRecibo2.Location = new System.Drawing.Point(18, 255);
            this.labelRecibo2.Name = "labelRecibo2";
            this.labelRecibo2.Size = new System.Drawing.Size(50, 13);
            this.labelRecibo2.TabIndex = 23;
            this.labelRecibo2.Text = "Recibo 2";
            // 
            // labelRecibo1
            // 
            this.labelRecibo1.AutoSize = true;
            this.labelRecibo1.Location = new System.Drawing.Point(18, 224);
            this.labelRecibo1.Name = "labelRecibo1";
            this.labelRecibo1.Size = new System.Drawing.Size(50, 13);
            this.labelRecibo1.TabIndex = 22;
            this.labelRecibo1.Text = "Recibo 1";
            // 
            // labelSueldo
            // 
            this.labelSueldo.AutoSize = true;
            this.labelSueldo.Location = new System.Drawing.Point(18, 155);
            this.labelSueldo.Name = "labelSueldo";
            this.labelSueldo.Size = new System.Drawing.Size(40, 13);
            this.labelSueldo.TabIndex = 19;
            this.labelSueldo.Text = "Sueldo";
            // 
            // tbSueldo
            // 
            this.tbSueldo.Location = new System.Drawing.Point(72, 152);
            this.tbSueldo.Name = "tbSueldo";
            this.tbSueldo.Size = new System.Drawing.Size(141, 20);
            this.tbSueldo.TabIndex = 18;
            this.tbSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grupoEmpresa
            // 
            this.grupoEmpresa.Controls.Add(this.rbIvaExento);
            this.grupoEmpresa.Controls.Add(this.rbIvaInscripto);
            this.grupoEmpresa.Controls.Add(this.labelIibb);
            this.grupoEmpresa.Controls.Add(this.tbIibb);
            this.grupoEmpresa.Controls.Add(this.btCargarActa);
            this.grupoEmpresa.Controls.Add(this.tbActa);
            this.grupoEmpresa.Controls.Add(this.labelActa);
            this.grupoEmpresa.Controls.Add(this.btCargarBalance);
            this.grupoEmpresa.Controls.Add(this.tbBalance);
            this.grupoEmpresa.Controls.Add(this.labelCuitEmpresa);
            this.grupoEmpresa.Controls.Add(this.labelBalance);
            this.grupoEmpresa.Controls.Add(this.tbCuitEmpresa);
            this.grupoEmpresa.Controls.Add(this.labelRazonSocial);
            this.grupoEmpresa.Controls.Add(this.tbRazonSocial);
            this.grupoEmpresa.Location = new System.Drawing.Point(470, 35);
            this.grupoEmpresa.Name = "grupoEmpresa";
            this.grupoEmpresa.Size = new System.Drawing.Size(485, 326);
            this.grupoEmpresa.TabIndex = 19;
            this.grupoEmpresa.TabStop = false;
            // 
            // labelIibb
            // 
            this.labelIibb.AutoSize = true;
            this.labelIibb.Location = new System.Drawing.Point(20, 110);
            this.labelIibb.Name = "labelIibb";
            this.labelIibb.Size = new System.Drawing.Size(53, 13);
            this.labelIibb.TabIndex = 38;
            this.labelIibb.Text = "Insc. IIBB";
            // 
            // tbIibb
            // 
            this.tbIibb.Location = new System.Drawing.Point(90, 107);
            this.tbIibb.Name = "tbIibb";
            this.tbIibb.Size = new System.Drawing.Size(141, 20);
            this.tbIibb.TabIndex = 37;
            // 
            // btCargarActa
            // 
            this.btCargarActa.Location = new System.Drawing.Point(365, 247);
            this.btCargarActa.Name = "btCargarActa";
            this.btCargarActa.Size = new System.Drawing.Size(91, 24);
            this.btCargarActa.TabIndex = 36;
            this.btCargarActa.Text = "Explorar...";
            this.btCargarActa.UseVisualStyleBackColor = true;
            this.btCargarActa.Click += new System.EventHandler(this.BtCargarActa_Click);
            // 
            // tbActa
            // 
            this.tbActa.Location = new System.Drawing.Point(90, 250);
            this.tbActa.Name = "tbActa";
            this.tbActa.ReadOnly = true;
            this.tbActa.Size = new System.Drawing.Size(269, 20);
            this.tbActa.TabIndex = 35;
            // 
            // labelActa
            // 
            this.labelActa.AutoSize = true;
            this.labelActa.Location = new System.Drawing.Point(20, 253);
            this.labelActa.Name = "labelActa";
            this.labelActa.Size = new System.Drawing.Size(64, 13);
            this.labelActa.TabIndex = 34;
            this.labelActa.Text = "Acta Socios";
            // 
            // btCargarBalance
            // 
            this.btCargarBalance.Location = new System.Drawing.Point(365, 217);
            this.btCargarBalance.Name = "btCargarBalance";
            this.btCargarBalance.Size = new System.Drawing.Size(91, 24);
            this.btCargarBalance.TabIndex = 33;
            this.btCargarBalance.Text = "Explorar...";
            this.btCargarBalance.UseVisualStyleBackColor = true;
            this.btCargarBalance.Click += new System.EventHandler(this.BtCargarBalance_Click);
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(90, 220);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.ReadOnly = true;
            this.tbBalance.Size = new System.Drawing.Size(269, 20);
            this.tbBalance.TabIndex = 32;
            // 
            // labelCuitEmpresa
            // 
            this.labelCuitEmpresa.AutoSize = true;
            this.labelCuitEmpresa.Location = new System.Drawing.Point(20, 66);
            this.labelCuitEmpresa.Name = "labelCuitEmpresa";
            this.labelCuitEmpresa.Size = new System.Drawing.Size(32, 13);
            this.labelCuitEmpresa.TabIndex = 21;
            this.labelCuitEmpresa.Text = "CUIT";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(20, 223);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(46, 13);
            this.labelBalance.TabIndex = 31;
            this.labelBalance.Text = "Balance";
            // 
            // tbCuitEmpresa
            // 
            this.tbCuitEmpresa.Location = new System.Drawing.Point(90, 63);
            this.tbCuitEmpresa.Name = "tbCuitEmpresa";
            this.tbCuitEmpresa.Size = new System.Drawing.Size(141, 20);
            this.tbCuitEmpresa.TabIndex = 20;
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Location = new System.Drawing.Point(20, 24);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(50, 13);
            this.labelRazonSocial.TabIndex = 19;
            this.labelRazonSocial.Text = "R. Social";
            // 
            // tbRazonSocial
            // 
            this.tbRazonSocial.Location = new System.Drawing.Point(90, 21);
            this.tbRazonSocial.Name = "tbRazonSocial";
            this.tbRazonSocial.Size = new System.Drawing.Size(141, 20);
            this.tbRazonSocial.TabIndex = 18;
            // 
            // grupoCuenta
            // 
            this.grupoCuenta.Controls.Add(this.rbCuentaExistente);
            this.grupoCuenta.Controls.Add(this.tbCuentaExistente);
            this.grupoCuenta.Controls.Add(this.label13);
            this.grupoCuenta.Controls.Add(this.tbDescubierto);
            this.grupoCuenta.Controls.Add(this.rbCuentaCorriente);
            this.grupoCuenta.Controls.Add(this.rbCajaAhorro);
            this.grupoCuenta.Location = new System.Drawing.Point(282, 367);
            this.grupoCuenta.Name = "grupoCuenta";
            this.grupoCuenta.Size = new System.Drawing.Size(366, 172);
            this.grupoCuenta.TabIndex = 43;
            this.grupoCuenta.TabStop = false;
            this.grupoCuenta.Text = "Cuenta inicial del nuevo cliente";
            // 
            // rbCuentaExistente
            // 
            this.rbCuentaExistente.AutoSize = true;
            this.rbCuentaExistente.Checked = true;
            this.rbCuentaExistente.Location = new System.Drawing.Point(56, 42);
            this.rbCuentaExistente.Name = "rbCuentaExistente";
            this.rbCuentaExistente.Size = new System.Drawing.Size(120, 17);
            this.rbCuentaExistente.TabIndex = 48;
            this.rbCuentaExistente.TabStop = true;
            this.rbCuentaExistente.Text = "Cuenta Existente N°";
            this.rbCuentaExistente.UseVisualStyleBackColor = true;
            this.rbCuentaExistente.CheckedChanged += new System.EventHandler(this.RbCuentaExistente_CheckedChanged);
            // 
            // tbCuentaExistente
            // 
            this.tbCuentaExistente.Location = new System.Drawing.Point(182, 41);
            this.tbCuentaExistente.Name = "tbCuentaExistente";
            this.tbCuentaExistente.Size = new System.Drawing.Size(128, 20);
            this.tbCuentaExistente.TabIndex = 47;
            this.tbCuentaExistente.TextChanged += new System.EventHandler(this.TbCuentaExistente_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Monto descubierto";
            // 
            // tbDescubierto
            // 
            this.tbDescubierto.Enabled = false;
            this.tbDescubierto.Location = new System.Drawing.Point(182, 111);
            this.tbDescubierto.Name = "tbDescubierto";
            this.tbDescubierto.Size = new System.Drawing.Size(128, 20);
            this.tbDescubierto.TabIndex = 45;
            this.tbDescubierto.Text = "0";
            this.tbDescubierto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDescubierto.TextChanged += new System.EventHandler(this.TbDescubierto_TextChanged);
            // 
            // rbCuentaCorriente
            // 
            this.rbCuentaCorriente.AutoSize = true;
            this.rbCuentaCorriente.Location = new System.Drawing.Point(56, 88);
            this.rbCuentaCorriente.Name = "rbCuentaCorriente";
            this.rbCuentaCorriente.Size = new System.Drawing.Size(139, 17);
            this.rbCuentaCorriente.TabIndex = 44;
            this.rbCuentaCorriente.Text = "Nueva Cuenta Corriente";
            this.rbCuentaCorriente.UseVisualStyleBackColor = true;
            this.rbCuentaCorriente.CheckedChanged += new System.EventHandler(this.RbCuentaCorriente_CheckedChanged);
            // 
            // rbCajaAhorro
            // 
            this.rbCajaAhorro.AutoSize = true;
            this.rbCajaAhorro.Location = new System.Drawing.Point(56, 65);
            this.rbCajaAhorro.Name = "rbCajaAhorro";
            this.rbCajaAhorro.Size = new System.Drawing.Size(130, 17);
            this.rbCajaAhorro.TabIndex = 43;
            this.rbCajaAhorro.Text = "Nueva Caja de Ahorro";
            this.rbCajaAhorro.UseVisualStyleBackColor = true;
            this.rbCajaAhorro.CheckedChanged += new System.EventHandler(this.RbCajaAhorro_CheckedChanged);
            // 
            // rbIvaInscripto
            // 
            this.rbIvaInscripto.AutoSize = true;
            this.rbIvaInscripto.Checked = true;
            this.rbIvaInscripto.Location = new System.Drawing.Point(23, 150);
            this.rbIvaInscripto.Name = "rbIvaInscripto";
            this.rbIvaInscripto.Size = new System.Drawing.Size(85, 17);
            this.rbIvaInscripto.TabIndex = 39;
            this.rbIvaInscripto.TabStop = true;
            this.rbIvaInscripto.Text = "IVA Inscripto";
            this.rbIvaInscripto.UseVisualStyleBackColor = true;
            // 
            // rbIvaExento
            // 
            this.rbIvaExento.AutoSize = true;
            this.rbIvaExento.Location = new System.Drawing.Point(23, 173);
            this.rbIvaExento.Name = "rbIvaExento";
            this.rbIvaExento.Size = new System.Drawing.Size(78, 17);
            this.rbIvaExento.TabIndex = 40;
            this.rbIvaExento.Text = "IVA Exento";
            this.rbIvaExento.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 551);
            this.Controls.Add(this.grupoCuenta);
            this.Controls.Add(this.grupoEmpresa);
            this.Controls.Add(this.grupoPersona);
            this.Controls.Add(this.rbEmpresa);
            this.Controls.Add(this.rbPersona);
            this.Controls.Add(this.btCrearCliente);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grupoPersona.ResumeLayout(false);
            this.grupoPersona.PerformLayout();
            this.grupoEmpresa.ResumeLayout(false);
            this.grupoEmpresa.PerformLayout();
            this.grupoCuenta.ResumeLayout(false);
            this.grupoCuenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCrearCliente;
        private System.Windows.Forms.Label labelCuitPersona;
        private System.Windows.Forms.TextBox tbCuitPersona;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.RadioButton rbPersona;
        private System.Windows.Forms.GroupBox grupoPersona;
        private System.Windows.Forms.GroupBox grupoEmpresa;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.TextBox tbRazonSocial;
        private System.Windows.Forms.Label labelCuitEmpresa;
        private System.Windows.Forms.TextBox tbCuitEmpresa;
        private System.Windows.Forms.Label labelSueldo;
        private System.Windows.Forms.TextBox tbSueldo;
        private System.Windows.Forms.Label labelRecibo3;
        private System.Windows.Forms.Label labelRecibo2;
        private System.Windows.Forms.Label labelRecibo1;
        private System.Windows.Forms.Button btCargarRecibo3;
        private System.Windows.Forms.Button btCargarRecibo2;
        private System.Windows.Forms.Button btCargarRecibo1;
        private System.Windows.Forms.TextBox tbRecibo3;
        private System.Windows.Forms.TextBox tbRecibo2;
        private System.Windows.Forms.TextBox tbRecibo1;
        private System.Windows.Forms.Button btCargarBalance;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelIibb;
        private System.Windows.Forms.TextBox tbIibb;
        private System.Windows.Forms.Button btCargarActa;
        private System.Windows.Forms.TextBox tbActa;
        private System.Windows.Forms.Label labelActa;
        private System.Windows.Forms.GroupBox grupoCuenta;
        private System.Windows.Forms.RadioButton rbCuentaExistente;
        private System.Windows.Forms.TextBox tbCuentaExistente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbDescubierto;
        private System.Windows.Forms.RadioButton rbCuentaCorriente;
        private System.Windows.Forms.RadioButton rbCajaAhorro;
        private System.Windows.Forms.RadioButton rbIvaExento;
        private System.Windows.Forms.RadioButton rbIvaInscripto;
    }
}