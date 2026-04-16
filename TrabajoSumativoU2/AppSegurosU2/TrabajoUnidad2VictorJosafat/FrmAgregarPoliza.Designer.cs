namespace TrabajoUnidad2VictorJosafat
{
    partial class FrmAgregarPoliza
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
            lblCodigo = new Label();
            lblTipo = new Label();
            lblValorUF = new Label();
            lblVigencia = new Label();
            lblCoberturaUF = new Label();
            txtCodigo = new TextBox();
            txtValorUF = new TextBox();
            txtVigencia = new TextBox();
            txtCoberturaUF = new TextBox();
            cmbTipo = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(136, 86);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(122, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código de Póliza";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(155, 132);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(103, 20);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo de Póliza";
            // 
            // lblValorUF
            // 
            lblValorUF.AutoSize = true;
            lblValorUF.Location = new Point(115, 227);
            lblValorUF.Name = "lblValorUF";
            lblValorUF.Size = new Size(143, 20);
            lblValorUF.TabIndex = 2;
            lblValorUF.Text = "Valor Mensual en UF";
            // 
            // lblVigencia
            // 
            lblVigencia.AutoSize = true;
            lblVigencia.Location = new Point(137, 178);
            lblVigencia.Name = "lblVigencia";
            lblVigencia.Size = new Size(121, 20);
            lblVigencia.TabIndex = 3;
            lblVigencia.Text = "Vigencia (meses)";
            // 
            // lblCoberturaUF
            // 
            lblCoberturaUF.AutoSize = true;
            lblCoberturaUF.Location = new Point(142, 275);
            lblCoberturaUF.Name = "lblCoberturaUF";
            lblCoberturaUF.Size = new Size(116, 20);
            lblCoberturaUF.TabIndex = 4;
            lblCoberturaUF.Text = "Cobertura en UF";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(304, 86);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(245, 27);
            txtCodigo.TabIndex = 5;
            // 
            // txtValorUF
            // 
            txtValorUF.Location = new Point(304, 230);
            txtValorUF.Name = "txtValorUF";
            txtValorUF.Size = new Size(245, 27);
            txtValorUF.TabIndex = 6;
            // 
            // txtVigencia
            // 
            txtVigencia.Location = new Point(304, 181);
            txtVigencia.Name = "txtVigencia";
            txtVigencia.Size = new Size(245, 27);
            txtVigencia.TabIndex = 7;
            // 
            // txtCoberturaUF
            // 
            txtCoberturaUF.Location = new Point(304, 275);
            txtCoberturaUF.Name = "txtCoberturaUF";
            txtCoberturaUF.Size = new Size(245, 27);
            txtCoberturaUF.TabIndex = 8;
            // 
            // cmbTipo
            // 
            cmbTipo.Items.AddRange(new object[] { "Seguro de Vida", "Seguro de Salud", "Seguro contra Incendio", "Seguro Accidente Automovilístico", "Seguro contra Robos", "" });
            cmbTipo.Location = new Point(304, 132);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(245, 28);
            cmbTipo.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(271, 341);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 36);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(504, 341);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 36);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAgregarPoliza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbTipo);
            Controls.Add(txtCoberturaUF);
            Controls.Add(txtVigencia);
            Controls.Add(txtValorUF);
            Controls.Add(txtCodigo);
            Controls.Add(lblCoberturaUF);
            Controls.Add(lblVigencia);
            Controls.Add(lblValorUF);
            Controls.Add(lblTipo);
            Controls.Add(lblCodigo);
            Name = "FrmAgregarPoliza";
            Text = "FrmAgregarPoliza";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblTipo;
        private Label lblValorUF;
        private Label lblVigencia;
        private Label lblCoberturaUF;
        private TextBox txtCodigo;
        private TextBox txtValorUF;
        private TextBox txtVigencia;
        private TextBox txtCoberturaUF;
        private ComboBox cmbTipo;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}