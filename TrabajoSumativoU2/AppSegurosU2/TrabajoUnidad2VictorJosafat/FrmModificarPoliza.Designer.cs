namespace TrabajoUnidad2VictorJosafat
{
    partial class FrmModificarPoliza
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
            cmbTipo = new ComboBox();
            txtCoberturaUF = new TextBox();
            txtVigencia = new TextBox();
            txtValorUF = new TextBox();
            txtBuscarCodigo = new TextBox();
            lblCoberturaUF = new Label();
            lblVigencia = new Label();
            lblValorUF = new Label();
            lblTipo = new Label();
            lblCodigo = new Label();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(509, 334);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 36);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(280, 334);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(144, 36);
            btnGuardarCambios.TabIndex = 21;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.Items.AddRange(new object[] { "Seguro de Vida", "Seguro de Salud", "Seguro contra Incendio", "Seguro Accidente Automovilístico", "Seguro contra Robos", "" });
            cmbTipo.Location = new Point(318, 125);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(245, 28);
            cmbTipo.TabIndex = 11;
            // 
            // txtCoberturaUF
            // 
            txtCoberturaUF.Location = new Point(318, 268);
            txtCoberturaUF.Name = "txtCoberturaUF";
            txtCoberturaUF.Size = new Size(245, 27);
            txtCoberturaUF.TabIndex = 20;
            // 
            // txtVigencia
            // 
            txtVigencia.Location = new Point(318, 174);
            txtVigencia.Name = "txtVigencia";
            txtVigencia.Size = new Size(245, 27);
            txtVigencia.TabIndex = 19;
            // 
            // txtValorUF
            // 
            txtValorUF.Location = new Point(318, 223);
            txtValorUF.Name = "txtValorUF";
            txtValorUF.Size = new Size(245, 27);
            txtValorUF.TabIndex = 18;
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.Location = new Point(318, 79);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(245, 27);
            txtBuscarCodigo.TabIndex = 17;
            // 
            // lblCoberturaUF
            // 
            lblCoberturaUF.AutoSize = true;
            lblCoberturaUF.Location = new Point(156, 268);
            lblCoberturaUF.Name = "lblCoberturaUF";
            lblCoberturaUF.Size = new Size(116, 20);
            lblCoberturaUF.TabIndex = 16;
            lblCoberturaUF.Text = "Cobertura en UF";
            // 
            // lblVigencia
            // 
            lblVigencia.AutoSize = true;
            lblVigencia.Location = new Point(151, 171);
            lblVigencia.Name = "lblVigencia";
            lblVigencia.Size = new Size(121, 20);
            lblVigencia.TabIndex = 15;
            lblVigencia.Text = "Vigencia (meses)";
            // 
            // lblValorUF
            // 
            lblValorUF.AutoSize = true;
            lblValorUF.Location = new Point(129, 220);
            lblValorUF.Name = "lblValorUF";
            lblValorUF.Size = new Size(143, 20);
            lblValorUF.TabIndex = 14;
            lblValorUF.Text = "Valor Mensual en UF";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(169, 125);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(103, 20);
            lblTipo.TabIndex = 13;
            lblTipo.Text = "Tipo de Póliza";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(98, 82);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(174, 20);
            lblCodigo.TabIndex = 12;
            lblCodigo.Text = "Ingrese Código de Póliza";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(613, 70);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(105, 36);
            btnBuscar.TabIndex = 23;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmModificarPoliza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarCambios);
            Controls.Add(cmbTipo);
            Controls.Add(txtCoberturaUF);
            Controls.Add(txtVigencia);
            Controls.Add(txtValorUF);
            Controls.Add(txtBuscarCodigo);
            Controls.Add(lblCoberturaUF);
            Controls.Add(lblVigencia);
            Controls.Add(lblValorUF);
            Controls.Add(lblTipo);
            Controls.Add(lblCodigo);
            Name = "FrmModificarPoliza";
            Text = "FrmModificarPoliza";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardarCambios;
        private ComboBox cmbTipo;
        private TextBox txtCoberturaUF;
        private TextBox txtVigencia;
        private TextBox txtValorUF;
        private TextBox txtBuscarCodigo;
        private Label lblCoberturaUF;
        private Label lblVigencia;
        private Label lblValorUF;
        private Label lblTipo;
        private Label lblCodigo;
        private Button btnBuscar;
    }
}