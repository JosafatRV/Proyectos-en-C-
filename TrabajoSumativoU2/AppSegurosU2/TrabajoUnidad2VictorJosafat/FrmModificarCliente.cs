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
    public partial class FrmModificarCliente : Form
    {
        private ArrayList listaClientes;
        private Cliente clienteEncontrado;

        public FrmModificarCliente(ArrayList listaClientes)
        {
            InitializeComponent();
            this.listaClientes = listaClientes;

            // Deshabilitar campos hasta que se encuentre un cliente
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            btnGuardarCambios.Enabled = false;
        }


        public FrmModificarCliente()
        {
            InitializeComponent();
        }

        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string rutBuscado = txtBuscarRut.Text;

            clienteEncontrado = null;

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
                return;
            }

            // Cargar datos en los TextBox
            txtNombre.Text = clienteEncontrado.Nombre;
            txtApellido.Text = clienteEncontrado.Apellido;
            txtTelefono.Text = clienteEncontrado.Telefono;

            // Habilitar edición
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            btnGuardarCambios.Enabled = true;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (clienteEncontrado == null)
                return;

            // Guardar cambios
            clienteEncontrado.Nombre = txtNombre.Text;
            clienteEncontrado.Apellido = txtApellido.Text;
            clienteEncontrado.Telefono = txtTelefono.Text;

            MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

} 
