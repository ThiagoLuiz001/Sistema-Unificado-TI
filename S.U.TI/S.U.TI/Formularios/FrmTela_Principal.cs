using S.U.TI.Formularios.Mapeamento.Computadores;
using S.U.TI.Formularios.Operacional.Empresas;
using S.U.TI.Formularios.Operacional.Setores;

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

        private void cadastrarSetoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSetor setor = new FrmSetor();
            setor.MdiParent = this;
            setor.Show();
        }

        private void cadastrarEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresa empresa = new FrmEmpresa();
            empresa.MdiParent = this;
            empresa.Show();
        }
    }
}
