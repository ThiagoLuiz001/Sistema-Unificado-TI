using ApicativoRelatorio.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.U.TI.Formularios.Operacional.Empresas
{
    public partial class FrmEmpresa : Form
    {
        private void Novo()
        {
            txtNome.Clear();
            txtRazao.Clear();
            mskCNPJ.Clear();
            txtAtividade.Clear();
            mskContato.Clear();
            mskCEP.Clear();
            txtLagradouro.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtNum.Clear();
            cbUF.Text = "";
        }
        private void Cadastrar()
        {
            ConexaoBanco conexao = new ConexaoBanco();
            ClassEmpresas empresa =new ClassEmpresas();
            empresa.Name= txtNome.Text;
            empresa.CorporationReason = txtRazao.Text;
            empresa.CNPJ = mskCNPJ.Text;
            empresa.Activite = txtAtividade.Text;
            empresa.Phone = mskContato.Text;
            empresa.CEP = mskCEP.Text;
            empresa.PublicPlace = txtLagradouro.Text;
            empresa.Neoghborhood = txtBairro.Text;
            empresa.City = txtCidade.Text;
            empresa.Estate = cbUF.Text;
            empresa.Number = int.Parse(txtNum.Text);
            
        }
        public FrmEmpresa()
        {
            InitializeComponent();
        }
    }
}
