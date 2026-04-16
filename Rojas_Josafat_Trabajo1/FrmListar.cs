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
    public partial class FrmListar : Form
    {
        public FrmListar()
        {
            InitializeComponent();
        }

        private void FrmListar_Load(object sender, EventArgs e)
        {
            // Obtener la lista desde el formulario principal
            ArrayList Lista = ((MenuPrincipal)Owner).Lista;

            // Limpiar el DataGridView por si se abre más de una vez
            dgvListado.Rows.Clear();

            // Recorrer los productos y agregarlos al DataGridView
            foreach (Producto p in Lista)
            {
                dgvListado.Rows.Add(
                    p.Codigo,
                    p.Nombre,
                    p.Tipo,
                    p.Valor,
                    p.Stock
                );
            }
        }
    }
}







