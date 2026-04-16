using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabajoUnidad2VictorJosafat
{
    public partial class FrmListarPoliza : Form
    {
        private ArrayList listaPolizas;

        public FrmListarPoliza(ArrayList listaPolizas)
        {
            InitializeComponent();
            this.listaPolizas = listaPolizas;
        }

        private void FrmListarPolizas_Load(object sender, EventArgs e)
        {
            CargarTodas();
        }

        private void CargarTodas()
        {
            dgvPolizas.Rows.Clear();

            foreach (Poliza p in listaPolizas)
            {
                dgvPolizas.Rows.Add(p.Codigo, p.Tipo, p.Vigencia, p.ValorUF);
            }
        }
        public FrmListarPoliza()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoBuscado = txtCodigoBuscar.Text.Trim();

            if (codigoBuscado == "")
            {
                MessageBox.Show("Debe ingresar un código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvPolizas.Rows.Clear();

            bool encontrado = false;

            foreach (Poliza p in listaPolizas)
            {
                if (p.Codigo == codigoBuscado)
                {
                    dgvPolizas.Rows.Add(p.Codigo, p.Tipo, p.Vigencia, p.ValorUF);
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Póliza no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarTodas();
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtCodigoBuscar.Text = "";
            CargarTodas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

