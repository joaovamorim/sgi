namespace SAA
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            editarAlunoToolStripMenuItem = new ToolStripMenuItem();
            consultarAlunoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem, cadastrarToolStripMenuItem, editarAlunoToolStripMenuItem, consultarAlunoToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            // 
            // opçõesToolStripMenuItem
            // 
            resources.ApplyResources(opçõesToolStripMenuItem, "opçõesToolStripMenuItem");
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            // 
            // sairToolStripMenuItem
            // 
            resources.ApplyResources(sairToolStripMenuItem, "sairToolStripMenuItem");
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Tag = "Fechar App";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            resources.ApplyResources(cadastrarToolStripMenuItem, "cadastrarToolStripMenuItem");
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtosToolStripMenuItem, fornecedoresToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Click += cadastrarAlunoToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            resources.ApplyResources(clientesToolStripMenuItem, "clientesToolStripMenuItem");
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            // 
            // produtosToolStripMenuItem
            // 
            resources.ApplyResources(produtosToolStripMenuItem, "produtosToolStripMenuItem");
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            // 
            // fornecedoresToolStripMenuItem
            // 
            resources.ApplyResources(fornecedoresToolStripMenuItem, "fornecedoresToolStripMenuItem");
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            // 
            // editarAlunoToolStripMenuItem
            // 
            resources.ApplyResources(editarAlunoToolStripMenuItem, "editarAlunoToolStripMenuItem");
            editarAlunoToolStripMenuItem.Name = "editarAlunoToolStripMenuItem";
            editarAlunoToolStripMenuItem.Click += editarAlunoToolStripMenuItem_Click;
            // 
            // consultarAlunoToolStripMenuItem
            // 
            resources.ApplyResources(consultarAlunoToolStripMenuItem, "consultarAlunoToolStripMenuItem");
            consultarAlunoToolStripMenuItem.Name = "consultarAlunoToolStripMenuItem";
            consultarAlunoToolStripMenuItem.Click += consultarTabelaToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            HelpButton = true;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
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
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem consultarAlunoToolStripMenuItem;
        private ToolStripMenuItem editarAlunoToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
    }
}
