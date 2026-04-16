namespace TrabajoUnidad2VictorJosafat
{
    partial class FrmEliminarCliente
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
            lblBuscarRut = new Label();
            lblCodigoPoliza = new Label();
            lblPoliza = new Label();
            txtTipoPoliza = new TextBox();
            lblTipo = new Label();
            txtCodigoPoliza = new TextBox();
            btnCancelar = new Button();
            btnBuscar = new Button();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtRutBuscar = new TextBox();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lblBuscarRut
            // 
            lblBuscarRut.AutoSize = true;
            lblBuscarRut.Location = new Point(92, 34);
            lblBuscarRut.Name = "lblBuscarRut";
            lblBuscarRut.Size = new Size(154, 20);
            lblBuscarRut.TabIndex = 42;
            lblBuscarRut.Text = "Ingrese Rut de Cliente";
            // 
            // lblCodigoPoliza
            // 
            lblCodigoPoliza.AutoSize = true;
            lblCodigoPoliza.Location = new Point(193, 292);
            lblCodigoPoliza.Name = "lblCodigoPoliza";
            lblCodigoPoliza.Size = new Size(62, 20);
            lblCodigoPoliza.TabIndex = 41;
            lblCodigoPoliza.Text = "Código ";
            // 
            // lblPoliza
            // 
            lblPoliza.AutoSize = true;
            lblPoliza.Location = new Point(129, 244);
            lblPoliza.Name = "lblPoliza";
            lblPoliza.Size = new Size(126, 20);
            lblPoliza.TabIndex = 40;
            lblPoliza.Text = "Póliza Contratada";
            // 
            // txtTipoPoliza
            // 
            txtTipoPoliza.Location = new Point(276, 331);
            txtTipoPoliza.Name = "txtTipoPoliza";
            txtTipoPoliza.ReadOnly = true;
            txtTipoPoliza.Size = new Size(245, 27);
            txtTipoPoliza.TabIndex = 39;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(193, 338);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 38;
            lblTipo.Text = "Tipo";
            // 
            // txtCodigoPoliza
            // 
            txtCodigoPoliza.Location = new Point(276, 285);
            txtCodigoPoliza.Name = "txtCodigoPoliza";
            txtCodigoPoliza.ReadOnly = true;
            txtCodigoPoliza.Size = new Size(245, 27);
            txtCodigoPoliza.TabIndex = 37;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(434, 384);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 37);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(589, 26);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 37);
            btnBuscar.TabIndex = 35;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(276, 189);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(245, 27);
            txtTelefono.TabIndex = 34;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(179, 196);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 33;
            lblTelefono.Text = "Teléfono";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(276, 136);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(245, 27);
            txtApellido.TabIndex = 32;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(177, 143);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 31;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(276, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(245, 27);
            txtNombre.TabIndex = 30;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(179, 94);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 29;
            lblNombre.Text = "Nombre";
            // 
            // txtRutBuscar
            // 
            txtRutBuscar.Location = new Point(276, 31);
            txtRutBuscar.Name = "txtRutBuscar";
            txtRutBuscar.Size = new Size(245, 27);
            txtRutBuscar.TabIndex = 28;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(254, 384);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 37);
            btnEliminar.TabIndex = 43;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmEliminarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(lblBuscarRut);
            Controls.Add(lblCodigoPoliza);
            Controls.Add(lblPoliza);
            Controls.Add(txtTipoPoliza);
            Controls.Add(lblTipo);
            Controls.Add(txtCodigoPoliza);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscar);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtRutBuscar);
            Name = "FrmEliminarCliente";
            Text = "FrmEliminarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBuscarRut;
        private Label lblCodigoPoliza;
        private Label lblPoliza;
        private TextBox txtTipoPoliza;
        private Label lblTipo;
        private TextBox txtCodigoPoliza;
        private Button btnCancelar;
        private Button btnBuscar;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtRutBuscar;
        private Button btnEliminar;
    }
}