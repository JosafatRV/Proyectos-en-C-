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
    public partial class FrmAgregarProducto : Form
    {
        public FrmAgregarProducto()
        {
            InitializeComponent();
        }
        
        List<Producto> lista;
        public FrmAgregarProducto(List<Producto> listaProductos)
        {
            InitializeComponent();
            lista = listaProductos;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            string descripcion = txtDescripcion.Text;
            string tipo = txtTipo.Text;
            int precio = int.Parse(txtPrecio.Text);
            int stock = int.Parse(txtStock.Text);


            Producto p = new Producto(codigo, descripcion, tipo, precio, stock);
            lista.Add(p);
            MessageBox.Show("Producto agregado correctamente");
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtTipo.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtCodigo.Focus();


        }
    }
}
