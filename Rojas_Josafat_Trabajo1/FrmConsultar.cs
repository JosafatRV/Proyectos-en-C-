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
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.TopMost = true;
            this.TopMost = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            ArrayList Lista = ((MenuPrincipal)Owner).Lista;

            foreach (Producto p in Lista)
            {
                if (p.Codigo == codigo)
                {
                    lblNombre.Text = p.Nombre;
                    lblTipo.Text = p.Tipo;
                    lblValor.Text = p.Valor.ToString();
                    lblStock.Text = p.Stock.ToString();
                    return;
                }
            }

            MessageBox.Show("Producto no encontrado");
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            
        }
    }
}

