namespace S.U.TI.Formularios.Operacional.Setores
{
    partial class FrmSetor
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
            groupBox1 = new GroupBox();
            btnSalvar = new Button();
            lblData = new Label();
            groupBox3 = new GroupBox();
            rtxtDescricao = new RichTextBox();
            label4 = new Label();
            cbEmpresa = new ComboBox();
            label3 = new Label();
            txtSetor = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtId = new TextBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(lblData);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(14, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 283);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Setores:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(316, 239);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(92, 38);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(270, 37);
            lblData.Name = "lblData";
            lblData.Size = new Size(35, 15);
            lblData.TabIndex = 3;
            lblData.Text = "DATA";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rtxtDescricao);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(cbEmpresa);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtSetor);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(6, 64);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(402, 169);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // rtxtDescricao
            // 
            rtxtDescricao.Location = new Point(71, 63);
            rtxtDescricao.Name = "rtxtDescricao";
            rtxtDescricao.Size = new Size(314, 96);
            rtxtDescricao.TabIndex = 5;
            rtxtDescricao.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 66);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 4;
            label4.Text = "Descrição:";
            // 
            // cbEmpresa
            // 
            cbEmpresa.FormattingEnabled = true;
            cbEmpresa.Location = new Point(264, 16);
            cbEmpresa.Name = "cbEmpresa";
            cbEmpresa.Size = new Size(121, 23);
            cbEmpresa.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 19);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Empresa:";
            // 
            // txtSetor
            // 
            txtSetor.Location = new Point(71, 16);
            txtSetor.Name = "txtSetor";
            txtSetor.Size = new Size(126, 23);
            txtSetor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 19);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 0;
            label2.Text = "Setor:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtId);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(6, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(143, 45);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(33, 16);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FrmSetor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 300);
            Controls.Add(groupBox1);
            Name = "FrmSetor";
            Text = "FrmSetor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox txtSetor;
        private Label label2;
        private TextBox txtId;
        private ComboBox cbEmpresa;
        private Label label3;
        private RichTextBox rtxtDescricao;
        private Label label4;
        private Button btnSalvar;
        private Label lblData;
        private System.Windows.Forms.Timer timer1;
    }
}