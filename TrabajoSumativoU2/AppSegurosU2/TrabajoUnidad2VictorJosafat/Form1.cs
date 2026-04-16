namespace TrabajoUnidad2VictorJosafat
{
    using System.Collections;

    public partial class Form1 : Form
    {
        // Listas dinámicas
        private ArrayList listaClientes = new ArrayList();
        private ArrayList listaPolizas = new ArrayList();
        private ArrayList listaContratos = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente ventana = new FrmAgregarCliente(listaClientes);
            ventana.ShowDialog();
        }
        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarCliente ventana = new FrmModificarCliente(listaClientes);
            ventana.ShowDialog();
        }
        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarCliente ventana = new FrmConsultarCliente(listaClientes, listaContratos);
            ventana.ShowDialog();
        }
        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarCliente ventana = new FrmEliminarCliente(listaClientes, listaContratos);
            ventana.ShowDialog();
        }
        private void agregarPolizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarPoliza ventana = new FrmAgregarPoliza(listaPolizas);
            ventana.ShowDialog();
        }

        private void modificarPolizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarPoliza ventana = new FrmModificarPoliza(listaPolizas);
            ventana.ShowDialog();
        }

        private void listarPolizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarPoliza ventana = new FrmListarPoliza(listaPolizas);
            ventana.ShowDialog();
        }
        private void eliminarPolizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarPoliza ventana = new FrmEliminarPoliza(listaPolizas, listaContratos);
            ventana.ShowDialog();
        }
    }
}
