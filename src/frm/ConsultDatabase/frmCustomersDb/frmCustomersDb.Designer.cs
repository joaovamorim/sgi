﻿namespace SGI.frm.ConsultDatabase.frmCustomersDb
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomersDb));
            toolStrip1 = new ToolStrip();
            helpToolStripButton = new ToolStripButton();
            refreshToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            searchToolStripButton = new ToolStripButton();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            gridCustomersDb = new DataGridView();
            cod_ch_func = new DataGridViewTextBoxColumn();
            nome_func = new DataGridViewTextBoxColumn();
            data_nasc = new DataGridViewTextBoxColumn();
            cod_cpf = new DataGridViewTextBoxColumn();
            num_tel = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            ativ_atl = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCustomersDb).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripButton, refreshToolStripButton, toolStripSeparator1, searchToolStripButton, toolStripTextBox1, toolStripSeparator4, toolStripLabel1 });
            toolStrip1.Location = new Point(0, 425);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
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
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.BackColor = SystemColors.Control;
            toolStripLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(129, 22);
            toolStripLabel1.Text = "Customers Database";
            // 
            // gridCustomersDb
            // 
            gridCustomersDb.AllowUserToAddRows = false;
            gridCustomersDb.AllowUserToDeleteRows = false;
            gridCustomersDb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCustomersDb.BackgroundColor = SystemColors.Control;
            gridCustomersDb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCustomersDb.Columns.AddRange(new DataGridViewColumn[] { cod_ch_func, nome_func, data_nasc, cod_cpf, num_tel, email, ativ_atl });
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
            // cod_ch_func
            // 
            cod_ch_func.HeaderText = "MATRÍCULA";
            cod_ch_func.Name = "cod_ch_func";
            cod_ch_func.ReadOnly = true;
            // 
            // nome_func
            // 
            nome_func.HeaderText = "NOME";
            nome_func.Name = "nome_func";
            nome_func.ReadOnly = true;
            // 
            // data_nasc
            // 
            data_nasc.HeaderText = "DATA NASCIMENTO";
            data_nasc.Name = "data_nasc";
            data_nasc.ReadOnly = true;
            // 
            // cod_cpf
            // 
            cod_cpf.HeaderText = "CPF";
            cod_cpf.Name = "cod_cpf";
            cod_cpf.ReadOnly = true;
            // 
            // num_tel
            // 
            num_tel.HeaderText = "TELEFONE";
            num_tel.Name = "num_tel";
            num_tel.ReadOnly = true;
            // 
            // email
            // 
            email.HeaderText = "E-MAIL";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // ativ_atl
            // 
            ativ_atl.HeaderText = "STATUS";
            ativ_atl.Name = "ativ_atl";
            ativ_atl.ReadOnly = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
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
            Text = "Customers Database";
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
        private DataGridViewTextBoxColumn cod_ch_func;
        private DataGridViewTextBoxColumn nome_func;
        private DataGridViewTextBoxColumn data_nasc;
        private DataGridViewTextBoxColumn cod_cpf;
        private DataGridViewTextBoxColumn num_tel;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn ativ_atl;
        private ToolStripButton searchToolStripButton;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripSeparator toolStripSeparator1;
    }
}