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
            txtBox_Pesquisar = new TextBox();
            btn_Consultar = new Button();
            btn_RecarregarTabela = new Button();
            grid_ConsultarTabela = new DataGridView();
            matricula = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            data_nascimento = new DataGridViewTextBoxColumn();
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
            splitContainer1.Panel1.Controls.Add(txtBox_Pesquisar);
            splitContainer1.Panel1.Controls.Add(btn_Consultar);
            splitContainer1.Panel1.Controls.Add(btn_RecarregarTabela);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(grid_ConsultarTabela);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 39;
            splitContainer1.TabIndex = 0;
            // 
            // txtBox_Pesquisar
            // 
            txtBox_Pesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_Pesquisar.Location = new Point(89, 3);
            txtBox_Pesquisar.Name = "txtBox_Pesquisar";
            txtBox_Pesquisar.Size = new Size(425, 33);
            txtBox_Pesquisar.TabIndex = 2;
            // 
            // btn_Consultar
            // 
            btn_Consultar.Cursor = Cursors.Hand;
            btn_Consultar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Consultar.Location = new Point(3, 3);
            btn_Consultar.Name = "btn_Consultar";
            btn_Consultar.Size = new Size(80, 34);
            btn_Consultar.TabIndex = 1;
            btn_Consultar.Text = "Consultar";
            btn_Consultar.UseVisualStyleBackColor = true;
            btn_Consultar.Click += btn_Consultar_Click;
            // 
            // btn_RecarregarTabela
            // 
            btn_RecarregarTabela.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_RecarregarTabela.Cursor = Cursors.Hand;
            btn_RecarregarTabela.Enabled = true;
            btn_RecarregarTabela.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_RecarregarTabela.Location = new Point(667, 3);
            btn_RecarregarTabela.Name = "btn_RecarregarTabela";
            btn_RecarregarTabela.Size = new Size(130, 34);
            btn_RecarregarTabela.TabIndex = 0;
            btn_RecarregarTabela.Text = "Recarregar Tabela";
            btn_RecarregarTabela.UseVisualStyleBackColor = true;
            btn_RecarregarTabela.Click += btn_RecarregarTabela_Click;
            // 
            // grid_ConsultarTabela
            // 
            grid_ConsultarTabela.AccessibleRole = AccessibleRole.TitleBar;
            grid_ConsultarTabela.AllowUserToAddRows = false;
            grid_ConsultarTabela.AllowUserToDeleteRows = false;
            grid_ConsultarTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_ConsultarTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_ConsultarTabela.Columns.AddRange(new DataGridViewColumn[] { matricula, nome, data_nascimento, cpf, telefone, email });
            grid_ConsultarTabela.Dock = DockStyle.Fill;
            grid_ConsultarTabela.Location = new Point(0, 0);
            grid_ConsultarTabela.Name = "grid_ConsultarTabela";
            grid_ConsultarTabela.ReadOnly = true;
            grid_ConsultarTabela.RowTemplate.Height = 25;
            grid_ConsultarTabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_ConsultarTabela.Size = new Size(800, 407);
            grid_ConsultarTabela.TabIndex = 0;
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
            // data_nascimento
            // 
            data_nascimento.HeaderText = "DATA NASCIMENTO";
            data_nascimento.Name = "data_nascimento";
            data_nascimento.ReadOnly = true;
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
            splitContainer1.Panel1.PerformLayout();
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
        private Button btn_Consultar;
        private TextBox txtBox_Pesquisar;
        private DataGridViewTextBoxColumn matricula;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn data_nascimento;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn email;
    }
}