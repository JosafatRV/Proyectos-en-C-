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
    public partial class FrmEliminar : Form
    {
        public FrmEliminar()
        {
            InitializeComponent();
        }

        private void FrmEliminar_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);

            ArrayList Lista = ((MenuPrincipal)Owner).Lista;

            foreach (Producto p in Lista)
            {
                if (p.Codigo == codigo)
                {
                    lblNombre.Text = p.Nombre;
                    lblTipo.Text = p.Tipo;
                    lblValor.Text = p.Valor.ToString();
                    lblStock.Text = p.Stock.ToString();

                    // Guardamos el producto encontrado para eliminarlo después
                    this.Tag = p;

                    return;
                }
            }

            MessageBox.Show("Producto no encontrado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.Tag == null)
            {
                MessageBox.Show("Debe buscar un producto primero.");
                return;
            }

            // Confirmar eliminación
            DialogResult r = MessageBox.Show(
            "¿Está seguro de eliminar este producto?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );

            if (r == DialogResult.No)
                return;

            // Eliminar el producto de la lista
            Producto p = (Producto)this.Tag;

            ArrayList Lista = ((MenuPrincipal)Owner).Lista;

            Lista.Remove(p);

            MessageBox.Show("Producto eliminado correctamente.");
            this.Close();

        }
    }
}

