namespace SAA
{
    partial class frm_EditarAluno
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
            btn_Pesquisar = new Button();
            txtBox_Pesquisar = new TextBox();
            btn_RecarregarTabela = new Button();
            statusStrip1 = new StatusStrip();
            lbl_CadastroAlunoMsg = new ToolStripStatusLabel();
            grid_CadastroAluno = new DataGridView();
            matricula = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            dataNascimento = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            lbl_TitleEditarAluno = new Label();
            lbl_NomeCompleto = new Label();
            lbl_Telefone = new Label();
            txtBox_NomeCompleto = new TextBox();
            mask_Telefone = new MaskedTextBox();
            btn_EditarAluno = new Button();
            mask_CPF = new MaskedTextBox();
            lbl_Matricula = new Label();
            mask_DataNascimento = new MaskedTextBox();
            lbl_Email = new Label();
            txtBox_Email = new TextBox();
            splitContainer1 = new SplitContainer();
            lbl_CPF = new Label();
            lbl_DataNascimento = new Label();
            mask_Matricula = new MaskedTextBox();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_CadastroAluno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.Cursor = Cursors.Hand;
            btn_Pesquisar.Dock = DockStyle.Bottom;
            btn_Pesquisar.FlatStyle = FlatStyle.System;
            btn_Pesquisar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Pesquisar.ImageAlign = ContentAlignment.MiddleRight;
            btn_Pesquisar.Location = new Point(0, 411);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new Size(429, 32);
            btn_Pesquisar.TabIndex = 18;
            btn_Pesquisar.Text = "Pesquisar";
            btn_Pesquisar.UseCompatibleTextRendering = true;
            btn_Pesquisar.UseVisualStyleBackColor = true;
            btn_Pesquisar.Click += btn_Pesquisar_Click;
            // 
            // txtBox_Pesquisar
            // 
            txtBox_Pesquisar.Cursor = Cursors.IBeam;
            txtBox_Pesquisar.Dock = DockStyle.Bottom;
            txtBox_Pesquisar.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_Pesquisar.Location = new Point(0, 443);
            txtBox_Pesquisar.Name = "txtBox_Pesquisar";
            txtBox_Pesquisar.Size = new Size(429, 30);
            txtBox_Pesquisar.TabIndex = 17;
            // 
            // btn_RecarregarTabela
            // 
            btn_RecarregarTabela.Cursor = Cursors.Hand;
            btn_RecarregarTabela.FlatStyle = FlatStyle.System;
            btn_RecarregarTabela.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_RecarregarTabela.ImageAlign = ContentAlignment.MiddleRight;
            btn_RecarregarTabela.Location = new Point(22, 330);
            btn_RecarregarTabela.Name = "btn_RecarregarTabela";
            btn_RecarregarTabela.Size = new Size(165, 56);
            btn_RecarregarTabela.TabIndex = 16;
            btn_RecarregarTabela.Text = "Recarregar Tabela";
            btn_RecarregarTabela.UseCompatibleTextRendering = true;
            btn_RecarregarTabela.UseVisualStyleBackColor = true;
            btn_RecarregarTabela.Click += btn_RecarregarTabela_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl_CadastroAlunoMsg });
            statusStrip1.Location = new Point(0, 473);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(933, 37);
            statusStrip1.TabIndex = 21;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl_CadastroAlunoMsg
            // 
            lbl_CadastroAlunoMsg.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lbl_CadastroAlunoMsg.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CadastroAlunoMsg.Name = "lbl_CadastroAlunoMsg";
            lbl_CadastroAlunoMsg.Size = new Size(65, 32);
            lbl_CadastroAlunoMsg.Text = "label";
            // 
            // grid_CadastroAluno
            // 
            grid_CadastroAluno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_CadastroAluno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_CadastroAluno.Columns.AddRange(new DataGridViewColumn[] { matricula, nome, dataNascimento, cpf, telefone, email });
            grid_CadastroAluno.Dock = DockStyle.Fill;
            grid_CadastroAluno.Location = new Point(0, 0);
            grid_CadastroAluno.MultiSelect = false;
            grid_CadastroAluno.Name = "grid_CadastroAluno";
            grid_CadastroAluno.RowTemplate.Height = 25;
            grid_CadastroAluno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_CadastroAluno.Size = new Size(500, 473);
            grid_CadastroAluno.TabIndex = 19;
            // 
            // matricula
            // 
            matricula.HeaderText = "MATRÍCULA";
            matricula.Name = "matricula";
            // 
            // nome
            // 
            nome.HeaderText = "NOME";
            nome.Name = "nome";
            // 
            // dataNascimento
            // 
            dataNascimento.HeaderText = "DATA NASCIMENTO";
            dataNascimento.Name = "dataNascimento";
            // 
            // cpf
            // 
            cpf.HeaderText = "CPF";
            cpf.Name = "cpf";
            // 
            // telefone
            // 
            telefone.HeaderText = "TELEFONE";
            telefone.Name = "telefone";
            // 
            // email
            // 
            email.HeaderText = "E-MAIL";
            email.Name = "email";
            // 
            // lbl_TitleEditarAluno
            // 
            lbl_TitleEditarAluno.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TitleEditarAluno.Location = new Point(131, 33);
            lbl_TitleEditarAluno.Name = "lbl_TitleEditarAluno";
            lbl_TitleEditarAluno.Size = new Size(167, 48);
            lbl_TitleEditarAluno.TabIndex = 0;
            lbl_TitleEditarAluno.Text = "Editar Aluno";
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
            // btn_EditarAluno
            // 
            btn_EditarAluno.Cursor = Cursors.Hand;
            btn_EditarAluno.FlatStyle = FlatStyle.System;
            btn_EditarAluno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_EditarAluno.ImageAlign = ContentAlignment.MiddleRight;
            btn_EditarAluno.Location = new Point(199, 330);
            btn_EditarAluno.Name = "btn_EditarAluno";
            btn_EditarAluno.Size = new Size(196, 56);
            btn_EditarAluno.TabIndex = 15;
            btn_EditarAluno.Text = "Editar Aluno";
            btn_EditarAluno.UseCompatibleTextRendering = true;
            btn_EditarAluno.UseVisualStyleBackColor = true;
            btn_EditarAluno.Click += btn_EditarAluno_Click;
            // 
            // mask_CPF
            // 
            mask_CPF.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mask_CPF.Location = new Point(199, 167);
            mask_CPF.Mask = "000.000.000-00";
            mask_CPF.Name = "mask_CPF";
            mask_CPF.Size = new Size(196, 25);
            mask_CPF.TabIndex = 12;
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
            // mask_DataNascimento
            // 
            mask_DataNascimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mask_DataNascimento.Location = new Point(199, 126);
            mask_DataNascimento.Mask = "00/00/0000";
            mask_DataNascimento.Name = "mask_DataNascimento";
            mask_DataNascimento.Size = new Size(196, 25);
            mask_DataNascimento.TabIndex = 11;
            mask_DataNascimento.ValidatingType = typeof(DateTime);
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
            splitContainer1.Panel1.Controls.Add(btn_RecarregarTabela);
            splitContainer1.Panel1.Controls.Add(lbl_TitleEditarAluno);
            splitContainer1.Panel1.Controls.Add(lbl_NomeCompleto);
            splitContainer1.Panel1.Controls.Add(mask_CPF);
            splitContainer1.Panel1.Controls.Add(lbl_Telefone);
            splitContainer1.Panel1.Controls.Add(txtBox_NomeCompleto);
            splitContainer1.Panel1.Controls.Add(mask_Telefone);
            splitContainer1.Panel1.Controls.Add(lbl_Matricula);
            splitContainer1.Panel1.Controls.Add(btn_EditarAluno);
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
            splitContainer1.Size = new Size(933, 473);
            splitContainer1.SplitterDistance = 429;
            splitContainer1.TabIndex = 22;
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
            // frm_EditarAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 510);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_EditarAluno";
            StartPosition = FormStartPosition.Manual;
            Text = "frm_EditarAluno";
            Load += frm_EditarAluno_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_CadastroAluno).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Pesquisar;
        private TextBox txtBox_Pesquisar;
        private Button btn_RecarregarTabela;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl_CadastroAlunoMsg;
        private DataGridView grid_CadastroAluno;
        private DataGridViewTextBoxColumn matricula;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn dataNascimento;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn email;
        private Label lbl_TitleEditarAluno;
        private Label lbl_NomeCompleto;
        private Label lbl_Telefone;
        private TextBox txtBox_NomeCompleto;
        private MaskedTextBox mask_Telefone;
        private Button btn_EditarAluno;
        private MaskedTextBox mask_CPF;
        private Label lbl_Matricula;
        private MaskedTextBox mask_DataNascimento;
        private Label lbl_Email;
        private TextBox txtBox_Email;
        private SplitContainer splitContainer1;
        private Label lbl_CPF;
        private Label lbl_DataNascimento;
        private MaskedTextBox mask_Matricula;
    }
}