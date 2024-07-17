
using S.U.TI.Model;
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
        HardwareDAO hardwareDAO = new ();
        ComputerInfoDAO computerDAO = new();
        SystemDAO systemDAO = new ();
        List<Model.System> lista = new List<Model.System>();
        List<Department> depart = new List<Department>();

        private async void PuxarId()
        {
            int id = hardwareDAO.SelectId() + 1;
            txtCodigo.Text = $"Pcm-{id}";
            lista = systemDAO.Select();
            for (int i = 0; i < lista.Count; i++)
            {
                cbSO.Items.Add(lista[i].Name);
            }
            //Fazer o For para departamento
        }

        private void CadastrarDados()
        {
            string maquina;
            string[] ram = new string[4] {"N/A", "N/A", "N/A", "N/A"};
            string[] hd = new string[2] {"N/A", "N/A"};
            var system = new ComputerMapping();
            var hardware = new Hardware();
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
            system.Name =(txtNome.Text=="") ? "N/A" : txtNome.Text;
            system.Login =(txtLogin.Text =="") ? "N/A" : txtLogin.Text;
            system.Password =(txtSenha.Text=="") ? "N/A" : txtSenha.Text;
            system.User =(txtUser.Text=="") ? "N/A" : txtUser.Text;
            int index1 = cbSetor.TabIndex;
            hardware.Department.Id = index1;
            

            int index2 = cbSO.TabIndex;
            system.SystemOperational.Id = lista[index2].Id;
            system.Ip =(mskIP.Text=="") ? "000.000.000.000" : mskIP.Text;
            system.Mask = (mskMascara.Text=="") ? "000.000.000.000" : mskMascara.Text;
            system.Gateway =(mskGateway.Text=="") ? "000.000.000.000" : mskGateway.Text;
            system.DNS1 = (mskDNS.Text=="") ? "000.000.000.000" : mskDNS.Text;
            system.DNS2 =(mskDNS2.Text =="") ? "000.000.000.000" :  mskDNS2.Text;
            system.Proxy =(txtProxy.Text=="") ? "N/A" : txtProxy.Text;
            system.Port = (txtPorta.Text == "") ? "N/A" : txtPorta.Text;
            system.Domain = (txtDominio.Text=="") ? "N/A" : txtDominio.Text;
            system.AnyDesk = (txtAnyDesk.Text=="") ? "N/A" : txtAnyDesk.Text;
            hardware.MAC =(txtMAC.Text=="") ? "N/A" : txtMAC.Text;
            hardware.Platform = maquina;
            hardware.CPU = (txtCPU.Text=="") ? "N/A" : txtCPU.Text;
            hardware.Socket = (txtSocket.Text =="") ? "N/A" : txtSocket.Text;
            hardware.MotherBoard = (txtModBoard.Text=="") ? "N/A" : txtModBoard.Text;
            for(int i = 0; i <ram.Length; i++)
            {
                ram[i] = (ram[i] =="") ? "N/A" : ram[i];
            }
            hardware.Memory = ram[0];
            hardware.DDR = ram[1];
            hardware.Frequency = ram[2];
            hardware.Slots = ram[3];
            hardware.GPU = (txtGPU.Text=="") ? "N/A" : txtGPU.Text;
            for (int i = 0; i < hd.Length; i++)
            {
                hd[i] = (hd[i] == "") ? "N/A" : hd[i];
            }
            hardware.Disk = hd[0];
            hardware.DiskType = hd[1];
            hardware.DiskUsed = (txtUsado.Text =="") ? "N/A" : txtUsado.Text;
            hardware.OffBoard1 = (txtOff1.Text == "") ? "N/A" : txtOff1.Text;
            hardware.OffBoard2 = (txtOff2.Text == "") ? "N/A" : txtOff2.Text;
            hardware.RegistrationNumber = (txtNumRegistro.Text=="") ? "N/A" : txtNumRegistro.Text;
            hardware.Notes = (rtxtOBS.Text=="") ? "..." : rtxtOBS.Text;
            hardwareDAO.Insert(hardware, DateTime.Parse(lblData.Text));
            computerDAO.Insert(system, DateTime.Parse(lblData.Text));
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
