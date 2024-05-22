namespace SAA
{
    partial class frm_CadastroAluno
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
            lbl_TitleCadastroAluno = new Label();
            lbl_NomeCompleto = new Label();
            txtBox_NomeCompleto = new TextBox();
            lbl_DataNascimento = new Label();
            lbl_CPF = new Label();
            lbl_Telefone = new Label();
            mask_Telefone = new MaskedTextBox();
            lbl_Email = new Label();
            textBox1 = new TextBox();
            mask_DataNascimento = new MaskedTextBox();
            mask_CPF = new MaskedTextBox();
            lbl_Matricula = new Label();
            mask_Matricula = new MaskedTextBox();
            btn_CadastrarAluno = new Button();
            splitter1 = new Splitter();
            statusStrip1 = new StatusStrip();
            StauLabel_CadastroAluno = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_TitleCadastroAluno
            // 
            lbl_TitleCadastroAluno.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TitleCadastroAluno.Location = new Point(148, 46);
            lbl_TitleCadastroAluno.Name = "lbl_TitleCadastroAluno";
            lbl_TitleCadastroAluno.Size = new Size(246, 48);
            lbl_TitleCadastroAluno.TabIndex = 0;
            lbl_TitleCadastroAluno.Text = "Cadastro do Aluno";
            // 
            // lbl_NomeCompleto
            // 
            lbl_NomeCompleto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NomeCompleto.Location = new Point(90, 94);
            lbl_NomeCompleto.Name = "lbl_NomeCompleto";
            lbl_NomeCompleto.Size = new Size(154, 34);
            lbl_NomeCompleto.TabIndex = 1;
            lbl_NomeCompleto.Text = "Nome Completo:";
            // 
            // txtBox_NomeCompleto
            // 
            txtBox_NomeCompleto.Cursor = Cursors.IBeam;
            txtBox_NomeCompleto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_NomeCompleto.Location = new Point(256, 97);
            txtBox_NomeCompleto.Name = "txtBox_NomeCompleto";
            txtBox_NomeCompleto.Size = new Size(196, 25);
            txtBox_NomeCompleto.TabIndex = 2;
            // 
            // lbl_DataNascimento
            // 
            lbl_DataNascimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DataNascimento.Location = new Point(90, 136);
            lbl_DataNascimento.Name = "lbl_DataNascimento";
            lbl_DataNascimento.Size = new Size(160, 35);
            lbl_DataNascimento.TabIndex = 3;
            lbl_DataNascimento.Text = "Data Nascimento:";
            // 
            // lbl_CPF
            // 
            lbl_CPF.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CPF.Location = new Point(194, 177);
            lbl_CPF.Name = "lbl_CPF";
            lbl_CPF.Size = new Size(50, 35);
            lbl_CPF.TabIndex = 5;
            lbl_CPF.Text = "CPF:";
            // 
            // lbl_Telefone
            // 
            lbl_Telefone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Telefone.Location = new Point(165, 215);
            lbl_Telefone.Name = "lbl_Telefone";
            lbl_Telefone.Size = new Size(85, 35);
            lbl_Telefone.TabIndex = 7;
            lbl_Telefone.Text = "Telefone:";
            // 
            // mask_Telefone
            // 
            mask_Telefone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mask_Telefone.Location = new Point(256, 218);
            mask_Telefone.Mask = "(00) 00000-0000";
            mask_Telefone.Name = "mask_Telefone";
            mask_Telefone.Size = new Size(196, 25);
            mask_Telefone.TabIndex = 8;
            // 
            // lbl_Email
            // 
            lbl_Email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Email.Location = new Point(180, 294);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(70, 35);
            lbl_Email.TabIndex = 9;
            lbl_Email.Text = "E-mail:";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(256, 297);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 25);
            textBox1.TabIndex = 10;
            // 
            // mask_DataNascimento
            // 
            mask_DataNascimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mask_DataNascimento.Location = new Point(256, 139);
            mask_DataNascimento.Mask = "00/00/0000";
            mask_DataNascimento.Name = "mask_DataNascimento";
            mask_DataNascimento.Size = new Size(196, 25);
            mask_DataNascimento.TabIndex = 11;
            mask_DataNascimento.ValidatingType = typeof(DateTime);
            // 
            // mask_CPF
            // 
            mask_CPF.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mask_CPF.Location = new Point(256, 180);
            mask_CPF.Mask = "000.000.000-00";
            mask_CPF.Name = "mask_CPF";
            mask_CPF.Size = new Size(196, 25);
            mask_CPF.TabIndex = 12;
            // 
            // lbl_Matricula
            // 
            lbl_Matricula.Enabled = false;
            lbl_Matricula.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Matricula.Location = new Point(153, 254);
            lbl_Matricula.Name = "lbl_Matricula";
            lbl_Matricula.Size = new Size(97, 35);
            lbl_Matricula.TabIndex = 13;
            lbl_Matricula.Text = "Matricula:";
            // 
            // mask_Matricula
            // 
            mask_Matricula.Enabled = false;
            mask_Matricula.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mask_Matricula.Location = new Point(256, 258);
            mask_Matricula.Mask = "000000";
            mask_Matricula.Name = "mask_Matricula";
            mask_Matricula.Size = new Size(196, 25);
            mask_Matricula.TabIndex = 14;
            // 
            // btn_CadastrarAluno
            // 
            btn_CadastrarAluno.Cursor = Cursors.Hand;
            btn_CadastrarAluno.FlatStyle = FlatStyle.System;
            btn_CadastrarAluno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CadastrarAluno.ImageAlign = ContentAlignment.MiddleRight;
            btn_CadastrarAluno.Location = new Point(256, 343);
            btn_CadastrarAluno.Name = "btn_CadastrarAluno";
            btn_CadastrarAluno.Size = new Size(196, 56);
            btn_CadastrarAluno.TabIndex = 15;
            btn_CadastrarAluno.Text = "Cadastrar Aluno";
            btn_CadastrarAluno.UseCompatibleTextRendering = true;
            btn_CadastrarAluno.UseVisualStyleBackColor = true;
            btn_CadastrarAluno.Click += btn_CadastrarAluno_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 444);
            splitter1.TabIndex = 16;
            splitter1.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { StauLabel_CadastroAluno });
            statusStrip1.Location = new Point(3, 407);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(539, 37);
            statusStrip1.TabIndex = 17;
            statusStrip1.Text = "statusStrip1";
            // 
            // StauLabel_CadastroAluno
            // 
            StauLabel_CadastroAluno.DisplayStyle = ToolStripItemDisplayStyle.Text;
            StauLabel_CadastroAluno.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            StauLabel_CadastroAluno.Name = "StauLabel_CadastroAluno";
            StauLabel_CadastroAluno.Size = new Size(65, 32);
            StauLabel_CadastroAluno.Text = "label";
            // 
            // frm_CadastroAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 444);
            ControlBox = false;
            Controls.Add(statusStrip1);
            Controls.Add(splitter1);
            Controls.Add(btn_CadastrarAluno);
            Controls.Add(mask_Matricula);
            Controls.Add(lbl_Matricula);
            Controls.Add(mask_CPF);
            Controls.Add(mask_DataNascimento);
            Controls.Add(textBox1);
            Controls.Add(lbl_Email);
            Controls.Add(mask_Telefone);
            Controls.Add(lbl_Telefone);
            Controls.Add(lbl_CPF);
            Controls.Add(lbl_DataNascimento);
            Controls.Add(txtBox_NomeCompleto);
            Controls.Add(lbl_NomeCompleto);
            Controls.Add(lbl_TitleCadastroAluno);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_CadastroAluno";
            StartPosition = FormStartPosition.Manual;
            Text = "Cadastro de Aluno";
            Load += frm_CadastroAluno_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TitleCadastroAluno;
        private Label lbl_NomeCompleto;
        private TextBox txtBox_NomeCompleto;
        private Label lbl_DataNascimento;
        private Label lbl_CPF;
        private Label lbl_Telefone;
        private MaskedTextBox mask_Telefone;
        private Label lbl_Email;
        private TextBox textBox1;
        private MaskedTextBox mask_DataNascimento;
        private MaskedTextBox mask_CPF;
        private Label lbl_Matricula;
        private MaskedTextBox mask_Matricula;
        private Button btn_CadastrarAluno;
        private Splitter splitter1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StauLabel_CadastroAluno;
    }
}