namespace ProjWFDotNet23_05_2022
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void usu�rioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();

        }

        private void usu�rioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes frmClientes = new FrmConsultaClientes();
            frmClientes.MdiParent = this;
            frmClientes.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void im�velToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImovel frmImovel = new FrmImovel();
            frmImovel.MdiParent = this;
            frmImovel.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void im�velToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaImovel frmImovel = new FrmConsultaImovel();
            frmImovel.MdiParent = this;
            frmImovel.Show();
        }

        private void im�veisAlugadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaLocacao frmLocacao = new FrmConsultaLocacao();
            frmLocacao.MdiParent = this;
            frmLocacao.Show();
        }

        private void im�velToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmLocacao frmLocacao = new FrmLocacao();
            frmLocacao.MdiParent = this;
            frmLocacao.Show();

        }
    }
}