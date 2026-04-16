namespace TrabajoUnidad2VictorJosafat
{
    partial class FrmConsultarCliente
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
            btnCerrar = new Button();
            btnBuscar = new Button();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtRutBuscar = new TextBox();
            lblRut = new Label();
            txtTipoPoliza = new TextBox();
            lblTipo = new Label();
            txtCodigoPoliza = new TextBox();
            lblPoliza = new Label();
            lblCodigoPoliza = new Label();
            lblBuscarRut = new Label();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(332, 385);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(119, 37);
            btnCerrar.TabIndex = 19;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(594, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 37);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(281, 187);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(245, 27);
            txtTelefono.TabIndex = 17;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(184, 194);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Teléfono";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(281, 134);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(245, 27);
            txtApellido.TabIndex = 15;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(182, 141);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 14;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(281, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(245, 27);
            txtNombre.TabIndex = 13;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(184, 92);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre";
            // 
            // txtRutBuscar
            // 
            txtRutBuscar.Location = new Point(281, 29);
            txtRutBuscar.Name = "txtRutBuscar";
            txtRutBuscar.Size = new Size(245, 27);
            txtRutBuscar.TabIndex = 11;
            // 
            // lblRut
            // 
            lblRut.Location = new Point(0, 0);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(100, 23);
            lblRut.TabIndex = 26;
            // 
            // txtTipoPoliza
            // 
            txtTipoPoliza.Location = new Point(281, 314);
            txtTipoPoliza.Name = "txtTipoPoliza";
            txtTipoPoliza.ReadOnly = true;
            txtTipoPoliza.Size = new Size(245, 27);
            txtTipoPoliza.TabIndex = 23;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(198, 321);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 22;
            lblTipo.Text = "Tipo";
            // 
            // txtCodigoPoliza
            // 
            txtCodigoPoliza.Location = new Point(281, 268);
            txtCodigoPoliza.Name = "txtCodigoPoliza";
            txtCodigoPoliza.ReadOnly = true;
            txtCodigoPoliza.Size = new Size(245, 27);
            txtCodigoPoliza.TabIndex = 21;
            // 
            // lblPoliza
            // 
            lblPoliza.AutoSize = true;
            lblPoliza.Location = new Point(134, 242);
            lblPoliza.Name = "lblPoliza";
            lblPoliza.Size = new Size(126, 20);
            lblPoliza.TabIndex = 24;
            lblPoliza.Text = "Póliza Contratada";
            // 
            // lblCodigoPoliza
            // 
            lblCodigoPoliza.AutoSize = true;
            lblCodigoPoliza.Location = new Point(198, 275);
            lblCodigoPoliza.Name = "lblCodigoPoliza";
            lblCodigoPoliza.Size = new Size(62, 20);
            lblCodigoPoliza.TabIndex = 25;
            lblCodigoPoliza.Text = "Código ";
            // 
            // lblBuscarRut
            // 
            lblBuscarRut.AutoSize = true;
            lblBuscarRut.Location = new Point(97, 32);
            lblBuscarRut.Name = "lblBuscarRut";
            lblBuscarRut.Size = new Size(154, 20);
            lblBuscarRut.TabIndex = 27;
            lblBuscarRut.Text = "Ingrese Rut de Cliente";
            // 
            // FrmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBuscarRut);
            Controls.Add(lblCodigoPoliza);
            Controls.Add(lblPoliza);
            Controls.Add(txtTipoPoliza);
            Controls.Add(lblTipo);
            Controls.Add(txtCodigoPoliza);
            Controls.Add(btnCerrar);
            Controls.Add(btnBuscar);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtRutBuscar);
            Controls.Add(lblRut);
            Name = "FrmConsultarCliente";
            Text = "FrmConsultarCliente";
            Load += FrmConsultarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnBuscar;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtRutBuscar;
        private Label lblRut;
        private TextBox txtTipoPoliza;
        private Label lblTipo;
        private TextBox txtCodigoPoliza;
        private Label lblPoliza;
        private Label lblCodigoPoliza;
        private Label lblBuscarRut;
    }
}