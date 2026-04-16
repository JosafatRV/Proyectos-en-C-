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

namespace AppProductosRojas
{
    public partial class FrmModificarProducto : Form
    {
        public FrmModificarProducto()
        {
            InitializeComponent();
        }
        
        List<Producto> lista;
        Producto encontrado;

        public FrmModificarProducto(List<Producto> listaProductos)
        {
            InitializeComponent();
            lista = listaProductos;
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
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
            encontrado.Descripcion = txtDescripcion.Text;
            encontrado.Tipo = txtTipo.Text;
            encontrado.Precio = int.Parse(txtPrecio.Text);
            encontrado.Stock = int.Parse(txtStock.Text);

            MessageBox.Show("Producto modificado correctamente");

        }
    }
}
