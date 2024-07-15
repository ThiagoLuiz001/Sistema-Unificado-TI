namespace S.U.TI.Formularios.Operacional.Sistemas
{
    partial class FrmSistemaOperacional
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
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 109);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados da Imagem:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 20);
            label2.Name = "label2";
            label2.Size = new Size(181, 15);
            label2.TabIndex = 1;
            label2.Text = "Imagem de Sistema Operacional:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(305, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 73);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 3;
            label3.Text = "Criação da Imagem:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(292, 67);
            maskedTextBox1.Mask = "00/00/0000 ";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(60, 23);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // button1
            // 
            button1.Location = new Point(395, 63);
            button1.Name = "button1";
            button1.Size = new Size(81, 35);
            button1.TabIndex = 5;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 6;
            label1.Text = "Empresa:";
            // 
            // FrmSistemaOperacional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 129);
            Controls.Add(groupBox1);
            Name = "FrmSistemaOperacional";
            Text = "FrmSistemaOperacional";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}