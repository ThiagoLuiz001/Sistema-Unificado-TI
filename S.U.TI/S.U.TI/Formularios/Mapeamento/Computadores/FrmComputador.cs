using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.U.TI.Formularios.Mapeamento.Computadores
{
    public partial class FrmComputador : Form
    {
        private void Novo()
        {
            DateTime data = DateTime.Now;
            lblData.Text = data.ToString();
            txtNome.Clear();
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


        }
    }
