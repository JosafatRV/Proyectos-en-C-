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
    public partial class FrmConsultarProducto : Form
    {
        List<Producto> lista;

        public FrmConsultarProducto(List<Producto> listaProductos)
        {
            InitializeComponent();
            lista = listaProductos;
        }

        public FrmConsultarProducto()
        {
            InitializeComponent();
        }

        private void FrmConsultarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarProducto_Click(object sender, EventArgs e)
        {
            int codigoBuscado = int.Parse(txtCodigo.Text);
            Producto encontrado = lista.Find(p => p.Codigo == codigoBuscado);
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

                txtDescripcion.Clear();
                txtTipo.Clear();
                txtPrecio.Clear();
                txtStock.Clear();
            }

        }
    }
}
