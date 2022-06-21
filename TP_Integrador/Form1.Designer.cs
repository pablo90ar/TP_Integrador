namespace TP_Integrador_app
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
            this.tbCuitBuscado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOperarCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVolverAlBanco = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxNombreCliente = new System.Windows.Forms.TextBox();
            this.listaCuentasCliente = new System.Windows.Forms.ComboBox();
            this.btnOperarCuenta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.montoCuenta = new System.Windows.Forms.TextBox();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSimularPF = new System.Windows.Forms.Button();
            this.montoDisponible = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAltaPF = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMontoOperacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConfirmarOperacion = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grupoCuenta = new System.Windows.Forms.GroupBox();
            this.grupoMovimientos = new System.Windows.Forms.GroupBox();
            this.grupoPlazoFijo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grupoCuenta.SuspendLayout();
            this.grupoMovimientos.SuspendLayout();
            this.grupoPlazoFijo.SuspendLayout();
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
            this.btnSalir.Location = new System.Drawing.Point(12, 658);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir del Banco";
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
            // tbCuitBuscado
            // 
            this.tbCuitBuscado.Location = new System.Drawing.Point(12, 384);
            this.tbCuitBuscado.Name = "tbCuitBuscado";
            this.tbCuitBuscado.Size = new System.Drawing.Size(115, 20);
            this.tbCuitBuscado.TabIndex = 14;
            this.tbCuitBuscado.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "CUIT";
            this.label3.Visible = false;
            // 
            // btnOperarCliente
            // 
            this.btnOperarCliente.Location = new System.Drawing.Point(12, 410);
            this.btnOperarCliente.Name = "btnOperarCliente";
            this.btnOperarCliente.Size = new System.Drawing.Size(115, 23);
            this.btnOperarCliente.TabIndex = 16;
            this.btnOperarCliente.Text = "Operar";
            this.btnOperarCliente.UseVisualStyleBackColor = true;
            this.btnOperarCliente.Visible = false;
            this.btnOperarCliente.Click += new System.EventHandler(this.BtnOperarCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1043, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(276, 395);
            this.dataGridView1.TabIndex = 17;
            // 
            // btnVolverAlBanco
            // 
            this.btnVolverAlBanco.Location = new System.Drawing.Point(12, 439);
            this.btnVolverAlBanco.Name = "btnVolverAlBanco";
            this.btnVolverAlBanco.Size = new System.Drawing.Size(115, 23);
            this.btnVolverAlBanco.TabIndex = 17;
            this.btnVolverAlBanco.Text = "Volver";
            this.btnVolverAlBanco.UseVisualStyleBackColor = true;
            this.btnVolverAlBanco.Visible = false;
            this.btnVolverAlBanco.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nombre";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cuenta";
            this.label6.Visible = false;
            // 
            // tbxNombreCliente
            // 
            this.tbxNombreCliente.Location = new System.Drawing.Point(82, 30);
            this.tbxNombreCliente.Name = "tbxNombreCliente";
            this.tbxNombreCliente.ReadOnly = true;
            this.tbxNombreCliente.Size = new System.Drawing.Size(192, 20);
            this.tbxNombreCliente.TabIndex = 20;
            this.tbxNombreCliente.Visible = false;
            // 
            // listaCuentasCliente
            // 
            this.listaCuentasCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaCuentasCliente.Enabled = false;
            this.listaCuentasCliente.FormattingEnabled = true;
            this.listaCuentasCliente.Location = new System.Drawing.Point(360, 29);
            this.listaCuentasCliente.Name = "listaCuentasCliente";
            this.listaCuentasCliente.Size = new System.Drawing.Size(192, 21);
            this.listaCuentasCliente.TabIndex = 22;
            this.listaCuentasCliente.Visible = false;
            this.listaCuentasCliente.SelectedIndexChanged += new System.EventHandler(this.ListaCuentasCliente_SelectedIndexChanged);
            // 
            // btnOperarCuenta
            // 
            this.btnOperarCuenta.Location = new System.Drawing.Point(597, 29);
            this.btnOperarCuenta.Name = "btnOperarCuenta";
            this.btnOperarCuenta.Size = new System.Drawing.Size(146, 117);
            this.btnOperarCuenta.TabIndex = 24;
            this.btnOperarCuenta.Text = "Operar Cuenta";
            this.btnOperarCuenta.UseVisualStyleBackColor = true;
            this.btnOperarCuenta.Visible = false;
            this.btnOperarCuenta.Click += new System.EventHandler(this.BtnOperarCuenta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Total";
            this.label7.Visible = false;
            // 
            // montoCuenta
            // 
            this.montoCuenta.Location = new System.Drawing.Point(360, 77);
            this.montoCuenta.Name = "montoCuenta";
            this.montoCuenta.ReadOnly = true;
            this.montoCuenta.Size = new System.Drawing.Size(192, 20);
            this.montoCuenta.TabIndex = 26;
            this.montoCuenta.Visible = false;
            // 
            // btnExtraer
            // 
            this.btnExtraer.Enabled = false;
            this.btnExtraer.Location = new System.Drawing.Point(22, 28);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(124, 36);
            this.btnExtraer.TabIndex = 27;
            this.btnExtraer.Text = "Extraer Dinero";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Enabled = false;
            this.btnDepositar.Location = new System.Drawing.Point(150, 28);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(124, 36);
            this.btnDepositar.TabIndex = 28;
            this.btnDepositar.Text = "Depositar Dinero";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSimularPF
            // 
            this.btnSimularPF.Enabled = false;
            this.btnSimularPF.Location = new System.Drawing.Point(22, 26);
            this.btnSimularPF.Name = "btnSimularPF";
            this.btnSimularPF.Size = new System.Drawing.Size(252, 36);
            this.btnSimularPF.TabIndex = 29;
            this.btnSimularPF.Text = "Simular Plazo Fijo";
            this.btnSimularPF.UseVisualStyleBackColor = true;
            this.btnSimularPF.Click += new System.EventHandler(this.btnSimularPF_Click);
            // 
            // montoDisponible
            // 
            this.montoDisponible.Location = new System.Drawing.Point(82, 77);
            this.montoDisponible.Name = "montoDisponible";
            this.montoDisponible.ReadOnly = true;
            this.montoDisponible.Size = new System.Drawing.Size(192, 20);
            this.montoDisponible.TabIndex = 31;
            this.montoDisponible.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Disponible";
            // 
            // btnAltaPF
            // 
            this.btnAltaPF.Enabled = false;
            this.btnAltaPF.Location = new System.Drawing.Point(23, 68);
            this.btnAltaPF.Name = "btnAltaPF";
            this.btnAltaPF.Size = new System.Drawing.Size(252, 36);
            this.btnAltaPF.TabIndex = 32;
            this.btnAltaPF.Text = "Realizar Plazo Fijo";
            this.btnAltaPF.UseVisualStyleBackColor = true;
            this.btnAltaPF.Click += new System.EventHandler(this.btnAltaPF_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(457, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(95, 20);
            this.textBox2.TabIndex = 34;
            this.textBox2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Días restantes Plazo Fijo";
            this.label9.Visible = false;
            // 
            // tbMontoOperacion
            // 
            this.tbMontoOperacion.Location = new System.Drawing.Point(458, 37);
            this.tbMontoOperacion.Name = "tbMontoOperacion";
            this.tbMontoOperacion.Size = new System.Drawing.Size(95, 20);
            this.tbMontoOperacion.TabIndex = 36;
            this.tbMontoOperacion.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Monto a";
            this.label10.Visible = false;
            // 
            // btnConfirmarOperacion
            // 
            this.btnConfirmarOperacion.Enabled = false;
            this.btnConfirmarOperacion.Location = new System.Drawing.Point(597, 28);
            this.btnConfirmarOperacion.Name = "btnConfirmarOperacion";
            this.btnConfirmarOperacion.Size = new System.Drawing.Size(146, 36);
            this.btnConfirmarOperacion.TabIndex = 37;
            this.btnConfirmarOperacion.Text = "Confirmar Operación";
            this.btnConfirmarOperacion.UseVisualStyleBackColor = true;
            this.btnConfirmarOperacion.Visible = false;
            this.btnConfirmarOperacion.Click += new System.EventHandler(this.btnConfirmarOperacion_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(457, 33);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(95, 20);
            this.textBox4.TabIndex = 39;
            this.textBox4.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(314, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Monto a invertir en Plazo Fijo";
            this.label11.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 36);
            this.button2.TabIndex = 40;
            this.button2.Text = "Iniciar Simulación";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(597, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 36);
            this.button3.TabIndex = 41;
            this.button3.Text = "Iniciar Plazo Fijo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(457, 77);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(95, 20);
            this.textBox5.TabIndex = 43;
            this.textBox5.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(314, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Duración Plazo Fijo (meses)";
            this.label12.Visible = false;
            // 
            // grupoCuenta
            // 
            this.grupoCuenta.Controls.Add(this.label9);
            this.grupoCuenta.Controls.Add(this.btnOperarCuenta);
            this.grupoCuenta.Controls.Add(this.label5);
            this.grupoCuenta.Controls.Add(this.label6);
            this.grupoCuenta.Controls.Add(this.tbxNombreCliente);
            this.grupoCuenta.Controls.Add(this.listaCuentasCliente);
            this.grupoCuenta.Controls.Add(this.label7);
            this.grupoCuenta.Controls.Add(this.montoCuenta);
            this.grupoCuenta.Controls.Add(this.label8);
            this.grupoCuenta.Controls.Add(this.montoDisponible);
            this.grupoCuenta.Controls.Add(this.textBox2);
            this.grupoCuenta.Location = new System.Drawing.Point(159, 25);
            this.grupoCuenta.Name = "grupoCuenta";
            this.grupoCuenta.Size = new System.Drawing.Size(763, 174);
            this.grupoCuenta.TabIndex = 45;
            this.grupoCuenta.TabStop = false;
            this.grupoCuenta.Text = "Cuenta";
            this.grupoCuenta.Visible = false;
            // 
            // grupoMovimientos
            // 
            this.grupoMovimientos.Controls.Add(this.btnExtraer);
            this.grupoMovimientos.Controls.Add(this.btnDepositar);
            this.grupoMovimientos.Controls.Add(this.label10);
            this.grupoMovimientos.Controls.Add(this.tbMontoOperacion);
            this.grupoMovimientos.Controls.Add(this.btnConfirmarOperacion);
            this.grupoMovimientos.Location = new System.Drawing.Point(159, 216);
            this.grupoMovimientos.Name = "grupoMovimientos";
            this.grupoMovimientos.Size = new System.Drawing.Size(763, 93);
            this.grupoMovimientos.TabIndex = 46;
            this.grupoMovimientos.TabStop = false;
            this.grupoMovimientos.Text = "Movimientos";
            this.grupoMovimientos.Visible = false;
            // 
            // grupoPlazoFijo
            // 
            this.grupoPlazoFijo.Controls.Add(this.btnSimularPF);
            this.grupoPlazoFijo.Controls.Add(this.btnAltaPF);
            this.grupoPlazoFijo.Controls.Add(this.label11);
            this.grupoPlazoFijo.Controls.Add(this.textBox5);
            this.grupoPlazoFijo.Controls.Add(this.textBox4);
            this.grupoPlazoFijo.Controls.Add(this.label12);
            this.grupoPlazoFijo.Controls.Add(this.button2);
            this.grupoPlazoFijo.Controls.Add(this.button3);
            this.grupoPlazoFijo.Location = new System.Drawing.Point(159, 330);
            this.grupoPlazoFijo.Name = "grupoPlazoFijo";
            this.grupoPlazoFijo.Size = new System.Drawing.Size(763, 132);
            this.grupoPlazoFijo.TabIndex = 47;
            this.grupoPlazoFijo.TabStop = false;
            this.grupoPlazoFijo.Text = "Plazo Fijo";
            this.grupoPlazoFijo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 693);
            this.Controls.Add(this.grupoPlazoFijo);
            this.Controls.Add(this.grupoMovimientos);
            this.Controls.Add(this.grupoCuenta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVolverAlBanco);
            this.Controls.Add(this.btnOperarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCuitBuscado);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grupoCuenta.ResumeLayout(false);
            this.grupoCuenta.PerformLayout();
            this.grupoMovimientos.ResumeLayout(false);
            this.grupoMovimientos.PerformLayout();
            this.grupoPlazoFijo.ResumeLayout(false);
            this.grupoPlazoFijo.PerformLayout();
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
        private System.Windows.Forms.TextBox tbCuitBuscado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOperarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVolverAlBanco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxNombreCliente;
        private System.Windows.Forms.ComboBox listaCuentasCliente;
        private System.Windows.Forms.Button btnOperarCuenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox montoCuenta;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSimularPF;
        private System.Windows.Forms.TextBox montoDisponible;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAltaPF;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMontoOperacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConfirmarOperacion;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grupoCuenta;
        private System.Windows.Forms.GroupBox grupoMovimientos;
        private System.Windows.Forms.GroupBox grupoPlazoFijo;
    }
}

