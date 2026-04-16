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
    public partial class FrmAgregarPoliza : Form
    {
        private ArrayList listaPolizas;

        public FrmAgregarPoliza(ArrayList listaPolizas)
        {
            InitializeComponent();
            this.listaPolizas = listaPolizas;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (txtCodigo.Text == "" || cmbTipo.SelectedIndex == -1 ||
                txtVigencia.Text == "" || txtValorUF.Text == "" || txtCoberturaUF.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar números
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

            // Crear póliza
            Poliza nueva = new Poliza(
                txtCodigo.Text,
                cmbTipo.SelectedItem.ToString(),
                vigencia,
                valorUF,
                coberturaUF
            );

            // Agregar a la lista
            listaPolizas.Add(nueva);

            MessageBox.Show("Póliza agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

