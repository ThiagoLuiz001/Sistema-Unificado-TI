using S.U.TI.Formularios.Mapeamento.Computadores;

namespace S.U.TI
{
    public partial class FrmTela_Principal : Form
    {
        public FrmTela_Principal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmComputador computador = new FrmComputador();
            computador.MdiParent = this;
            computador.Show();
        }
    }
}
