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
    public partial class FrmEliminarPoliza : Form
    {
        private ArrayList listaPolizas;
        private ArrayList listaContratos;
        private Poliza polizaEncontrada;

        public FrmEliminarPoliza(ArrayList listaPolizas, ArrayList listaContratos)
        {
            InitializeComponent();
            this.listaPolizas = listaPolizas;
            this.listaContratos = listaContratos;

            // Deshabilitar campos
            txtTipo.Enabled = false;
            txtVigencia.Enabled = false;
            txtValorUF.Enabled = false;
            txtCoberturaUF.Enabled = false;

            btnEliminar.Enabled = false;
        }

        public FrmEliminarPoliza()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtBuscarCodigo.Text = "";
            txtTipo.Text = "";
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

            // Mostrar datos
            txtBuscarCodigo.Text = polizaEncontrada.Codigo;
            txtTipo.Text = polizaEncontrada.Tipo;
            txtVigencia.Text = polizaEncontrada.Vigencia.ToString();
            txtValorUF.Text = polizaEncontrada.ValorUF.ToString();
            txtCoberturaUF.Text = polizaEncontrada.CoberturaUF.ToString();

            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (polizaEncontrada == null)
                return;

            // Verificar si la póliza está asociada a un contrato
            foreach (ContratoPoliza cp in listaContratos)
            {
                if (cp.Poliza.Codigo == polizaEncontrada.Codigo)
                {
                    MessageBox.Show(
                        "No se puede eliminar esta póliza porque está asociada a un contrato.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
            }

            DialogResult r = MessageBox.Show(
                "¿Está seguro que desea eliminar esta póliza?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (r == DialogResult.No)
                return;

            listaPolizas.Remove(polizaEncontrada);

            MessageBox.Show("Póliza eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


