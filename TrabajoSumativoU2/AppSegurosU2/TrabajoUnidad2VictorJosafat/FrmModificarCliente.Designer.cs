namespace TrabajoUnidad2VictorJosafat
{
    partial class FrmModificarCliente
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
            btnCancelar = new Button();
            btnGuardarCambios = new Button();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtBuscarRut = new TextBox();
            lblBuscarRut = new Label();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(474, 330);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 37);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(258, 330);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(146, 37);
            btnGuardarCambios.TabIndex = 18;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(305, 242);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(245, 27);
            txtTelefono.TabIndex = 17;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(208, 249);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Teléfono";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(305, 196);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(245, 27);
            txtApellido.TabIndex = 15;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(208, 203);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 14;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(305, 140);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 27);
            txtNombre.TabIndex = 13;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(208, 147);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre";
            // 
            // txtBuscarRut
            // 
            txtBuscarRut.Location = new Point(305, 84);
            txtBuscarRut.Name = "txtBuscarRut";
            txtBuscarRut.Size = new Size(245, 27);
            txtBuscarRut.TabIndex = 11;
            // 
            // lblBuscarRut
            // 
            lblBuscarRut.AutoSize = true;
            lblBuscarRut.Location = new Point(117, 87);
            lblBuscarRut.Name = "lblBuscarRut";
            lblBuscarRut.Size = new Size(158, 20);
            lblBuscarRut.TabIndex = 10;
            lblBuscarRut.Text = "Ingrese Rut del Cliente";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(603, 79);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 37);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmModificarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarCambios);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtBuscarRut);
            Controls.Add(lblBuscarRut);
            Name = "FrmModificarCliente";
            Text = "FrmModificarCliente";
            Load += FrmModificarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardarCambios;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtBuscarRut;
        private Label lblBuscarRut;
        private Button btnBuscar;
    }
}