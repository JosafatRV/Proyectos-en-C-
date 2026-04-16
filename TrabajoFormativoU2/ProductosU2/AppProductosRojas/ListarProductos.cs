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
    public partial class FrmListarProductos : Form
    {
        List<Producto> lista;

        public FrmListarProductos(List<Producto> listaProductos)
        {
            InitializeComponent();
            lista = listaProductos;
        }
        public FrmListarProductos()
        {
            InitializeComponent();
        }

        private void FrmListarProductos_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = lista;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ReadOnly = true;
            dgvProductos.AllowUserToAddRows = false;

        }
    }
}
