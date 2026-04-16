using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProductosRojas
{
    public partial class FrmGenerarVenta : Form
    {
        List<Producto> lista;
        Producto encontrado;

        public FrmGenerarVenta(List<Producto> listaProductos)
        {
            InitializeComponent();
            lista = listaProductos;
        }

        public FrmGenerarVenta()
        {
            InitializeComponent();
        }

        private void FrmGenerarVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            int codigoBuscado = int.Parse(txtCodigo.Text);
            encontrado = lista.Find(p => p.Codigo == codigoBuscado);

            if (encontrado != null)
            {
                txtDescripcion.Text = encontrado.Descripcion;
                txtTipo.Text = encontrado.Tipo;
                txtPrecio.Text = encontrado.Precio.ToString();
                txtStock.Text = encontrado.Stock.ToString();
            }
            else
            {
                MessageBox.Show("El producto no existe");
            }
        }

        private void btnVenderProducto_Click(object sender, EventArgs e)
        {
            if (encontrado == null)
            {
                MessageBox.Show("Debe buscar un producto primero");
                return;
            }

            int cantidad = int.Parse(txtVenta.Text);

            if (cantidad > encontrado.Stock)
            {
                MessageBox.Show("Stock insuficiente");
                return;
            }

            // Calcular total
            int total = encontrado.Precio * cantidad;
            txtTotalVenta.Text = total.ToString();

            // Restar stock
            encontrado.Stock -= cantidad;

            // Actualizar stock en pantalla
            txtStock.Text = encontrado.Stock.ToString();

            MessageBox.Show("Venta realizada correctamente");


        }
    }
}
