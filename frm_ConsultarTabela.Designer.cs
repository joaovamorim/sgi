namespace SAA
{
    partial class frm_ConsultarTabela
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
            splitContainer1 = new SplitContainer();
            btn_RecarregarTabela = new Button();
            grid_ConsultarTabela = new DataGridView();
            matricula = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            dataNascimento = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_ConsultarTabela).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btn_RecarregarTabela);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(grid_ConsultarTabela);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 39;
            splitContainer1.TabIndex = 0;
            // 
            // btn_RecarregarTabela
            // 
            btn_RecarregarTabela.Cursor = Cursors.Hand;
            btn_RecarregarTabela.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_RecarregarTabela.Location = new Point(12, 3);
            btn_RecarregarTabela.Name = "btn_RecarregarTabela";
            btn_RecarregarTabela.Size = new Size(159, 34);
            btn_RecarregarTabela.TabIndex = 0;
            btn_RecarregarTabela.Text = "Recarregar Tabela";
            btn_RecarregarTabela.UseVisualStyleBackColor = true;
            btn_RecarregarTabela.Click += btn_RecarregarTabela_Click;
            // 
            // grid_ConsultarTabela
            // 
            grid_ConsultarTabela.AccessibleRole = AccessibleRole.TitleBar;
            grid_ConsultarTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_ConsultarTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_ConsultarTabela.Columns.AddRange(new DataGridViewColumn[] { matricula, nome, dataNascimento, cpf, telefone, email });
            grid_ConsultarTabela.Dock = DockStyle.Fill;
            grid_ConsultarTabela.Location = new Point(0, 0);
            grid_ConsultarTabela.Name = "grid_ConsultarTabela";
            grid_ConsultarTabela.RowTemplate.Height = 25;
            grid_ConsultarTabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_ConsultarTabela.Size = new Size(800, 407);
            grid_ConsultarTabela.TabIndex = 0;
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
            // frm_ConsultarTabela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_ConsultarTabela";
            StartPosition = FormStartPosition.Manual;
            Text = "frm_ConsultarTabela";
            Load += frm_ConsultarTabela_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_ConsultarTabela).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btn_RecarregarTabela;
        private DataGridView grid_ConsultarTabela;
        private DataGridViewTextBoxColumn matricula;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn dataNascimento;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn email;
    }
}