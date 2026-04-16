namespace TrabajoUnidad2VictorJosafat
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            agregarClienteToolStripMenuItem = new ToolStripMenuItem();
            agregarClienteToolStripMenuItem1 = new ToolStripMenuItem();
            consultarClienteToolStripMenuItem = new ToolStripMenuItem();
            modificarClienteToolStripMenuItem = new ToolStripMenuItem();
            eliminarClienteToolStripMenuItem = new ToolStripMenuItem();
            agregarPólizasToolStripMenuItem = new ToolStripMenuItem();
            agregarPólizasToolStripMenuItem1 = new ToolStripMenuItem();
            modificarPólizasToolStripMenuItem = new ToolStripMenuItem();
            listadoDePólizasToolStripMenuItem = new ToolStripMenuItem();
            eliminarPólizasToolStripMenuItem = new ToolStripMenuItem();
            simularContratoToolStripMenuItem = new ToolStripMenuItem();
            adquirirPólizaToolStripMenuItem = new ToolStripMenuItem();
            listadoDeContratosToolStripMenuItem = new ToolStripMenuItem();
            listadoDeClientesYPólizasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarClienteToolStripMenuItem, agregarPólizasToolStripMenuItem, simularContratoToolStripMenuItem, listadoDeContratosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(998, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarClienteToolStripMenuItem
            // 
            agregarClienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarClienteToolStripMenuItem1, consultarClienteToolStripMenuItem, modificarClienteToolStripMenuItem, eliminarClienteToolStripMenuItem });
            agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            agregarClienteToolStripMenuItem.Size = new Size(75, 24);
            agregarClienteToolStripMenuItem.Text = "Clientes";
            // 
            // agregarClienteToolStripMenuItem1
            // 
            agregarClienteToolStripMenuItem1.Name = "agregarClienteToolStripMenuItem1";
            agregarClienteToolStripMenuItem1.Size = new Size(208, 26);
            agregarClienteToolStripMenuItem1.Text = "Agregar Cliente";
            agregarClienteToolStripMenuItem1.Click += agregarClienteToolStripMenuItem_Click;
            // 
            // consultarClienteToolStripMenuItem
            // 
            consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            consultarClienteToolStripMenuItem.Size = new Size(208, 26);
            consultarClienteToolStripMenuItem.Text = "Consultar Cliente ";
            consultarClienteToolStripMenuItem.Click += consultarClienteToolStripMenuItem_Click;
            // 
            // modificarClienteToolStripMenuItem
            // 
            modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            modificarClienteToolStripMenuItem.Size = new Size(208, 26);
            modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            modificarClienteToolStripMenuItem.Click += modificarClienteToolStripMenuItem_Click;
            // 
            // eliminarClienteToolStripMenuItem
            // 
            eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            eliminarClienteToolStripMenuItem.Size = new Size(208, 26);
            eliminarClienteToolStripMenuItem.Text = "Eliminar Cliente";
            eliminarClienteToolStripMenuItem.Click += eliminarClienteToolStripMenuItem_Click;
            // 
            // agregarPólizasToolStripMenuItem
            // 
            agregarPólizasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarPólizasToolStripMenuItem1, modificarPólizasToolStripMenuItem, listadoDePólizasToolStripMenuItem, eliminarPólizasToolStripMenuItem });
            agregarPólizasToolStripMenuItem.Name = "agregarPólizasToolStripMenuItem";
            agregarPólizasToolStripMenuItem.Size = new Size(68, 24);
            agregarPólizasToolStripMenuItem.Text = "Pólizas";
            // 
            // agregarPólizasToolStripMenuItem1
            // 
            agregarPólizasToolStripMenuItem1.Name = "agregarPólizasToolStripMenuItem1";
            agregarPólizasToolStripMenuItem1.Size = new Size(224, 26);
            agregarPólizasToolStripMenuItem1.Text = "Agregar Pólizas";
            agregarPólizasToolStripMenuItem1.Click += agregarPolizaToolStripMenuItem_Click;
            // 
            // modificarPólizasToolStripMenuItem
            // 
            modificarPólizasToolStripMenuItem.Name = "modificarPólizasToolStripMenuItem";
            modificarPólizasToolStripMenuItem.Size = new Size(224, 26);
            modificarPólizasToolStripMenuItem.Text = "Modificar Pólizas";
            modificarPólizasToolStripMenuItem.Click += modificarPolizaToolStripMenuItem_Click;
            // 
            // listadoDePólizasToolStripMenuItem
            // 
            listadoDePólizasToolStripMenuItem.Name = "listadoDePólizasToolStripMenuItem";
            listadoDePólizasToolStripMenuItem.Size = new Size(224, 26);
            listadoDePólizasToolStripMenuItem.Text = "Listado de Pólizas";
            listadoDePólizasToolStripMenuItem.Click += listarPolizaToolStripMenuItem_Click;
            // 
            // eliminarPólizasToolStripMenuItem
            // 
            eliminarPólizasToolStripMenuItem.Name = "eliminarPólizasToolStripMenuItem";
            eliminarPólizasToolStripMenuItem.Size = new Size(224, 26);
            eliminarPólizasToolStripMenuItem.Text = "Eliminar Pólizas";
            eliminarPólizasToolStripMenuItem.Click += eliminarPolizaToolStripMenuItem_Click;
            // 
            // simularContratoToolStripMenuItem
            // 
            simularContratoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adquirirPólizaToolStripMenuItem });
            simularContratoToolStripMenuItem.Name = "simularContratoToolStripMenuItem";
            simularContratoToolStripMenuItem.Size = new Size(135, 24);
            simularContratoToolStripMenuItem.Text = "Simular Contrato";
            // 
            // adquirirPólizaToolStripMenuItem
            // 
            adquirirPólizaToolStripMenuItem.Name = "adquirirPólizaToolStripMenuItem";
            adquirirPólizaToolStripMenuItem.Size = new Size(224, 26);
            adquirirPólizaToolStripMenuItem.Text = "Adquirir Póliza";
            // 
            // listadoDeContratosToolStripMenuItem
            // 
            listadoDeContratosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listadoDeClientesYPólizasToolStripMenuItem });
            listadoDeContratosToolStripMenuItem.Name = "listadoDeContratosToolStripMenuItem";
            listadoDeContratosToolStripMenuItem.Size = new Size(165, 24);
            listadoDeContratosToolStripMenuItem.Text = "Reporte de Contratos";
            // 
            // listadoDeClientesYPólizasToolStripMenuItem
            // 
            listadoDeClientesYPólizasToolStripMenuItem.Name = "listadoDeClientesYPólizasToolStripMenuItem";
            listadoDeClientesYPólizasToolStripMenuItem.Size = new Size(277, 26);
            listadoDeClientesYPólizasToolStripMenuItem.Text = "Listado de Clientes y Pólizas";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 590);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "V&J SEGUROS";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem agregarClienteToolStripMenuItem;
        private ToolStripMenuItem agregarPólizasToolStripMenuItem;
        private ToolStripMenuItem agregarClienteToolStripMenuItem1;
        private ToolStripMenuItem consultarClienteToolStripMenuItem;
        private ToolStripMenuItem modificarClienteToolStripMenuItem;
        private ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private ToolStripMenuItem listadoDeContratosToolStripMenuItem;
        private ToolStripMenuItem simularContratoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem agregarPólizasToolStripMenuItem1;
        private ToolStripMenuItem modificarPólizasToolStripMenuItem;
        private ToolStripMenuItem eliminarPólizasToolStripMenuItem;
        private ToolStripMenuItem listadoDeClientesYPólizasToolStripMenuItem;
        private ToolStripMenuItem adquirirPólizaToolStripMenuItem;
        private ToolStripMenuItem listadoDePólizasToolStripMenuItem;
    }
}
