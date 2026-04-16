using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Rojas_Josafat_Trabajo1
{
    public partial class MenuPrincipal : Form
    {
        public ArrayList Lista = new ArrayList();



        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminar frm = new FrmEliminar();
            frm.Owner = this;
            frm.ShowDialog();

        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregar frmAgregar = new FrmAgregar();
            frmAgregar.Owner = this;
            frmAgregar.ShowDialog();

        }
        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar frmConsultar = new FrmConsultar();
            frmConsultar.Owner = this;
            frmConsultar.ShowDialog();

        }
        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificar frmModificar = new FrmModificar();
            frmModificar.Owner = this;
            frmModificar.ShowDialog();
        }
        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListar frm = new FrmListar();
            frm.Owner = this;
            frm.ShowDialog();
        }
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenta frm = new FrmVenta();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
            "¿Seguro que desea salir?",
            "Confirmar salida",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
    );

            if (r == DialogResult.Yes)
            {
                MessageBox.Show("Cerrando aplicación...", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
    }
  }
}