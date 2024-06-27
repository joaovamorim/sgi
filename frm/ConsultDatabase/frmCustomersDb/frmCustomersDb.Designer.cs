namespace SGI.frm.ConsultDatabase.frmCustomersDb
{
    partial class frmCustomersDb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomersDb));
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            helpToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            refreshToolStripButton = new ToolStripButton();
            searchToolStripButton = new ToolStripButton();
            toolStripTextBox1 = new ToolStripTextBox();
            gridCustomersDb = new DataGridView();
            matricula = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            dataNascimento = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            _status = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCustomersDb).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, helpToolStripButton, toolStripSeparator2, toolStripSeparator3, refreshToolStripButton, searchToolStripButton, toolStripTextBox1 });
            toolStrip1.Location = new Point(0, 425);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.Alignment = ToolStripItemAlignment.Right;
            helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButton.Image = (Image)resources.GetObject("helpToolStripButton.Image");
            helpToolStripButton.ImageTransparentColor = Color.Magenta;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new Size(23, 22);
            helpToolStripButton.Text = "Help";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // refreshToolStripButton
            // 
            refreshToolStripButton.Alignment = ToolStripItemAlignment.Right;
            refreshToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            refreshToolStripButton.Image = (Image)resources.GetObject("refreshToolStripButton.Image");
            refreshToolStripButton.ImageTransparentColor = Color.Magenta;
            refreshToolStripButton.Name = "refreshToolStripButton";
            refreshToolStripButton.Size = new Size(23, 22);
            refreshToolStripButton.Tag = "";
            refreshToolStripButton.Text = "Refresh";
            refreshToolStripButton.Click += refreshToolStripButton_Click;
            // 
            // searchToolStripButton
            // 
            searchToolStripButton.BackColor = SystemColors.ControlLight;
            searchToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            searchToolStripButton.Image = (Image)resources.GetObject("searchToolStripButton.Image");
            searchToolStripButton.ImageTransparentColor = Color.Magenta;
            searchToolStripButton.Name = "searchToolStripButton";
            searchToolStripButton.Size = new Size(46, 22);
            searchToolStripButton.Text = "Search";
            searchToolStripButton.Click += searchToolStripButton_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.BackColor = Color.White;
            toolStripTextBox1.BorderStyle = BorderStyle.FixedSingle;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 25);
            toolStripTextBox1.Tag = "Search";
            // 
            // gridCustomersDb
            // 
            gridCustomersDb.AllowUserToAddRows = false;
            gridCustomersDb.AllowUserToDeleteRows = false;
            gridCustomersDb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCustomersDb.BackgroundColor = SystemColors.Control;
            gridCustomersDb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCustomersDb.Columns.AddRange(new DataGridViewColumn[] { matricula, nome, dataNascimento, cpf, telefone, email, _status });
            gridCustomersDb.Dock = DockStyle.Fill;
            gridCustomersDb.GridColor = SystemColors.Control;
            gridCustomersDb.Location = new Point(0, 0);
            gridCustomersDb.MultiSelect = false;
            gridCustomersDb.Name = "gridCustomersDb";
            gridCustomersDb.ReadOnly = true;
            gridCustomersDb.RowTemplate.Height = 25;
            gridCustomersDb.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCustomersDb.Size = new Size(800, 425);
            gridCustomersDb.TabIndex = 20;
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
            // _status
            // 
            _status.HeaderText = "STATUS";
            _status.Name = "_status";
            _status.ReadOnly = true;
            // 
            // frmCustomersDb
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridCustomersDb);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCustomersDb";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SGI | ";
            WindowState = FormWindowState.Maximized;
            Load += frmCustomersDb_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCustomersDb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton refreshToolStripButton;
        private ToolStripButton helpToolStripButton;
        private DataGridView gridCustomersDb;
        private DataGridViewTextBoxColumn matricula;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn dataNascimento;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn _status;
        private ToolStripButton searchToolStripButton;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
    }
}