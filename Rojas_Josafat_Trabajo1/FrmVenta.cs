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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
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

                    // Guardamos el producto encontrado
                    this.Tag = p;

                    return;
                }
            }

            MessageBox.Show("Producto no encontrado");

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (this.Tag == null)
            {
                MessageBox.Show("Debe buscar un producto primero.");
                return;
            }

            Producto p = (Producto)this.Tag;

            int cantidad = int.Parse(txtCantidad.Text);

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.");
                return;
            }

            if (cantidad > p.Stock)
            {
                MessageBox.Show("Stock insuficiente.");
                return;
            }

            // Confirmación antes de realizar la venta
            DialogResult r = MessageBox.Show(
                "¿Está seguro de realizar la venta?\nEl stock vendido será descontado.",
                "Confirmar venta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (r == DialogResult.No)
                return;

            // Calcular total de Venta
            int total = cantidad * p.Valor;
            lblTotal.Text = total.ToString();

            // Descontar stock del producto
            p.Stock -= cantidad;

            MessageBox.Show("Venta realizada correctamente.");
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
