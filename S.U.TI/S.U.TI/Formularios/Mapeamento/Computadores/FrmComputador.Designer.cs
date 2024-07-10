namespace S.U.TI.Formularios.Mapeamento.Computadores
{
    partial class FrmComputador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtCodigo = new TextBox();
            groupBox1 = new GroupBox();
            btnNovo = new Button();
            btnCadastrar = new Button();
            groupBox4 = new GroupBox();
            rtxtOBS = new RichTextBox();
            gbSistema = new GroupBox();
            btnolhar = new Button();
            label18 = new Label();
            txtAnyDesk = new TextBox();
            txtDominio = new TextBox();
            txtPorta = new TextBox();
            txtProxy = new TextBox();
            mskDNS2 = new MaskedTextBox();
            mskDNS = new MaskedTextBox();
            mskGateway = new MaskedTextBox();
            mskMascara = new MaskedTextBox();
            label17 = new Label();
            mskIP = new MaskedTextBox();
            cbSO = new ComboBox();
            cbSetor = new ComboBox();
            txtUser = new TextBox();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lblData = new Label();
            gbHardware = new GroupBox();
            txtNumRegistro = new TextBox();
            label28 = new Label();
            lblOff2 = new Label();
            txtOff2 = new TextBox();
            txtOff1 = new TextBox();
            txtUsado = new TextBox();
            txtStorage = new TextBox();
            txtGPU = new TextBox();
            txtRAM = new TextBox();
            txtModBoard = new TextBox();
            txtSocket = new TextBox();
            txtCPU = new TextBox();
            lblOff1 = new Label();
            label25 = new Label();
            label21 = new Label();
            lblModorBoard = new Label();
            label23 = new Label();
            label22 = new Label();
            label20 = new Label();
            label19 = new Label();
            rbDesktop = new RadioButton();
            rbNotebook = new RadioButton();
            txtMAC = new TextBox();
            label4 = new Label();
            txtNome = new TextBox();
            lblMac = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            gbSistema.SuspendLayout();
            gbHardware.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(67, 6);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(93, 23);
            txtCodigo.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNovo);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(gbSistema);
            groupBox1.Controls.Add(lblData);
            groupBox1.Controls.Add(gbHardware);
            groupBox1.Controls.Add(txtMAC);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(lblMac);
            groupBox1.Location = new Point(5, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(696, 510);
            groupBox1.TabIndex = 81;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados da Maquina:";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(13, 454);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 44);
            btnNovo.TabIndex = 31;
            btnNovo.Text = "&Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(583, 454);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 44);
            btnCadastrar.TabIndex = 30;
            btnCadastrar.Text = "&Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rtxtOBS);
            groupBox4.Location = new Point(7, 348);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(676, 100);
            groupBox4.TabIndex = 29;
            groupBox4.TabStop = false;
            groupBox4.Text = "OBSERVAÇÕES:";
            // 
            // rtxtOBS
            // 
            rtxtOBS.Location = new Point(6, 22);
            rtxtOBS.Name = "rtxtOBS";
            rtxtOBS.Size = new Size(664, 72);
            rtxtOBS.TabIndex = 29;
            rtxtOBS.Text = "";
            // 
            // gbSistema
            // 
            gbSistema.Controls.Add(btnolhar);
            gbSistema.Controls.Add(label18);
            gbSistema.Controls.Add(txtAnyDesk);
            gbSistema.Controls.Add(txtDominio);
            gbSistema.Controls.Add(txtPorta);
            gbSistema.Controls.Add(txtProxy);
            gbSistema.Controls.Add(mskDNS2);
            gbSistema.Controls.Add(mskDNS);
            gbSistema.Controls.Add(mskGateway);
            gbSistema.Controls.Add(mskMascara);
            gbSistema.Controls.Add(label17);
            gbSistema.Controls.Add(mskIP);
            gbSistema.Controls.Add(cbSO);
            gbSistema.Controls.Add(cbSetor);
            gbSistema.Controls.Add(txtUser);
            gbSistema.Controls.Add(txtSenha);
            gbSistema.Controls.Add(txtLogin);
            gbSistema.Controls.Add(label16);
            gbSistema.Controls.Add(label15);
            gbSistema.Controls.Add(label14);
            gbSistema.Controls.Add(label13);
            gbSistema.Controls.Add(label12);
            gbSistema.Controls.Add(label11);
            gbSistema.Controls.Add(label10);
            gbSistema.Controls.Add(label9);
            gbSistema.Controls.Add(label8);
            gbSistema.Controls.Add(label7);
            gbSistema.Controls.Add(label6);
            gbSistema.Controls.Add(label5);
            gbSistema.Location = new Point(7, 51);
            gbSistema.Name = "gbSistema";
            gbSistema.Size = new Size(335, 291);
            gbSistema.TabIndex = 2;
            gbSistema.TabStop = false;
            gbSistema.Text = "Informações do Sistema:";
            // 
            // btnolhar
            // 
            btnolhar.BackgroundImage = Properties.Resources.olhoafecha;
            btnolhar.BackgroundImageLayout = ImageLayout.Stretch;
            btnolhar.Location = new Point(301, 0);
            btnolhar.Name = "btnolhar";
            btnolhar.Size = new Size(26, 23);
            btnolhar.TabIndex = 32;
            btnolhar.UseVisualStyleBackColor = true;
            btnolhar.Click += btnolhar_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 234);
            label18.Name = "label18";
            label18.Size = new Size(56, 15);
            label18.TabIndex = 27;
            label18.Text = "AnyDesk:";
            // 
            // txtAnyDesk
            // 
            txtAnyDesk.Location = new Point(68, 231);
            txtAnyDesk.Name = "txtAnyDesk";
            txtAnyDesk.Size = new Size(141, 23);
            txtAnyDesk.TabIndex = 15;
            txtAnyDesk.Tag = "";
            // 
            // txtDominio
            // 
            txtDominio.Location = new Point(68, 202);
            txtDominio.Name = "txtDominio";
            txtDominio.Size = new Size(259, 23);
            txtDominio.TabIndex = 14;
            txtDominio.Tag = "";
            txtDominio.Leave += txtDominio_Leave;
            // 
            // txtPorta
            // 
            txtPorta.Location = new Point(270, 173);
            txtPorta.Name = "txtPorta";
            txtPorta.Size = new Size(57, 23);
            txtPorta.TabIndex = 13;
            txtPorta.Tag = "";
            // 
            // txtProxy
            // 
            txtProxy.Location = new Point(62, 173);
            txtProxy.Name = "txtProxy";
            txtProxy.Size = new Size(158, 23);
            txtProxy.TabIndex = 12;
            txtProxy.Tag = "";
            // 
            // mskDNS2
            // 
            mskDNS2.Location = new Point(245, 144);
            mskDNS2.Mask = "000,000,000,000";
            mskDNS2.Name = "mskDNS2";
            mskDNS2.Size = new Size(82, 23);
            mskDNS2.TabIndex = 11;
            // 
            // mskDNS
            // 
            mskDNS.Location = new Point(62, 144);
            mskDNS.Mask = "000,000,000,000";
            mskDNS.Name = "mskDNS";
            mskDNS.Size = new Size(80, 23);
            mskDNS.TabIndex = 10;
            // 
            // mskGateway
            // 
            mskGateway.Location = new Point(245, 115);
            mskGateway.Mask = "000,000,000,000";
            mskGateway.Name = "mskGateway";
            mskGateway.Size = new Size(82, 23);
            mskGateway.TabIndex = 9;
            // 
            // mskMascara
            // 
            mskMascara.Location = new Point(63, 115);
            mskMascara.Mask = "000,000,000,000";
            mskMascara.Name = "mskMascara";
            mskMascara.Size = new Size(79, 23);
            mskMascara.TabIndex = 8;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 118);
            label17.Name = "label17";
            label17.Size = new Size(54, 15);
            label17.TabIndex = 18;
            label17.Text = "Mascara:";
            // 
            // mskIP
            // 
            mskIP.Location = new Point(246, 84);
            mskIP.Mask = "000,000,000,000";
            mskIP.Name = "mskIP";
            mskIP.Size = new Size(81, 23);
            mskIP.TabIndex = 7;
            // 
            // cbSO
            // 
            cbSO.FormattingEnabled = true;
            cbSO.ItemHeight = 15;
            cbSO.Location = new Point(37, 86);
            cbSO.Name = "cbSO";
            cbSO.Size = new Size(126, 23);
            cbSO.TabIndex = 6;
            // 
            // cbSetor
            // 
            cbSetor.FormattingEnabled = true;
            cbSetor.ItemHeight = 15;
            cbSetor.Location = new Point(212, 57);
            cbSetor.Name = "cbSetor";
            cbSetor.Size = new Size(115, 23);
            cbSetor.TabIndex = 5;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(56, 57);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(107, 23);
            txtUser.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(212, 28);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(115, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(48, 28);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(115, 23);
            txtLogin.TabIndex = 2;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(226, 177);
            label16.Name = "label16";
            label16.Size = new Size(38, 15);
            label16.TabIndex = 11;
            label16.Text = "Porta:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 177);
            label15.Name = "label15";
            label15.Size = new Size(40, 15);
            label15.TabIndex = 10;
            label15.Text = "Proxy:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 205);
            label14.Name = "label14";
            label14.Size = new Size(56, 15);
            label14.TabIndex = 9;
            label14.Text = "Dominio:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(178, 144);
            label13.Name = "label13";
            label13.Size = new Size(42, 15);
            label13.TabIndex = 8;
            label13.Text = "DNS 2:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(169, 118);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 7;
            label12.Text = "Gateway:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 147);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 6;
            label11.Text = "DNS:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(186, 89);
            label10.Name = "label10";
            label10.Size = new Size(20, 15);
            label10.TabIndex = 5;
            label10.Text = "IP:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 92);
            label9.Name = "label9";
            label9.Size = new Size(25, 15);
            label9.TabIndex = 4;
            label9.Text = "SO:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(169, 57);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 3;
            label8.Text = "Setor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 60);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 2;
            label7.Text = "Usuario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 31);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 1;
            label6.Text = "Senha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 31);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 0;
            label5.Text = "Login:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(572, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(43, 15);
            lblData.TabIndex = 3;
            lblData.Text = "(DATA)";
            // 
            // gbHardware
            // 
            gbHardware.Controls.Add(txtNumRegistro);
            gbHardware.Controls.Add(label28);
            gbHardware.Controls.Add(lblOff2);
            gbHardware.Controls.Add(txtOff2);
            gbHardware.Controls.Add(txtOff1);
            gbHardware.Controls.Add(txtUsado);
            gbHardware.Controls.Add(txtStorage);
            gbHardware.Controls.Add(txtGPU);
            gbHardware.Controls.Add(txtRAM);
            gbHardware.Controls.Add(txtModBoard);
            gbHardware.Controls.Add(txtSocket);
            gbHardware.Controls.Add(txtCPU);
            gbHardware.Controls.Add(lblOff1);
            gbHardware.Controls.Add(label25);
            gbHardware.Controls.Add(label21);
            gbHardware.Controls.Add(lblModorBoard);
            gbHardware.Controls.Add(label23);
            gbHardware.Controls.Add(label22);
            gbHardware.Controls.Add(label20);
            gbHardware.Controls.Add(label19);
            gbHardware.Controls.Add(rbDesktop);
            gbHardware.Controls.Add(rbNotebook);
            gbHardware.Location = new Point(348, 51);
            gbHardware.Name = "gbHardware";
            gbHardware.Size = new Size(335, 291);
            gbHardware.TabIndex = 17;
            gbHardware.TabStop = false;
            gbHardware.Text = "Informações do Hardware:";
            // 
            // txtNumRegistro
            // 
            txtNumRegistro.Location = new Point(98, 215);
            txtNumRegistro.Name = "txtNumRegistro";
            txtNumRegistro.Size = new Size(231, 23);
            txtNumRegistro.TabIndex = 28;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(6, 218);
            label28.Name = "label28";
            label28.Size = new Size(86, 15);
            label28.TabIndex = 20;
            label28.Text = "N° de Registro:";
            // 
            // lblOff2
            // 
            lblOff2.AutoSize = true;
            lblOff2.Location = new Point(6, 179);
            lblOff2.Name = "lblOff2";
            lblOff2.Size = new Size(67, 15);
            lblOff2.TabIndex = 19;
            lblOff2.Text = "Offboard 2:";
            // 
            // txtOff2
            // 
            txtOff2.Location = new Point(79, 174);
            txtOff2.Name = "txtOff2";
            txtOff2.Size = new Size(165, 23);
            txtOff2.TabIndex = 27;
            // 
            // txtOff1
            // 
            txtOff1.Location = new Point(79, 144);
            txtOff1.Name = "txtOff1";
            txtOff1.Size = new Size(165, 23);
            txtOff1.TabIndex = 26;
            // 
            // txtUsado
            // 
            txtUsado.Location = new Point(250, 115);
            txtUsado.Name = "txtUsado";
            txtUsado.Size = new Size(79, 23);
            txtUsado.TabIndex = 25;
            // 
            // txtStorage
            // 
            txtStorage.Location = new Point(62, 115);
            txtStorage.Name = "txtStorage";
            txtStorage.PlaceholderText = "XGB HD or SSD";
            txtStorage.Size = new Size(133, 23);
            txtStorage.TabIndex = 24;
            // 
            // txtGPU
            // 
            txtGPU.Location = new Point(201, 86);
            txtGPU.Name = "txtGPU";
            txtGPU.Size = new Size(128, 23);
            txtGPU.TabIndex = 23;
            // 
            // txtRAM
            // 
            txtRAM.Location = new Point(45, 86);
            txtRAM.Name = "txtRAM";
            txtRAM.PlaceholderText = "XGB DDRX XMhz Duo";
            txtRAM.Size = new Size(111, 23);
            txtRAM.TabIndex = 22;
            // 
            // txtModBoard
            // 
            txtModBoard.Location = new Point(76, 54);
            txtModBoard.Name = "txtModBoard";
            txtModBoard.Size = new Size(253, 23);
            txtModBoard.TabIndex = 21;
            // 
            // txtSocket
            // 
            txtSocket.Location = new Point(213, 22);
            txtSocket.Name = "txtSocket";
            txtSocket.PlaceholderText = "LGAXXX";
            txtSocket.Size = new Size(116, 23);
            txtSocket.TabIndex = 20;
            // 
            // txtCPU
            // 
            txtCPU.Location = new Point(45, 22);
            txtCPU.Name = "txtCPU";
            txtCPU.Size = new Size(111, 23);
            txtCPU.TabIndex = 19;
            // 
            // lblOff1
            // 
            lblOff1.AutoSize = true;
            lblOff1.Location = new Point(6, 147);
            lblOff1.Name = "lblOff1";
            lblOff1.Size = new Size(67, 15);
            lblOff1.TabIndex = 9;
            lblOff1.Text = "Offboard 1:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(201, 118);
            label25.Name = "label25";
            label25.Size = new Size(43, 15);
            label25.TabIndex = 8;
            label25.Text = "Usado:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(162, 25);
            label21.Name = "label21";
            label21.Size = new Size(45, 15);
            label21.TabIndex = 7;
            label21.Text = "Socket:";
            // 
            // lblModorBoard
            // 
            lblModorBoard.AutoSize = true;
            lblModorBoard.Location = new Point(6, 57);
            lblModorBoard.Name = "lblModorBoard";
            lblModorBoard.Size = new Size(64, 15);
            lblModorBoard.TabIndex = 6;
            lblModorBoard.Text = "Placa Mãe:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(6, 118);
            label23.Name = "label23";
            label23.Size = new Size(39, 15);
            label23.TabIndex = 5;
            label23.Text = "Disco:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 92);
            label22.Name = "label22";
            label22.Size = new Size(36, 15);
            label22.TabIndex = 4;
            label22.Text = "RAM:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(162, 92);
            label20.Name = "label20";
            label20.Size = new Size(33, 15);
            label20.TabIndex = 2;
            label20.Text = "GPU:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 25);
            label19.Name = "label19";
            label19.Size = new Size(33, 15);
            label19.TabIndex = 0;
            label19.Text = "CPU:";
            // 
            // rbDesktop
            // 
            rbDesktop.AutoSize = true;
            rbDesktop.Location = new Point(161, 0);
            rbDesktop.Name = "rbDesktop";
            rbDesktop.Size = new Size(68, 19);
            rbDesktop.TabIndex = 17;
            rbDesktop.TabStop = true;
            rbDesktop.Text = "Desktop";
            rbDesktop.UseVisualStyleBackColor = true;
            rbDesktop.CheckedChanged += rbDesktop_CheckedChanged;
            // 
            // rbNotebook
            // 
            rbNotebook.AutoSize = true;
            rbNotebook.Location = new Point(235, 0);
            rbNotebook.Name = "rbNotebook";
            rbNotebook.Size = new Size(78, 19);
            rbNotebook.TabIndex = 18;
            rbNotebook.TabStop = true;
            rbNotebook.Text = "Notebook";
            rbNotebook.UseVisualStyleBackColor = true;
            rbNotebook.CheckedChanged += rbNotebook_CheckedChanged;
            // 
            // txtMAC
            // 
            txtMAC.Location = new Point(408, 22);
            txtMAC.Name = "txtMAC";
            txtMAC.Size = new Size(158, 23);
            txtMAC.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 25);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 2;
            label4.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(62, 22);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(158, 23);
            txtNome.TabIndex = 1;
            // 
            // lblMac
            // 
            lblMac.AutoSize = true;
            lblMac.Location = new Point(348, 25);
            lblMac.Name = "lblMac";
            lblMac.Size = new Size(60, 15);
            lblMac.TabIndex = 0;
            lblMac.Text = "End MAC:";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FrmComputador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 549);
            Controls.Add(groupBox1);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Name = "FrmComputador";
            Text = "FrmCadastro_Computador";
            Load += FrmComputador_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            gbSistema.ResumeLayout(false);
            gbSistema.PerformLayout();
            gbHardware.ResumeLayout(false);
            gbHardware.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private GroupBox groupBox1;
        private TextBox txtNome;
        private Label lblMac;
        private RadioButton rbDesktop;
        private RadioButton rbNotebook;
        private Label label4;
        private Label lblData;
        private GroupBox gbHardware;
        private GroupBox gbSistema;
        private TextBox txtMAC;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtUser;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label label16;
        private Label label15;
        private MaskedTextBox mskIP;
        private ComboBox cbSO;
        private ComboBox cbSetor;
        private MaskedTextBox mskDNS;
        private MaskedTextBox mskGateway;
        private MaskedTextBox mskMascara;
        private Label label17;
        private Label label18;
        private TextBox txtAnyDesk;
        private TextBox txtDominio;
        private TextBox txtPorta;
        private TextBox txtProxy;
        private MaskedTextBox mskDNS2;
        private Label label21;
        private Label lblModorBoard;
        private Label label23;
        private Label label22;
        private Label label20;
        private Label label19;
        private TextBox txtGPU;
        private TextBox txtRAM;
        private TextBox txtModBoard;
        private TextBox txtSocket;
        private TextBox txtCPU;
        private Label lblOff1;
        private Label label25;
        private Label lblOff2;
        private TextBox txtOff2;
        private TextBox txtOff1;
        private TextBox txtUsado;
        private TextBox txtStorage;
        private GroupBox groupBox4;
        private TextBox txtNumRegistro;
        private Label label28;
        private RichTextBox rtxtOBS;
        private Button btnCadastrar;
        private Button btnNovo;
        private System.Windows.Forms.Timer timer1;
        private Button btnolhar;
    }
}