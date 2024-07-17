namespace S.U.TI.Formularios.Operacional.Empresas
{
    partial class FrmEmpresa
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
            groupBox1 = new GroupBox();
            label10 = new Label();
            mskContato = new MaskedTextBox();
            groupBox2 = new GroupBox();
            txtPais = new TextBox();
            label12 = new Label();
            btnCadastrar = new Button();
            cbUF = new ComboBox();
            label11 = new Label();
            txtNum = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtLagradouro = new TextBox();
            btnProc = new Button();
            label5 = new Label();
            mskCEP = new MaskedTextBox();
            txtAtividade = new TextBox();
            label4 = new Label();
            mskCNPJ = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            txtRazao = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(mskContato);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtAtividade);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(mskCNPJ);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtRazao);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(819, 190);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados da Empresa:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(708, 19);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 10;
            label10.Text = "Contato:";
            // 
            // mskContato
            // 
            mskContato.Location = new Point(708, 37);
            mskContato.Mask = "+00 (00) 00000-0000";
            mskContato.Name = "mskContato";
            mskContato.Size = new Size(100, 23);
            mskContato.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPais);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(btnCadastrar);
            groupBox2.Controls.Add(cbUF);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtNum);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtCidade);
            groupBox2.Controls.Add(txtBairro);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtLagradouro);
            groupBox2.Controls.Add(btnProc);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(mskCEP);
            groupBox2.Location = new Point(6, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(802, 116);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados de Endereço:";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(6, 87);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(156, 23);
            txtPais.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 69);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 14;
            label12.Text = "País:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(696, 71);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(100, 34);
            btnCadastrar.TabIndex = 13;
            btnCadastrar.Text = "&Cadastrar";
            btnCadastrar.TextAlign = ContentAlignment.MiddleRight;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // cbUF
            // 
            cbUF.FormattingEnabled = true;
            cbUF.Location = new Point(696, 38);
            cbUF.Name = "cbUF";
            cbUF.Size = new Size(100, 23);
            cbUF.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(702, 20);
            label11.Name = "label11";
            label11.Size = new Size(24, 15);
            label11.TabIndex = 11;
            label11.Text = "UF:";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(168, 87);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(56, 23);
            txtNum.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(168, 69);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 9;
            label9.Text = "Numero:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(506, 20);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 8;
            label8.Text = "Cidade:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(506, 38);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(184, 23);
            txtCidade.TabIndex = 7;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(311, 38);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(189, 23);
            txtBairro.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(311, 20);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 5;
            label7.Text = "Bairro:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(113, 20);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 4;
            label6.Text = "Lagradouro:";
            // 
            // txtLagradouro
            // 
            txtLagradouro.Location = new Point(113, 38);
            txtLagradouro.Name = "txtLagradouro";
            txtLagradouro.Size = new Size(192, 23);
            txtLagradouro.TabIndex = 3;
            // 
            // btnProc
            // 
            btnProc.Location = new Point(68, 37);
            btnProc.Name = "btnProc";
            btnProc.Size = new Size(39, 23);
            btnProc.TabIndex = 2;
            btnProc.Text = ">>";
            btnProc.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 20);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 1;
            label5.Text = "CEP:";
            // 
            // mskCEP
            // 
            mskCEP.Location = new Point(6, 37);
            mskCEP.Mask = "00000-000";
            mskCEP.Name = "mskCEP";
            mskCEP.Size = new Size(56, 23);
            mskCEP.TabIndex = 0;
            // 
            // txtAtividade
            // 
            txtAtividade.Location = new Point(512, 37);
            txtAtividade.Name = "txtAtividade";
            txtAtividade.Size = new Size(190, 23);
            txtAtividade.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(512, 19);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Atividade:";
            // 
            // mskCNPJ
            // 
            mskCNPJ.Location = new Point(412, 37);
            mskCNPJ.Mask = "00,000,000/0000-00";
            mskCNPJ.Name = "mskCNPJ";
            mskCNPJ.Size = new Size(94, 23);
            mskCNPJ.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 19);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 4;
            label3.Text = "CNPJ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 19);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "Razão Social:";
            // 
            // txtRazao
            // 
            txtRazao.Location = new Point(209, 37);
            txtRazao.Name = "txtRazao";
            txtRazao.Size = new Size(197, 23);
            txtRazao.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(197, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome da Empresa:";
            // 
            // FrmEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 212);
            Controls.Add(groupBox1);
            Name = "FrmEmpresa";
            Text = "FrmEmpresa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txtRazao;
        private TextBox txtNome;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtAtividade;
        private Label label4;
        private MaskedTextBox mskCNPJ;
        private Button btnProc;
        private Label label5;
        private MaskedTextBox mskCEP;
        private Label label6;
        private TextBox txtLagradouro;
        private Label label9;
        private Label label8;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private Label label7;
        private TextBox txtNum;
        private Label label10;
        private MaskedTextBox mskContato;
        private Button btnCadastrar;
        private ComboBox cbUF;
        private Label label11;
        private TextBox txtPais;
        private Label label12;
    }
}