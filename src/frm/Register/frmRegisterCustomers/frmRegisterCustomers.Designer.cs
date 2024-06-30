namespace SGI.frm.Register.frmRegisterCustomers
{
    partial class frmRegisterCustomers
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
            optionsToolStrip = new ToolStrip();
            statusLabel = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            lblName = new Label();
            txtName = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblDateBirth = new Label();
            txtDateBirth = new MaskedTextBox();
            lblCpf = new Label();
            txtCpf = new MaskedTextBox();
            txtTelephone = new MaskedTextBox();
            lblTelephone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblStatus = new Label();
            radioActive = new RadioButton();
            radioInactive = new RadioButton();
            groupRegister = new GroupBox();
            btnRegisterUser = new Button();
            optionsToolStrip.SuspendLayout();
            groupRegister.SuspendLayout();
            SuspendLayout();
            // 
            // optionsToolStrip
            // 
            optionsToolStrip.BackColor = SystemColors.Window;
            optionsToolStrip.Dock = DockStyle.Bottom;
            optionsToolStrip.Items.AddRange(new ToolStripItem[] { statusLabel, toolStripSeparator1 });
            optionsToolStrip.Location = new Point(0, 1052);
            optionsToolStrip.Name = "optionsToolStrip";
            optionsToolStrip.Size = new Size(1920, 28);
            optionsToolStrip.TabIndex = 0;
            optionsToolStrip.Text = "toolStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(173, 25);
            statusLabel.Text = "Register Customers";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(139, 45);
            lblName.Name = "lblName";
            lblName.Size = new Size(128, 50);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(150, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(228, 39);
            txtName.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // lblDateBirth
            // 
            lblDateBirth.AutoSize = true;
            lblDateBirth.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateBirth.Location = new Point(139, 144);
            lblDateBirth.Name = "lblDateBirth";
            lblDateBirth.Size = new Size(239, 50);
            lblDateBirth.TabIndex = 3;
            lblDateBirth.Text = "Date of birth:";
            // 
            // txtDateBirth
            // 
            txtDateBirth.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateBirth.Location = new Point(150, 197);
            txtDateBirth.Mask = "00/00/0000";
            txtDateBirth.Name = "txtDateBirth";
            txtDateBirth.Size = new Size(228, 39);
            txtDateBirth.TabIndex = 4;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCpf.Location = new Point(436, 45);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(92, 50);
            lblCpf.TabIndex = 5;
            lblCpf.Text = "CPF:";
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.Location = new Point(447, 98);
            txtCpf.Mask = "000\\.000\\.000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(228, 39);
            txtCpf.TabIndex = 6;
            // 
            // txtTelephone
            // 
            txtTelephone.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelephone.Location = new Point(447, 197);
            txtTelephone.Mask = "(00) 00000-0000";
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(228, 39);
            txtTelephone.TabIndex = 8;
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelephone.Location = new Point(436, 144);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(197, 50);
            lblTelephone.TabIndex = 7;
            lblTelephone.Text = "Telephone:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(150, 304);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 39);
            txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(150, 251);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(133, 50);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "E-mail:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(447, 251);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(131, 50);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status:";
            // 
            // radioActive
            // 
            radioActive.AutoSize = true;
            radioActive.Checked = true;
            radioActive.Cursor = Cursors.Hand;
            radioActive.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radioActive.Location = new Point(458, 307);
            radioActive.Name = "radioActive";
            radioActive.Size = new Size(97, 36);
            radioActive.TabIndex = 12;
            radioActive.TabStop = true;
            radioActive.Text = "Active";
            radioActive.UseVisualStyleBackColor = true;
            // 
            // radioInactive
            // 
            radioInactive.AutoSize = true;
            radioInactive.Cursor = Cursors.Hand;
            radioInactive.Enabled = false;
            radioInactive.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radioInactive.Location = new Point(561, 307);
            radioInactive.Name = "radioInactive";
            radioInactive.Size = new Size(114, 36);
            radioInactive.TabIndex = 13;
            radioInactive.Text = "Inactive";
            radioInactive.UseVisualStyleBackColor = true;
            // 
            // groupRegister
            // 
            groupRegister.BackColor = SystemColors.Control;
            groupRegister.Controls.Add(btnRegisterUser);
            groupRegister.Controls.Add(lblName);
            groupRegister.Controls.Add(radioInactive);
            groupRegister.Controls.Add(txtName);
            groupRegister.Controls.Add(radioActive);
            groupRegister.Controls.Add(lblDateBirth);
            groupRegister.Controls.Add(lblStatus);
            groupRegister.Controls.Add(txtDateBirth);
            groupRegister.Controls.Add(txtEmail);
            groupRegister.Controls.Add(lblCpf);
            groupRegister.Controls.Add(lblEmail);
            groupRegister.Controls.Add(txtCpf);
            groupRegister.Controls.Add(txtTelephone);
            groupRegister.Controls.Add(lblTelephone);
            groupRegister.FlatStyle = FlatStyle.System;
            groupRegister.Location = new Point(553, 221);
            groupRegister.Name = "groupRegister";
            groupRegister.Size = new Size(814, 481);
            groupRegister.TabIndex = 14;
            groupRegister.TabStop = false;
            groupRegister.Text = "Register";
            // 
            // btnRegisterUser
            // 
            btnRegisterUser.Cursor = Cursors.Hand;
            btnRegisterUser.DialogResult = DialogResult.OK;
            btnRegisterUser.FlatStyle = FlatStyle.System;
            btnRegisterUser.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegisterUser.Location = new Point(150, 368);
            btnRegisterUser.Name = "btnRegisterUser";
            btnRegisterUser.Size = new Size(525, 68);
            btnRegisterUser.TabIndex = 15;
            btnRegisterUser.Text = "Register User";
            btnRegisterUser.UseVisualStyleBackColor = true;
            btnRegisterUser.Click += btnRegisterUser_Click;
            // 
            // frmRegisterCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1920, 1080);
            Controls.Add(groupRegister);
            Controls.Add(optionsToolStrip);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegisterCustomers";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegisterCustomers";
            WindowState = FormWindowState.Maximized;
            Load += frmRegisterCustomers_Load;
            optionsToolStrip.ResumeLayout(false);
            optionsToolStrip.PerformLayout();
            groupRegister.ResumeLayout(false);
            groupRegister.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip optionsToolStrip;
        private ToolStripLabel statusLabel;
        private ToolStripSeparator toolStripSeparator1;
        private Label lblName;
        private TextBox txtName;
        private System.Windows.Forms.Timer timer1;
        private Label lblDateBirth;
        private MaskedTextBox txtDateBirth;
        private Label lblCpf;
        private MaskedTextBox txtCpf;
        private MaskedTextBox txtTelephone;
        private Label lblTelephone;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblStatus;
        private RadioButton radioActive;
        private RadioButton radioInactive;
        private GroupBox groupRegister;
        private Button btnRegisterUser;
    }
}