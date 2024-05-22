namespace SAA
{
    partial class frm_TabelaDB
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
            Grid_TabelaDB = new DataGridView();
            matriucla = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            dataNascimento = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Grid_TabelaDB).BeginInit();
            SuspendLayout();
            // 
            // Grid_TabelaDB
            // 
            Grid_TabelaDB.AllowUserToOrderColumns = true;
            Grid_TabelaDB.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            Grid_TabelaDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_TabelaDB.Columns.AddRange(new DataGridViewColumn[] { matriucla, nome, dataNascimento, cpf, telefone, email });
            Grid_TabelaDB.Dock = DockStyle.Fill;
            Grid_TabelaDB.Location = new Point(0, 0);
            Grid_TabelaDB.MultiSelect = false;
            Grid_TabelaDB.Name = "Grid_TabelaDB";
            Grid_TabelaDB.RowTemplate.Height = 25;
            Grid_TabelaDB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid_TabelaDB.Size = new Size(800, 450);
            Grid_TabelaDB.TabIndex = 0;
            // 
            // matriucla
            // 
            matriucla.HeaderText = "MATRICULA";
            matriucla.Name = "matriucla";
            matriucla.Width = 126;
            // 
            // nome
            // 
            nome.HeaderText = "NOME";
            nome.Name = "nome";
            nome.Width = 126;
            // 
            // dataNascimento
            // 
            dataNascimento.HeaderText = "DATA NASCIMENTO";
            dataNascimento.Name = "dataNascimento";
            dataNascimento.Width = 126;
            // 
            // cpf
            // 
            cpf.HeaderText = "CPF";
            cpf.Name = "cpf";
            cpf.Width = 127;
            // 
            // telefone
            // 
            telefone.HeaderText = "TELEFONE";
            telefone.Name = "telefone";
            telefone.Width = 126;
            // 
            // email
            // 
            email.HeaderText = "E-MAIL";
            email.Name = "email";
            email.Width = 126;
            // 
            // frm_TabelaDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(Grid_TabelaDB);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_TabelaDB";
            StartPosition = FormStartPosition.Manual;
            Text = "TabelaDB";
            Load += TabelaDB_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_TabelaDB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Grid_TabelaDB;
        private DataGridViewTextBoxColumn matriucla;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn dataNascimento;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn email;
    }
}