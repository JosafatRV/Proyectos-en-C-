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
    public partial class FrmConsultarCliente : Form
    {
        private ArrayList listaClientes;
        private ArrayList listaContratos;

        public FrmConsultarCliente(ArrayList listaClientes, ArrayList listaContratos)
        {
            InitializeComponent();
            this.listaClientes = listaClientes;
            this.listaContratos = listaContratos;

            // Campos deshabilitados
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtCodigoPoliza.Enabled = false;
            txtTipoPoliza.Enabled = false;
        }

        public FrmConsultarCliente()
        {
            InitializeComponent();
        }
        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string rutBuscado = txtRutBuscar.Text.Trim();

            if (rutBuscado == "")
            {
                MessageBox.Show("Debe ingresar un RUT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente encontrado = null;

            foreach (Cliente c in listaClientes)
            {
                if (c.Rut == rutBuscado)
                {
                    encontrado = c;
                    break;
                }
            }

            if (encontrado == null)
            {
                MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
                return;
            }

            // Mostrar datos del cliente
            txtNombre.Text = encontrado.Nombre;
            txtApellido.Text = encontrado.Apellido;
            txtTelefono.Text = encontrado.Telefono;

            // Buscar póliza asociada
            ContratoPoliza contrato = null;

            foreach (ContratoPoliza cp in listaContratos)
            {
                if (cp.Cliente.Rut == rutBuscado)
                {
                    contrato = cp;
                    break;
                }
            }

            if (contrato == null)
            {
                txtCodigoPoliza.Text = "Sin póliza";
                txtTipoPoliza.Text = "—";
            }
            else
            {
                txtCodigoPoliza.Text = contrato.Poliza.Codigo;
                txtTipoPoliza.Text = contrato.Poliza.Tipo;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCodigoPoliza.Text = "";
            txtTipoPoliza.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
