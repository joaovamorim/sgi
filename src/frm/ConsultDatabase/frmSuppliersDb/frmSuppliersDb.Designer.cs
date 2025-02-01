namespace SGI.frm.ConsultDatabase.frmSuppliersDb
{
    partial class frmSuppliersDb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuppliersDb));
            timer1 = new System.Windows.Forms.Timer(components);
            email = new DataGridViewTextBoxColumn();
            num_tel = new DataGridViewTextBoxColumn();
            cod_cpf = new DataGridViewTextBoxColumn();
            data_nasc = new DataGridViewTextBoxColumn();
            nome_func = new DataGridViewTextBoxColumn();
            cod_ch_func = new DataGridViewTextBoxColumn();
            ativ_atl = new DataGridViewTextBoxColumn();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            searchToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            refreshToolStripButton = new ToolStripButton();
            helpToolStripButton = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            toolStripSeparator4 = new ToolStripSeparator();
            gridSuppliersDb = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridSuppliersDb).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // email
            // 
            email.HeaderText = "E-MAIL";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // num_tel
            // 
            num_tel.HeaderText = "TELEFONE";
            num_tel.Name = "num_tel";
            num_tel.ReadOnly = true;
            // 
            // cod_cpf
            // 
            cod_cpf.HeaderText = "CPF";
            cod_cpf.Name = "cod_cpf";
            cod_cpf.ReadOnly = true;
            // 
            // data_nasc
            // 
            data_nasc.HeaderText = "DATA NASCIMENTO";
            data_nasc.Name = "data_nasc";
            data_nasc.ReadOnly = true;
            // 
            // nome_func
            // 
            nome_func.HeaderText = "NOME";
            nome_func.Name = "nome_func";
            nome_func.ReadOnly = true;
            // 
            // cod_ch_func
            // 
            cod_ch_func.HeaderText = "MATRÍCULA";
            cod_ch_func.Name = "cod_ch_func";
            cod_ch_func.ReadOnly = true;
            // 
            // ativ_atl
            // 
            ativ_atl.HeaderText = "STATUS";
            ativ_atl.Name = "ativ_atl";
            ativ_atl.ReadOnly = true;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.BackColor = SystemColors.Control;
            toolStripLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(121, 22);
            toolStripLabel1.Text = "Suppliers Database";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.AutoSize = false;
            toolStripTextBox1.BackColor = Color.White;
            toolStripTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 25);
            toolStripTextBox1.Tag = "Search";
            toolStripTextBox1.KeyDown += toolStripTextBox1_KeyDown;
            // 
            // searchToolStripButton
            // 
            searchToolStripButton.BackColor = SystemColors.ControlLight;
            searchToolStripButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchToolStripButton.ForeColor = SystemColors.ActiveCaptionText;
            searchToolStripButton.Image = (Image)resources.GetObject("searchToolStripButton.Image");
            searchToolStripButton.ImageTransparentColor = Color.Magenta;
            searchToolStripButton.Name = "searchToolStripButton";
            searchToolStripButton.Size = new Size(67, 22);
            searchToolStripButton.Text = "Search";
            searchToolStripButton.Click += searchToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // refreshToolStripButton
            // 
            refreshToolStripButton.Alignment = ToolStripItemAlignment.Right;
            refreshToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            refreshToolStripButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            refreshToolStripButton.Image = (Image)resources.GetObject("refreshToolStripButton.Image");
            refreshToolStripButton.ImageTransparentColor = Color.Magenta;
            refreshToolStripButton.Name = "refreshToolStripButton";
            refreshToolStripButton.Size = new Size(23, 22);
            refreshToolStripButton.Tag = "";
            refreshToolStripButton.Text = "Refresh";
            refreshToolStripButton.Click += refreshToolStripButton_Click;
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.Alignment = ToolStripItemAlignment.Right;
            helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            helpToolStripButton.Image = (Image)resources.GetObject("helpToolStripButton.Image");
            helpToolStripButton.ImageTransparentColor = Color.Magenta;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new Size(23, 22);
            helpToolStripButton.Text = "Help";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripButton, refreshToolStripButton, toolStripSeparator1, searchToolStripButton, toolStripTextBox1, toolStripSeparator4, toolStripLabel1 });
            toolStrip1.Location = new Point(0, 425);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 21;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // gridSuppliersDb
            // 
            gridSuppliersDb.AllowUserToAddRows = false;
            gridSuppliersDb.AllowUserToDeleteRows = false;
            gridSuppliersDb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridSuppliersDb.BackgroundColor = SystemColors.Control;
            gridSuppliersDb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSuppliersDb.Columns.AddRange(new DataGridViewColumn[] { cod_ch_func, nome_func, data_nasc, cod_cpf, num_tel, email, ativ_atl });
            gridSuppliersDb.Dock = DockStyle.Fill;
            gridSuppliersDb.GridColor = SystemColors.Control;
            gridSuppliersDb.Location = new Point(0, 0);
            gridSuppliersDb.MultiSelect = false;
            gridSuppliersDb.Name = "gridSuppliersDb";
            gridSuppliersDb.ReadOnly = true;
            gridSuppliersDb.RowTemplate.Height = 25;
            gridSuppliersDb.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridSuppliersDb.Size = new Size(800, 450);
            gridSuppliersDb.TabIndex = 22;
            // 
            // frmSuppliersDb
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(gridSuppliersDb);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSuppliersDb";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Suppliers Database";
            WindowState = FormWindowState.Maximized;
            Load += frmSuppliersDb_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridSuppliersDb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn num_tel;
        private DataGridViewTextBoxColumn cod_cpf;
        private DataGridViewTextBoxColumn data_nasc;
        private DataGridViewTextBoxColumn nome_func;
        private DataGridViewTextBoxColumn cod_ch_func;
        private DataGridViewTextBoxColumn ativ_atl;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton searchToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton refreshToolStripButton;
        private ToolStripButton helpToolStripButton;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator4;
        private DataGridView gridSuppliersDb;
    }
}