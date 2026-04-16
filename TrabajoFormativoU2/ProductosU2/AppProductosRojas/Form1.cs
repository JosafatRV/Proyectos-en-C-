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
    public partial class Form1 : Form
    {
        List<Producto> listaProductos = new List<Producto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto f = new FrmAgregarProducto(listaProductos);
            f.Show();
        }
        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarProducto f = new FrmConsultarProducto(listaProductos);
            f.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarProducto f = new FrmModificarProducto(listaProductos);
            f.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarProducto f = new FrmEliminarProducto(listaProductos);
            f.Show();
        }
        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarProductos f = new FrmListarProductos(listaProductos);
            f.Show();
        }

        private void generarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenerarVenta f = new FrmGenerarVenta(listaProductos);
            f.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
            "¿Desea salir de la aplicación?",
            "Confirmar salida",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
