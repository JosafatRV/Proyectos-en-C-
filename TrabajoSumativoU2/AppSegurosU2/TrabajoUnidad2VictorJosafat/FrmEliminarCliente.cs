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
    public partial class FrmEliminarCliente : Form
    {
        private ArrayList listaClientes;
        private ArrayList listaContratos;
        private Cliente clienteEncontrado;
        private ContratoPoliza contratoEncontrado;

        public FrmEliminarCliente(ArrayList listaClientes, ArrayList listaContratos)
        {
            InitializeComponent();
            this.listaClientes = listaClientes;
            this.listaContratos = listaContratos;

            // Deshabilitar campos
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtCodigoPoliza.Enabled = false;
            txtTipoPoliza.Enabled = false;

            btnEliminar.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCodigoPoliza.Text = "";
            txtTipoPoliza.Text = "";
        }

        public FrmEliminarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string rutBuscado = txtRutBuscar.Text.Trim();

            if (rutBuscado == "")
            {
                MessageBox.Show("Debe ingresar un RUT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clienteEncontrado = null;
            contratoEncontrado = null;

            // Buscar cliente
            foreach (Cliente c in listaClientes)
            {
                if (c.Rut == rutBuscado)
                {
                    clienteEncontrado = c;
                    break;
                }
            }

            if (clienteEncontrado == null)
            {
                MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
                return;
            }

            // Mostrar datos del cliente
            txtNombre.Text = clienteEncontrado.Nombre;
            txtApellido.Text = clienteEncontrado.Apellido;
            txtTelefono.Text = clienteEncontrado.Telefono;

            // Buscar póliza asociada
            foreach (ContratoPoliza cp in listaContratos)
            {
                if (cp.Cliente.Rut == rutBuscado)
                {
                    contratoEncontrado = cp;
                    break;
                }
            }

            if (contratoEncontrado == null)
            {
                txtCodigoPoliza.Text = "Sin póliza";
                txtTipoPoliza.Text = "—";
            }
            else
            {
                txtCodigoPoliza.Text = contratoEncontrado.Poliza.Codigo;
                txtTipoPoliza.Text = contratoEncontrado.Poliza.Tipo;
            }

            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteEncontrado == null)
                return;

            DialogResult r = MessageBox.Show(
                "¿Está seguro que desea eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (r == DialogResult.No)
                return;

            // Si tiene contrato, eliminarlo también
            if (contratoEncontrado != null)
            {
                listaContratos.Remove(contratoEncontrado);
            }

            // Eliminar cliente
            listaClientes.Remove(clienteEncontrado);

            MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


