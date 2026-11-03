namespace PRYservicioTecnico
{
    partial class frmCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDatos = new GroupBox();
            lblDireccion = new Label();
            textBox8 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblMail = new Label();
            lbltelefono = new Label();
            lblnombr = new Label();
            lblEquipo = new GroupBox();
            textBox10 = new TextBox();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            lblFalla = new Label();
            lblNumero = new Label();
            lblTipo = new Label();
            lstTicket = new GroupBox();
            textBox11 = new TextBox();
            textBox9 = new TextBox();
            textBox4 = new TextBox();
            lblFechaestimadadeentrega = new Label();
            textBox7 = new TextBox();
            lblFecahayhora = new Label();
            textBox6 = new TextBox();
            lblPresupuesto = new Label();
            lblDescripcion = new Label();
            lblTicket = new Label();
            lblEntregayPago = new GroupBox();
            btnEnReparacion = new CheckBox();
            Entregado = new CheckBox();
            lstEfctivo = new CheckBox();
            lstTargeta = new CheckBox();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            txtDatos.SuspendLayout();
            lblEquipo.SuspendLayout();
            lstTicket.SuspendLayout();
            lblEntregayPago.SuspendLayout();
            SuspendLayout();
            // 
            // txtDatos
            // 
            txtDatos.Controls.Add(lblDireccion);
            txtDatos.Controls.Add(textBox8);
            txtDatos.Controls.Add(textBox3);
            txtDatos.Controls.Add(textBox2);
            txtDatos.Controls.Add(textBox1);
            txtDatos.Controls.Add(lblMail);
            txtDatos.Controls.Add(lbltelefono);
            txtDatos.Controls.Add(lblnombr);
            txtDatos.Location = new Point(12, 12);
            txtDatos.Name = "txtDatos";
            txtDatos.Size = new Size(341, 166);
            txtDatos.TabIndex = 0;
            txtDatos.TabStop = false;
            txtDatos.Text = "Datos";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(6, 140);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 7;
            lblDireccion.Text = "Direccion";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(132, 132);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(132, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(112, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 23);
            textBox1.TabIndex = 3;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(6, 100);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(30, 15);
            lblMail.TabIndex = 2;
            lblMail.Text = "Mail";
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Location = new Point(6, 66);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(53, 15);
            lbltelefono.TabIndex = 1;
            lbltelefono.Text = "Telefono";
            // 
            // lblnombr
            // 
            lblnombr.AutoSize = true;
            lblnombr.Location = new Point(6, 31);
            lblnombr.Name = "lblnombr";
            lblnombr.Size = new Size(110, 15);
            lblnombr.TabIndex = 0;
            lblnombr.Text = "Apellido  y Nombre";
            // 
            // lblEquipo
            // 
            lblEquipo.Controls.Add(textBox10);
            lblEquipo.Controls.Add(comboBox1);
            lblEquipo.Controls.Add(textBox5);
            lblEquipo.Controls.Add(lblFalla);
            lblEquipo.Controls.Add(lblNumero);
            lblEquipo.Controls.Add(lblTipo);
            lblEquipo.Location = new Point(12, 240);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(320, 168);
            lblEquipo.TabIndex = 2;
            lblEquipo.TabStop = false;
            lblEquipo.Text = "Equipo";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(116, 123);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(174, 23);
            textBox10.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PC", "Notebook" });
            comboBox1.Location = new Point(116, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(116, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(116, 74);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(116, 23);
            textBox5.TabIndex = 4;
            // 
            // lblFalla
            // 
            lblFalla.AutoSize = true;
            lblFalla.Location = new Point(6, 131);
            lblFalla.Name = "lblFalla";
            lblFalla.Size = new Size(36, 15);
            lblFalla.TabIndex = 2;
            lblFalla.Text = "Fallas";
            lblFalla.Click += lblFalla_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(6, 82);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(95, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Numero de Serie";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(6, 46);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(34, 15);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo ";
            lblTipo.Click += label1_Click;
            // 
            // lstTicket
            // 
            lstTicket.Controls.Add(textBox11);
            lstTicket.Controls.Add(textBox9);
            lstTicket.Controls.Add(textBox4);
            lstTicket.Controls.Add(lblFechaestimadadeentrega);
            lstTicket.Controls.Add(textBox7);
            lstTicket.Controls.Add(lblFecahayhora);
            lstTicket.Controls.Add(textBox6);
            lstTicket.Controls.Add(lblPresupuesto);
            lstTicket.Controls.Add(lblDescripcion);
            lstTicket.Controls.Add(lblTicket);
            lstTicket.Location = new Point(415, 12);
            lstTicket.Name = "lstTicket";
            lstTicket.Size = new Size(332, 238);
            lstTicket.TabIndex = 3;
            lstTicket.TabStop = false;
            lstTicket.Text = "Ticket";
            lstTicket.Enter += lstTicket_Enter;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(128, 103);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(175, 23);
            textBox11.TabIndex = 9;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(128, 198);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(188, 156);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(115, 23);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // lblFechaestimadadeentrega
            // 
            lblFechaestimadadeentrega.AutoSize = true;
            lblFechaestimadadeentrega.Location = new Point(21, 164);
            lblFechaestimadadeentrega.Name = "lblFechaestimadadeentrega";
            lblFechaestimadadeentrega.Size = new Size(148, 15);
            lblFechaestimadadeentrega.TabIndex = 6;
            lblFechaestimadadeentrega.Text = "Fecha Estimada de Entrega";
            lblFechaestimadadeentrega.Click += label1_Click_1;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(128, 65);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(148, 23);
            textBox7.TabIndex = 5;
            // 
            // lblFecahayhora
            // 
            lblFecahayhora.AutoSize = true;
            lblFecahayhora.Location = new Point(23, 65);
            lblFecahayhora.Name = "lblFecahayhora";
            lblFecahayhora.Size = new Size(76, 15);
            lblFecahayhora.TabIndex = 4;
            lblFecahayhora.Text = "Fecha y Hora";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(128, 22);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(80, 23);
            textBox6.TabIndex = 3;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // lblPresupuesto
            // 
            lblPresupuesto.AutoSize = true;
            lblPresupuesto.Location = new Point(21, 206);
            lblPresupuesto.Name = "lblPresupuesto";
            lblPresupuesto.Size = new Size(72, 15);
            lblPresupuesto.TabIndex = 2;
            lblPresupuesto.Text = "Presupuesto";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(23, 106);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(70, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Diagnostico";
            // 
            // lblTicket
            // 
            lblTicket.AutoSize = true;
            lblTicket.Location = new Point(23, 31);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(78, 15);
            lblTicket.TabIndex = 0;
            lblTicket.Text = "Nro de Ticket";
            // 
            // lblEntregayPago
            // 
            lblEntregayPago.Controls.Add(btnEnReparacion);
            lblEntregayPago.Controls.Add(Entregado);
            lblEntregayPago.Controls.Add(lstEfctivo);
            lblEntregayPago.Controls.Add(lstTargeta);
            lblEntregayPago.Location = new Point(415, 271);
            lblEntregayPago.Name = "lblEntregayPago";
            lblEntregayPago.Size = new Size(332, 107);
            lblEntregayPago.TabIndex = 4;
            lblEntregayPago.TabStop = false;
            lblEntregayPago.Text = "Entega y Pago";
            // 
            // btnEnReparacion
            // 
            btnEnReparacion.AutoSize = true;
            btnEnReparacion.Location = new Point(146, 51);
            btnEnReparacion.Name = "btnEnReparacion";
            btnEnReparacion.Size = new Size(83, 19);
            btnEnReparacion.TabIndex = 4;
            btnEnReparacion.Text = "En revision";
            btnEnReparacion.UseVisualStyleBackColor = true;
            // 
            // Entregado
            // 
            Entregado.AutoSize = true;
            Entregado.Location = new Point(146, 26);
            Entregado.Name = "Entregado";
            Entregado.Size = new Size(80, 19);
            Entregado.TabIndex = 3;
            Entregado.Text = "Entregado";
            Entregado.UseVisualStyleBackColor = true;
            // 
            // lstEfctivo
            // 
            lstEfctivo.AutoSize = true;
            lstEfctivo.Location = new Point(6, 51);
            lstEfctivo.Name = "lstEfctivo";
            lstEfctivo.Size = new Size(93, 19);
            lstEfctivo.TabIndex = 2;
            lstEfctivo.Text = "Efectivo 40%";
            lstEfctivo.UseVisualStyleBackColor = true;
            lstEfctivo.CheckedChanged += lstEfctivo_CheckedChanged;
            // 
            // lstTargeta
            // 
            lstTargeta.AutoSize = true;
            lstTargeta.Location = new Point(6, 26);
            lstTargeta.Name = "lstTargeta";
            lstTargeta.Size = new Size(86, 19);
            lstTargeta.TabIndex = 1;
            lstTargeta.Text = "Tarjeta 25%";
            lstTargeta.UseVisualStyleBackColor = true;
            lstTargeta.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(680, 397);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(67, 38);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button1_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(614, 397);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(60, 38);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 443);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpiar);
            Controls.Add(lblEntregayPago);
            Controls.Add(lstTicket);
            Controls.Add(lblEquipo);
            Controls.Add(txtDatos);
            Name = "frmCliente";
            Text = "Clientes";
            Load += frmCliente_Load;
            txtDatos.ResumeLayout(false);
            txtDatos.PerformLayout();
            lblEquipo.ResumeLayout(false);
            lblEquipo.PerformLayout();
            lstTicket.ResumeLayout(false);
            lstTicket.PerformLayout();
            lblEntregayPago.ResumeLayout(false);
            lblEntregayPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox txtDatos;
        private GroupBox lblEquipo;
        private Label lblMail;
        private Label lbltelefono;
        private Label lblnombr;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label lblNumero;
        private Label lblTipo;
        private TextBox textBox5;
        private Label lblFalla;
        private GroupBox lstTicket;
        private TextBox textBox6;
        private Label lblPresupuesto;
        private Label lblDescripcion;
        private Label lblTicket;
        private Label lblFecahayhora;
        private TextBox textBox7;
        private Label lblDireccion;
        private TextBox textBox8;
        private ComboBox comboBox1;
        private Label lblFechaestimadadeentrega;
        private TextBox textBox4;
        private TextBox textBox9;
        private GroupBox lblEntregayPago;
        private Button btnLimpiar;
        private Button btnCalcular;
        private CheckBox lstTargeta;
        private CheckBox lstEfctivo;
        private TextBox textBox10;
        private TextBox textBox11;
        private CheckBox btnEnReparacion;
        private CheckBox Entregado;
    }
}
