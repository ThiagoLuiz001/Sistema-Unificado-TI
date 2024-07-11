using S.U.TI.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.U.TI.Formularios.Mapeamento.Computadores
{
    public partial class FrmComputador : Form
    {
        ConexaoBanco conexao = new ConexaoBanco();
        private async void PuxarId()
        {
            int id = int.Parse(conexao.PegarId(0)) + 1;
            txtCodigo.Text = $"Pcm-{id}";
        }
        private void CadastrarDados()
        {
            string maquina;
            string[] ram = new string[4] {"N/A", "N/A", "N/A", "N/A"};
            string[] hd = new string[2] {"N/A", "N/A"};
            ClassComputador dados = new ClassComputador();
            hd = txtStorage.Text.Split(' ');
            ram= txtRAM.Text.Split(' ');
            if (rbDesktop.Checked)
            {
                maquina = rbDesktop.Text;
            }
            else if (rbNotebook.Checked)
            {
                maquina = rbNotebook.Text;
            }
            else
            {
                maquina = "Não Selecionado";
            } 
            dados._name =(txtNome.Text=="") ? "N/A" : txtNome.Text;
            dados._login =(txtLogin.Text =="") ? "N/A" : txtLogin.Text;
            dados._password =(txtSenha.Text=="") ? "N/A" : txtSenha.Text;
            dados._user =(txtUser.Text=="") ? "N/A" : txtUser.Text;
            dados._sector =(cbSetor.Text=="") ? "N/A" : cbSetor.Text;
            dados._operationSystem =(cbSO.Text=="") ? "N/A" : cbSO.Text;
            dados._ip =(mskIP.Text=="") ? "N/A" : mskIP.Text;
            dados._mask = (mskMascara.Text=="") ? "N/A" : mskMascara.Text;
            dados._gateway =(mskGateway.Text=="") ? "N/A" : mskGateway.Text;
            dados._dns1 = (mskDNS.Text=="") ? "N/A" : mskDNS.Text;
            dados._dns2 =(mskDNS2.Text =="") ? "N/A" :  mskDNS2.Text;
            dados._proxy =(txtProxy.Text=="") ? "N/A" : txtProxy.Text;
            dados._port = (txtPorta.Text == "") ? "N/A" : txtPorta.Text;
            dados._domain = (txtDominio.Text=="") ? "N/A" : txtDominio.Text;
            dados._anyDesk = (txtAnyDesk.Text=="") ? "N/A" : txtAnyDesk.Text;
            dados._mac =(txtMAC.Text=="") ? "N/A" : txtMAC.Text;
            dados._type = maquina;
            dados._cpu = (txtCPU.Text=="") ? "N/A" : txtCPU.Text;
            dados._socket = (txtSocket.Text =="") ? "N/A" : txtSocket.Text;
            dados._motherboard = (txtModBoard.Text=="") ? "N/A" : txtModBoard.Text;
            for(int i = 0; i <ram.Length; i++)
            {
                ram[i] = (ram[i] =="") ? "N/A" : ram[i];
            }
            dados._memory = ram[0];
            dados._ddr = ram[1];
            dados._frequency = ram[2];
            dados._slots = ram[3];
            dados._gpu = (txtGPU.Text=="") ? "N/A" : txtGPU.Text;
            for (int i = 0; i < hd.Length; i++)
            {
                hd[i] = (hd[i] == "") ? "N/A" : hd[i];
            }
            dados._disk = hd[0];
            dados._typedisk = hd[1];
            dados._diskUsed = (txtUsado.Text =="") ? "N/A" : txtUsado.Text;
            dados._offboard1 = (txtOff1.Text == "") ? "N/A" : txtOff1.Text;
            dados._offboard2 = (txtOff2.Text == "") ? "N/A" : txtOff2.Text;
            dados._register = (txtNumRegistro.Text=="") ? "N/A" : txtNumRegistro.Text;
            dados._observation = (rtxtOBS.Text=="") ? "..." : rtxtOBS.Text;
            conexao.SalvarMpComp(dados, DateTime.Parse(lblData.Text));
        }

        private void Tipo()
        {
            if (txtNome.Text != "")
            {

                lblMac.Visible = true;
                txtMAC.Visible = true;
                gbHardware.Visible = true;
            }
            else
            {
                lblMac.Visible = false;
                txtMAC.Visible = false;
                gbHardware.Visible = false;
            }
            if (rbNotebook.Checked)
            {
                lblModorBoard.Text = "Modelo:";
                txtOff1.Visible = false;
                txtOff2.Visible = false;
                lblOff1.Visible = false;
                lblOff2.Visible = false;
            }
            else
            {
                lblModorBoard.Text = "Placa Mãe:";
                txtOff1.Visible = true;
                txtOff2.Visible = true;
                lblOff1.Visible = true;
                lblOff2.Visible = true;
            }
        }
        private void Enderecamento()
        {
            txtCodigo.Text = conexao.PegarId(0);
        }
        private void Novo()
        {
            txtCodigo.Enabled = false;
            txtNome.Clear();
            txtNome.Focus();
            txtLogin.Clear();
            txtSenha.Clear();
            txtUser.Clear();
            mskIP.Clear();
            mskMascara.Clear();
            mskGateway.Clear();
            mskDNS.Clear();
            mskDNS2.Clear();
            txtProxy.Clear();
            txtPorta.Clear();
            txtDominio.Clear();
            txtAnyDesk.Clear();
            txtMAC.Clear();
            txtCPU.Clear();
            txtSocket.Clear();
            txtModBoard.Clear();
            txtRAM.Clear();
            txtGPU.Clear();
            txtStorage.Clear();
            txtUsado.Clear();
            txtOff1.Clear();
            txtOff2.Clear();
            txtNumRegistro.Clear();
            rtxtOBS.Clear();
            rbDesktop.Checked = false;
            rbNotebook.Checked = false;
            cbSetor.Text = "";
            cbSO.Text = "";
            lblModorBoard.Text = "Placa Mãe";
        }
        public FrmComputador()
        {
            InitializeComponent();

        }

        private void FrmComputador_Load(object sender, EventArgs e)
        {
            Novo();
            Tipo();
            timer1.Start();
            PuxarId();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void rbDesktop_CheckedChanged(object sender, EventArgs e)
        {
            Tipo();
        }

        private void rbNotebook_CheckedChanged(object sender, EventArgs e)
        {
            Tipo();
        }

        private void txtAnyDesk_TabIndexChanged(object sender, EventArgs e)
        {
            Tipo();
        }

        private void txtAnyDesk_TextChanged(object sender, EventArgs e)
        {
            Tipo();
        }

        private void txtAnyDesk_TabIndexChanged_1(object sender, EventArgs e)
        {
            Tipo();
        }

        private void txtAnyDesk_Leave(object sender, EventArgs e)
        {
            Tipo();
        }

        private void txtDominio_Leave(object sender, EventArgs e)
        {
            Tipo();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
            Tipo();
        }

        private void btnolhar_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0';
                btnolhar.BackgroundImage = Properties.Resources.olhoabre;
            }
            else
            {
                txtSenha.PasswordChar = '*';
                btnolhar.BackgroundImage = Properties.Resources.olhoafecha;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarDados();
            Novo();
        }
    }
}
