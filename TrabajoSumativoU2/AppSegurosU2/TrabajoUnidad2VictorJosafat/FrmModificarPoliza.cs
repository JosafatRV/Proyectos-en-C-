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
    public partial class FrmModificarPoliza : Form
    {
        private ArrayList listaPolizas;
        private Poliza polizaEncontrada;

        public FrmModificarPoliza(ArrayList listaPolizas)
        {
            InitializeComponent();
            this.listaPolizas = listaPolizas;

            // Deshabilitar campos hasta encontrar la póliza
            cmbTipo.Enabled = false;
            txtVigencia.Enabled = false;
            txtValorUF.Enabled = false;
            txtCoberturaUF.Enabled = false;
            btnGuardarCambios.Enabled = false;
        }
        private void LimpiarCampos()
        {
            txtBuscarCodigo.Text = "";
            cmbTipo.SelectedIndex = -1;
            txtVigencia.Text = "";
            txtValorUF.Text = "";
            txtCoberturaUF.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoBuscado = txtBuscarCodigo.Text.Trim();

            if (codigoBuscado == "")
            {
                MessageBox.Show("Debe ingresar un código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            polizaEncontrada = null;

            foreach (Poliza p in listaPolizas)
            {
                if (p.Codigo == codigoBuscado)
                {
                    polizaEncontrada = p;
                    break;
                }
            }

            if (polizaEncontrada == null)
            {
                MessageBox.Show("Póliza no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
                return;
            }

            // Cargar datos
            txtBuscarCodigo.Text = polizaEncontrada.Codigo;
            cmbTipo.SelectedItem = polizaEncontrada.Tipo;
            txtVigencia.Text = polizaEncontrada.Vigencia.ToString();
            txtValorUF.Text = polizaEncontrada.ValorUF.ToString();
            txtCoberturaUF.Text = polizaEncontrada.CoberturaUF.ToString();

            // Habilitar edición
            cmbTipo.Enabled = true;
            txtVigencia.Enabled = true;
            txtValorUF.Enabled = true;
            txtCoberturaUF.Enabled = true;
            btnGuardarCambios.Enabled = true;
        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (polizaEncontrada == null)
                return;

            // Validaciones
            if (cmbTipo.SelectedIndex == -1 ||
                txtVigencia.Text == "" || txtValorUF.Text == "" || txtCoberturaUF.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtVigencia.Text, out int vigencia))
            {
                MessageBox.Show("La vigencia debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtValorUF.Text, out double valorUF))
            {
                MessageBox.Show("El valor UF debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtCoberturaUF.Text, out double coberturaUF))
            {
                MessageBox.Show("La cobertura UF debe ser numérica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Guardar cambios
            polizaEncontrada.Tipo = cmbTipo.SelectedItem.ToString();
            polizaEncontrada.Vigencia = vigencia;
            polizaEncontrada.ValorUF = valorUF;
            polizaEncontrada.CoberturaUF = coberturaUF;

            MessageBox.Show("Póliza modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
