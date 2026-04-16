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
    public partial class FrmAgregarCliente : Form
    {
        private ArrayList listaClientes;

        public FrmAgregarCliente(ArrayList listaClientes)
        {
            InitializeComponent();
            this.listaClientes = listaClientes;
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (txtRut.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear cliente
            Cliente nuevo = new Cliente(
                txtRut.Text,
                txtNombre.Text,
                txtApellido.Text,
                txtTelefono.Text
            );

            // Agregar a la lista
            listaClientes.Add(nuevo);

            MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
