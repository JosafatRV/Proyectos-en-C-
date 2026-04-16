using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rojas_Josafat_Trabajo1
{
    public partial class FrmModificar : Form
    {
        public FrmModificar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);

            ArrayList Lista = ((MenuPrincipal)Owner).Lista;

            foreach (Producto p in Lista)
            {
                if (p.Codigo == codigo)
                {
                    // Mostrar datos en los TextBox
                    txtNombre.Text = p.Nombre;
                    txtTipo.Text = p.Tipo;
                    txtValor.Text = p.Valor.ToString();
                    txtStock.Text = p.Stock.ToString();

                    // Guardamos el producto encontrado en Tag para modificarlo después
                    this.Tag = p;

                    return;
                }
            }

            MessageBox.Show("Producto no encontrado");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.Tag == null)
            {
                MessageBox.Show("Primero debe buscar un producto.");
                return;
            }

            //Confirmar modificación
            DialogResult r = MessageBox.Show(
            "¿Está seguro de guardar los cambios?",
            "Confirmar modificación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (r == DialogResult.No)
                return;

            //Modificar el producto con los nuevos datos
            Producto p = (Producto)this.Tag;

            p.Nombre = txtNombre.Text;
            p.Tipo = txtTipo.Text;
            p.Valor = int.Parse(txtValor.Text);
            p.Stock = int.Parse(txtStock.Text);

            MessageBox.Show("Producto modificado correctamente.");
            this.Close();

        }
    }
}

