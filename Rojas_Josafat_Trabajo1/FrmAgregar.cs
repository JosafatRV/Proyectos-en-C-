using System;
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
    public partial class FrmAgregar : Form
    {
        public FrmAgregar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Confirmación
            DialogResult r = MessageBox.Show(
                "¿Está seguro de agregar este producto?",
                "Confirmar agregado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.No)
                return;

            // Crear producto
            int codigo = int.Parse(txtCodigo.Text);
            string nombre = txtNombre.Text;
            string tipo = txtTipo.Text;
            int valor = int.Parse(txtValor.Text);
            int existencia = int.Parse(txtStock.Text);

            Producto p = new Producto(codigo, nombre, tipo, valor, existencia);

            ((MenuPrincipal)Owner).Lista.Add(p);

            MessageBox.Show("Producto agregado correctamente");
            this.Close();



        }
    }
}
