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
    public partial class FrmEliminarProducto : Form
    {
        List<Producto> lista;
        Producto encontrado;

        public FrmEliminarProducto(List<Producto> listaProductos)
        {
            InitializeComponent();
            lista = listaProductos;
        }

        public FrmEliminarProducto()
        {
            InitializeComponent();
        }

        private void FrmEliminarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarProductoElim_Click(object sender, EventArgs e)
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

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (encontrado != null)
            {
                lista.Remove(encontrado);
                MessageBox.Show("Producto eliminado correctamente");

                txtDescripcion.Clear();
                txtTipo.Clear();
                txtPrecio.Clear();
                txtStock.Clear();
            }
            else
            {
                MessageBox.Show("Primero debe buscar un producto válido");
            }

        }
    }
}

