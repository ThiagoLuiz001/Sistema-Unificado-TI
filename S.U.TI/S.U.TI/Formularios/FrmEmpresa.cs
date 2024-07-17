using System;
using S.U.TI.Model;
using S.U.TI.DAO;
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
        CompanyDAO company = new ();
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
            var empresa = new Company();
            var endereco = new CompanyAddress();
            empresa.Name = txtNome.Text;
            empresa.CorporateReason = txtRazao.Text;
            empresa.CNPJ = mskCNPJ.Text;
            empresa.Branch = txtAtividade.Text;
            empresa.Phone = mskContato.Text;
            endereco.CEP = mskCEP.Text;
            endereco.PublicPlace = txtLagradouro.Text;
            endereco.Neighborhood = txtBairro.Text;
            endereco.City = txtCidade.Text;
            endereco.Estate = cbUF.Text;
            endereco.Number = txtNum.Text;
            company.InsertCompany(empresa);
            int id = company.SelectId();
            endereco.CompanyId = id;
            company.InsertAddress(endereco);
            Novo();

        }
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }
    }
}
