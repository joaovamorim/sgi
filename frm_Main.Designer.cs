﻿namespace SAA
{
    partial class frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastrarAlunoToolStripMenuItem = new ToolStripMenuItem();
            consultarAlunoToolStripMenuItem = new ToolStripMenuItem();
            editarAlunoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem, cadastrarAlunoToolStripMenuItem, consultarAlunoToolStripMenuItem, editarAlunoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(50, 23);
            opçõesToolStripMenuItem.Text = "Menu";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Tag = "Fechar App";
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cadastrarAlunoToolStripMenuItem
            // 
            cadastrarAlunoToolStripMenuItem.Name = "cadastrarAlunoToolStripMenuItem";
            cadastrarAlunoToolStripMenuItem.Size = new Size(104, 23);
            cadastrarAlunoToolStripMenuItem.Text = "Cadastrar Aluno";
            cadastrarAlunoToolStripMenuItem.Click += cadastrarAlunoToolStripMenuItem_Click_1;
            // 
            // consultarAlunoToolStripMenuItem
            // 
            consultarAlunoToolStripMenuItem.Name = "consultarAlunoToolStripMenuItem";
            consultarAlunoToolStripMenuItem.Size = new Size(106, 23);
            consultarAlunoToolStripMenuItem.Text = "Consultar Tabela";
            consultarAlunoToolStripMenuItem.Click += consultarAlunoToolStripMenuItem_Click_1;
            // 
            // editarAlunoToolStripMenuItem
            // 
            editarAlunoToolStripMenuItem.Name = "editarAlunoToolStripMenuItem";
            editarAlunoToolStripMenuItem.Size = new Size(84, 23);
            editarAlunoToolStripMenuItem.Text = "Editar Aluno";
            editarAlunoToolStripMenuItem.Click += editarAlunoToolStripMenuItem_Click;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SAA - Sistemas de Alunos Academia";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem cadastrarAlunoToolStripMenuItem;
        private ToolStripMenuItem consultarAlunoToolStripMenuItem;
        private ToolStripMenuItem editarAlunoToolStripMenuItem;
    }
}
