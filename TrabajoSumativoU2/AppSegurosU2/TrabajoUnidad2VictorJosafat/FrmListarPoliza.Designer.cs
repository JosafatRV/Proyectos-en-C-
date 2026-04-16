namespace TrabajoUnidad2VictorJosafat
{
    partial class FrmListarPoliza
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
            btnMostrarTodos = new Button();
            btnCerrar = new Button();
            lblCodigoBuscar = new Label();
            txtCodigoBuscar = new TextBox();
            dgvPolizas = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colVigencia = new DataGridViewTextBoxColumn();
            colValorUF = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPolizas).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(501, 42);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(675, 95);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(113, 35);
            btnMostrarTodos.TabIndex = 1;
            btnMostrarTodos.Text = "Mostrar Todas";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(684, 381);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblCodigoBuscar
            // 
            lblCodigoBuscar.AutoSize = true;
            lblCodigoBuscar.Location = new Point(59, 46);
            lblCodigoBuscar.Name = "lblCodigoBuscar";
            lblCodigoBuscar.Size = new Size(174, 20);
            lblCodigoBuscar.TabIndex = 3;
            lblCodigoBuscar.Text = "Ingrese Código de Póliza";
            // 
            // txtCodigoBuscar
            // 
            txtCodigoBuscar.Location = new Point(239, 43);
            txtCodigoBuscar.Name = "txtCodigoBuscar";
            txtCodigoBuscar.Size = new Size(214, 27);
            txtCodigoBuscar.TabIndex = 4;
            // 
            // dgvPolizas
            // 
            dgvPolizas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPolizas.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colTipo, colVigencia, colValorUF });
            dgvPolizas.Location = new Point(59, 95);
            dgvPolizas.Name = "dgvPolizas";
            dgvPolizas.RowHeadersWidth = 51;
            dgvPolizas.Size = new Size(594, 315);
            dgvPolizas.TabIndex = 5;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            colCodigo.Width = 125;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.MinimumWidth = 6;
            colTipo.Name = "colTipo";
            colTipo.Width = 125;
            // 
            // colVigencia
            // 
            colVigencia.HeaderText = "Vigencia (meses)";
            colVigencia.MinimumWidth = 6;
            colVigencia.Name = "colVigencia";
            colVigencia.Width = 125;
            // 
            // colValorUF
            // 
            colValorUF.HeaderText = "Valor Mensual en UF";
            colValorUF.MinimumWidth = 6;
            colValorUF.Name = "colValorUF";
            colValorUF.Width = 125;
            // 
            // FrmListarPoliza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPolizas);
            Controls.Add(txtCodigoBuscar);
            Controls.Add(lblCodigoBuscar);
            Controls.Add(btnCerrar);
            Controls.Add(btnMostrarTodos);
            Controls.Add(btnBuscar);
            Name = "FrmListarPoliza";
            Text = "FrmListarPolizas";
            ((System.ComponentModel.ISupportInitialize)dgvPolizas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnMostrarTodos;
        private Button btnCerrar;
        private Label lblCodigoBuscar;
        private TextBox txtCodigoBuscar;
        private DataGridView dgvPolizas;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colVigencia;
        private DataGridViewTextBoxColumn colValorUF;
    }
}