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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            groupBox2 = new GroupBox();
            maskedTextBox2 = new MaskedTextBox();
            label5 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox7 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(713, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados da Empresa:";
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
            // textBox1
            // 
            textBox1.Location = new Point(6, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 23);
            textBox2.TabIndex = 2;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 19);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 4;
            label3.Text = "CNPJ:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(412, 37);
            maskedTextBox1.Mask = "00,000,000/0000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(94, 23);
            maskedTextBox1.TabIndex = 5;
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
            // textBox3
            // 
            textBox3.Location = new Point(512, 37);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 23);
            textBox3.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Location = new Point(6, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(696, 156);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados de Endereço:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(6, 37);
            maskedTextBox2.Mask = "00000-000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(56, 23);
            maskedTextBox2.TabIndex = 0;
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
            // button1
            // 
            button1.Location = new Point(68, 37);
            button1.Name = "button1";
            button1.Size = new Size(39, 23);
            button1.TabIndex = 2;
            button1.Text = ">>";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(113, 38);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(192, 23);
            textBox4.TabIndex = 3;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(311, 20);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 5;
            label7.Text = "Bairro:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(311, 38);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(189, 23);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(506, 38);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(184, 23);
            textBox6.TabIndex = 7;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 71);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 9;
            label9.Text = "Numero:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(6, 89);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(56, 23);
            textBox7.TabIndex = 10;
            // 
            // FrmEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 263);
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
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private Label label5;
        private MaskedTextBox maskedTextBox2;
        private Label label6;
        private TextBox textBox4;
        private Label label9;
        private Label label8;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox7;
    }
}