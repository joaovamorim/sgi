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
            txtBox_Pesquisar = new TextBox();
            btn_Pesquisar = new Button();
            splitContainer1 = new SplitContainer();
            lbl_TitleCadastroAluno = new Label();
            lbl_NomeCompleto = new Label();
            mask_CPF = new MaskedTextBox();
            lbl_Telefone = new Label();
            txtBox_NomeCompleto = new TextBox();
            mask_Telefone = new MaskedTextBox();
            lbl_Matricula = new Label();
            btn_CadastrarAluno = new Button();
            mask_DataNascimento = new MaskedTextBox();
            lbl_CPF = new Label();
            lbl_DataNascimento = new Label();
            lbl_Email = new Label();
            txtBox_Email = new TextBox();
            mask_Matricula = new MaskedTextBox();
            grid_CadastroAluno = new DataGridView();
            matricula = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            dataNascimento = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            lbl_CadastroAlunoMsg = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_CadastroAluno).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBox_Pesquisar
            // 
            txtBox_Pesquisar.Cursor = Cursors.IBeam;
            txtBox_Pesquisar.Dock = DockStyle.Bottom;
            txtBox_Pesquisar.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_Pesquisar.Location = new Point(0, 444);
            txtBox_Pesquisar.Name = "txtBox_Pesquisar";
            txtBox_Pesquisar.Size = new Size(429, 30);
            txtBox_Pesquisar.TabIndex = 17;
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.Cursor = Cursors.Hand;
            btn_Pesquisar.Dock = DockStyle.Bottom;
            btn_Pesquisar.FlatStyle = FlatStyle.System;
            btn_Pesquisar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Pesquisar.ImageAlign = ContentAlignment.MiddleRight;
            btn_Pesquisar.Location = new Point(0, 412);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new Size(429, 32);
            btn_Pesquisar.TabIndex = 18;
            btn_Pesquisar.Text = "Pesquisar";
            btn_Pesquisar.UseCompatibleTextRendering = true;
            btn_Pesquisar.UseVisualStyleBackColor = true;
            btn_Pesquisar.Click += btn_Pesquisar_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btn_Pesquisar);
            splitContainer1.Panel1.Controls.Add(txtBox_Pesquisar);
            splitContainer1.Panel1.Controls.Add(lbl_TitleCadastroAluno);
            splitContainer1.Panel1.Controls.Add(lbl_NomeCompleto);
            splitContainer1.Panel1.Controls.Add(mask_CPF);
            splitContainer1.Panel1.Controls.Add(lbl_Telefone);
            splitContainer1.Panel1.Controls.Add(txtBox_NomeCompleto);
            splitContainer1.Panel1.Controls.Add(mask_Telefone);
            splitContainer1.Panel1.Controls.Add(lbl_Matricula);
            splitContainer1.Panel1.Controls.Add(btn_CadastrarAluno);
            splitContainer1.Panel1.Controls.Add(mask_DataNascimento);
            splitContainer1.Panel1.Controls.Add(lbl_CPF);
            splitContainer1.Panel1.Controls.Add(lbl_DataNascimento);
            splitContainer1.Panel1.Controls.Add(lbl_Email);
            splitContainer1.Panel1.Controls.Add(txtBox_Email);
            splitContainer1.Panel1.Controls.Add(mask_Matricula);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(grid_CadastroAluno);
            splitContainer1.Size = new Size(1086, 474);
            splitContainer1.SplitterDistance = 429;
            splitContainer1.TabIndex = 20;
            // 
            // lbl_TitleCadastroAluno
            // 
            lbl_TitleCadastroAluno.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TitleCadastroAluno.Location = new Point(91, 33);
            lbl_TitleCadastroAluno.Name = "lbl_TitleCadastroAluno";
            lbl_TitleCadastroAluno.Size = new Size(246, 48);
            lbl_TitleCadastroAluno.TabIndex = 0;
            lbl_TitleCadastroAluno.Text = "Cadastro do Aluno";
            // 
            // lbl_NomeCompleto
            // 
            lbl_NomeCompleto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NomeCompleto.Location = new Point(33, 81);
            lbl_NomeCompleto.Name = "lbl_NomeCompleto";
            lbl_NomeCompleto.Size = new Size(154, 34);
            lbl_NomeCompleto.TabIndex = 1;
            lbl_NomeCompleto.Text = "Nome Completo:";
            // 
            // mask_CPF
            // 
            mask_CPF.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mask_CPF.Location = new Point(199, 167);
            mask_CPF.Mask = "000\\.000\\.000-00";
            mask_CPF.Name = "mask_CPF";
            mask_CPF.Size = new Size(196, 25);
            mask_CPF.TabIndex = 12;
            // 
            // lbl_Telefone
            // 
            lbl_Telefone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Telefone.Location = new Point(108, 202);
            lbl_Telefone.Name = "lbl_Telefone";
            lbl_Telefone.Size = new Size(85, 35);
            lbl_Telefone.TabIndex = 7;
            lbl_Telefone.Text = "Telefone:";
            // 
            // txtBox_NomeCompleto
            // 
            txtBox_NomeCompleto.Cursor = Cursors.IBeam;
            txtBox_NomeCompleto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_NomeCompleto.Location = new Point(199, 84);
            txtBox_NomeCompleto.Name = "txtBox_NomeCompleto";
            txtBox_NomeCompleto.Size = new Size(196, 25);
            txtBox_NomeCompleto.TabIndex = 2;
            // 
            // mask_Telefone
            // 
            mask_Telefone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mask_Telefone.Location = new Point(199, 205);
            mask_Telefone.Mask = "(00) 00000-0000";
            mask_Telefone.Name = "mask_Telefone";
            mask_Telefone.Size = new Size(196, 25);
            mask_Telefone.TabIndex = 8;
            // 
            // lbl_Matricula
            // 
            lbl_Matricula.Enabled = false;
            lbl_Matricula.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Matricula.Location = new Point(96, 241);
            lbl_Matricula.Name = "lbl_Matricula";
            lbl_Matricula.Size = new Size(97, 35);
            lbl_Matricula.TabIndex = 13;
            lbl_Matricula.Text = "Matricula:";
            // 
            // btn_CadastrarAluno
            // 
            btn_CadastrarAluno.Cursor = Cursors.Hand;
            btn_CadastrarAluno.FlatStyle = FlatStyle.System;
            btn_CadastrarAluno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CadastrarAluno.ImageAlign = ContentAlignment.MiddleRight;
            btn_CadastrarAluno.Location = new Point(199, 330);
            btn_CadastrarAluno.Name = "btn_CadastrarAluno";
            btn_CadastrarAluno.Size = new Size(196, 56);
            btn_CadastrarAluno.TabIndex = 15;
            btn_CadastrarAluno.Text = "Cadastrar Aluno";
            btn_CadastrarAluno.UseCompatibleTextRendering = true;
            btn_CadastrarAluno.UseVisualStyleBackColor = true;
            btn_CadastrarAluno.Click += btn_CadastrarAluno_Click;
            // 
            // mask_DataNascimento
            // 
            mask_DataNascimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mask_DataNascimento.Location = new Point(199, 126);
            mask_DataNascimento.Mask = "00/00/0000";
            mask_DataNascimento.Name = "mask_DataNascimento";
            mask_DataNascimento.Size = new Size(196, 25);
            mask_DataNascimento.TabIndex = 11;
            // 
            // lbl_CPF
            // 
            lbl_CPF.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CPF.Location = new Point(137, 164);
            lbl_CPF.Name = "lbl_CPF";
            lbl_CPF.Size = new Size(50, 35);
            lbl_CPF.TabIndex = 5;
            lbl_CPF.Text = "CPF:";
            // 
            // lbl_DataNascimento
            // 
            lbl_DataNascimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DataNascimento.Location = new Point(33, 123);
            lbl_DataNascimento.Name = "lbl_DataNascimento";
            lbl_DataNascimento.Size = new Size(160, 35);
            lbl_DataNascimento.TabIndex = 3;
            lbl_DataNascimento.Text = "Data Nascimento:";
            // 
            // lbl_Email
            // 
            lbl_Email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Email.Location = new Point(123, 281);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(70, 35);
            lbl_Email.TabIndex = 9;
            lbl_Email.Text = "E-mail:";
            // 
            // txtBox_Email
            // 
            txtBox_Email.Cursor = Cursors.IBeam;
            txtBox_Email.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_Email.Location = new Point(199, 284);
            txtBox_Email.Name = "txtBox_Email";
            txtBox_Email.Size = new Size(196, 25);
            txtBox_Email.TabIndex = 10;
            // 
            // mask_Matricula
            // 
            mask_Matricula.Enabled = false;
            mask_Matricula.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mask_Matricula.Location = new Point(199, 245);
            mask_Matricula.Mask = "000000";
            mask_Matricula.Name = "mask_Matricula";
            mask_Matricula.Size = new Size(196, 25);
            mask_Matricula.TabIndex = 14;
            // 
            // grid_CadastroAluno
            // 
            grid_CadastroAluno.AllowUserToAddRows = false;
            grid_CadastroAluno.AllowUserToDeleteRows = false;
            grid_CadastroAluno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_CadastroAluno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_CadastroAluno.Columns.AddRange(new DataGridViewColumn[] { matricula, nome, dataNascimento, cpf, telefone, email });
            grid_CadastroAluno.Dock = DockStyle.Fill;
            grid_CadastroAluno.Location = new Point(0, 0);
            grid_CadastroAluno.MultiSelect = false;
            grid_CadastroAluno.Name = "grid_CadastroAluno";
            grid_CadastroAluno.ReadOnly = true;
            grid_CadastroAluno.RowTemplate.Height = 25;
            grid_CadastroAluno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_CadastroAluno.Size = new Size(653, 474);
            grid_CadastroAluno.TabIndex = 19;
            // 
            // matricula
            // 
            matricula.HeaderText = "MATRÍCULA";
            matricula.Name = "matricula";
            matricula.ReadOnly = true;
            // 
            // nome
            // 
            nome.HeaderText = "NOME";
            nome.Name = "nome";
            nome.ReadOnly = true;
            // 
            // dataNascimento
            // 
            dataNascimento.HeaderText = "DATA NASCIMENTO";
            dataNascimento.Name = "dataNascimento";
            dataNascimento.ReadOnly = true;
            // 
            // cpf
            // 
            cpf.HeaderText = "CPF";
            cpf.Name = "cpf";
            cpf.ReadOnly = true;
            // 
            // telefone
            // 
            telefone.HeaderText = "TELEFONE";
            telefone.Name = "telefone";
            telefone.ReadOnly = true;
            // 
            // email
            // 
            email.HeaderText = "E-MAIL";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // lbl_CadastroAlunoMsg
            // 
            lbl_CadastroAlunoMsg.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lbl_CadastroAlunoMsg.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CadastroAlunoMsg.Name = "lbl_CadastroAlunoMsg";
            lbl_CadastroAlunoMsg.Size = new Size(0, 17);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl_CadastroAlunoMsg });
            statusStrip1.Location = new Point(0, 474);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1086, 22);
            statusStrip1.TabIndex = 17;
            statusStrip1.Text = "statusStrip1";
            // 
            // frm_CadastroAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 496);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_CadastroAluno";
            StartPosition = FormStartPosition.Manual;
            Text = "Cadastro de Aluno";
            Load += frm_CadastroAluno_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_CadastroAluno).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBox_Pesquisar;
        private Button btn_Pesquisar;
        private SplitContainer splitContainer1;
        private Label lbl_TitleCadastroAluno;
        private Label lbl_NomeCompleto;
        private MaskedTextBox mask_CPF;
        private Label lbl_Telefone;
        private TextBox txtBox_NomeCompleto;
        private MaskedTextBox mask_Telefone;
        private Label lbl_Matricula;
        private Button btn_CadastrarAluno;
        private MaskedTextBox mask_DataNascimento;
        private Label lbl_CPF;
        private Label lbl_DataNascimento;
        private Label lbl_Email;
        private TextBox txtBox_Email;
        private MaskedTextBox mask_Matricula;
        private DataGridView grid_CadastroAluno;
        private DataGridViewTextBoxColumn matricula;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn dataNascimento;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn email;
        private ToolStripStatusLabel lbl_CadastroAlunoMsg;
        private StatusStrip statusStrip1;
    }
}