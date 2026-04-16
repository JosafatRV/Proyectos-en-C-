namespace TrabajoUnidad2VictorJosafat
{
    partial class FrmAgregarCliente
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
            lblRut = new Label();
            txtRut = new TextBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblRut
            // 
            lblRut.AutoSize = true;
            lblRut.Location = new Point(175, 100);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(31, 20);
            lblRut.TabIndex = 0;
            lblRut.Text = "Rut";
            // 
            // txtRut
            // 
            txtRut.Location = new Point(272, 93);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(245, 27);
            txtRut.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(272, 149);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(175, 156);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(272, 205);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(245, 27);
            txtApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(175, 212);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(272, 251);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(245, 27);
            txtTelefono.TabIndex = 7;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(175, 258);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(231, 339);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 37);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(441, 339);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 37);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 456);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtRut);
            Controls.Add(lblRut);
            Name = "FrmAgregarCliente";
            Text = "FrmAgregarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRut;
        private TextBox txtRut;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}