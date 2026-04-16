namespace TrabajoUnidad2VictorJosafat
{
    partial class FrmEliminarPoliza
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
            btnBuscar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            txtCoberturaUF = new TextBox();
            txtVigencia = new TextBox();
            txtValorUF = new TextBox();
            txtBuscarCodigo = new TextBox();
            lblCoberturaUF = new Label();
            lblVigencia = new Label();
            lblValorUF = new Label();
            lblTipo = new Label();
            lblCodigo = new Label();
            txtTipo = new TextBox();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(605, 75);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(105, 36);
            btnBuscar.TabIndex = 36;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(501, 339);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 36);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(272, 339);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 36);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtCoberturaUF
            // 
            txtCoberturaUF.Location = new Point(310, 273);
            txtCoberturaUF.Name = "txtCoberturaUF";
            txtCoberturaUF.Size = new Size(245, 27);
            txtCoberturaUF.TabIndex = 33;
            // 
            // txtVigencia
            // 
            txtVigencia.Location = new Point(310, 179);
            txtVigencia.Name = "txtVigencia";
            txtVigencia.Size = new Size(245, 27);
            txtVigencia.TabIndex = 32;
            // 
            // txtValorUF
            // 
            txtValorUF.Location = new Point(310, 228);
            txtValorUF.Name = "txtValorUF";
            txtValorUF.Size = new Size(245, 27);
            txtValorUF.TabIndex = 31;
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.Location = new Point(310, 84);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(245, 27);
            txtBuscarCodigo.TabIndex = 30;
            // 
            // lblCoberturaUF
            // 
            lblCoberturaUF.AutoSize = true;
            lblCoberturaUF.Location = new Point(148, 273);
            lblCoberturaUF.Name = "lblCoberturaUF";
            lblCoberturaUF.Size = new Size(116, 20);
            lblCoberturaUF.TabIndex = 29;
            lblCoberturaUF.Text = "Cobertura en UF";
            // 
            // lblVigencia
            // 
            lblVigencia.AutoSize = true;
            lblVigencia.Location = new Point(143, 176);
            lblVigencia.Name = "lblVigencia";
            lblVigencia.Size = new Size(121, 20);
            lblVigencia.TabIndex = 28;
            lblVigencia.Text = "Vigencia (meses)";
            // 
            // lblValorUF
            // 
            lblValorUF.AutoSize = true;
            lblValorUF.Location = new Point(121, 225);
            lblValorUF.Name = "lblValorUF";
            lblValorUF.Size = new Size(143, 20);
            lblValorUF.TabIndex = 27;
            lblValorUF.Text = "Valor Mensual en UF";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(161, 130);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(103, 20);
            lblTipo.TabIndex = 26;
            lblTipo.Text = "Tipo de Póliza";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(90, 87);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(174, 20);
            lblCodigo.TabIndex = 25;
            lblCodigo.Text = "Ingrese Código de Póliza";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(310, 130);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(245, 27);
            txtTipo.TabIndex = 37;
            // 
            // FrmEliminarPoliza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTipo);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(txtCoberturaUF);
            Controls.Add(txtVigencia);
            Controls.Add(txtValorUF);
            Controls.Add(txtBuscarCodigo);
            Controls.Add(lblCoberturaUF);
            Controls.Add(lblVigencia);
            Controls.Add(lblValorUF);
            Controls.Add(lblTipo);
            Controls.Add(lblCodigo);
            Name = "FrmEliminarPoliza";
            Text = "FrmEliminarPoliza";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnCancelar;
        private Button btnEliminar;
        private TextBox txtCoberturaUF;
        private TextBox txtVigencia;
        private TextBox txtValorUF;
        private TextBox txtBuscarCodigo;
        private Label lblCoberturaUF;
        private Label lblVigencia;
        private Label lblValorUF;
        private Label lblTipo;
        private Label lblCodigo;
        private TextBox txtTipo;
    }
}