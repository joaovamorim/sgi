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
            menuStripTop = new MenuStrip();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            consultDatabaseToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem1 = new ToolStripMenuItem();
            productsToolStripMenuItem1 = new ToolStripMenuItem();
            suppliersDBToolStripMenuItem = new ToolStripMenuItem();
            issuanceOfInvoicesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            financialControlToolStripMenuItem = new ToolStripMenuItem();
            billsToPayToolStripMenuItem = new ToolStripMenuItem();
            billsToReceiveToolStripMenuItem = new ToolStripMenuItem();
            cashFlowToolStripMenuItem = new ToolStripMenuItem();
            issuanceOfBillsToolStripMenuItem = new ToolStripMenuItem();
            inventoryControlToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            pDVToolStripMenuItem = new ToolStripMenuItem();
            budgetsToolStripMenuItem = new ToolStripMenuItem();
            orderOfServiceToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStripTop.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripTop
            // 
            resources.ApplyResources(menuStripTop, "menuStripTop");
            menuStripTop.BackColor = SystemColors.Control;
            menuStripTop.GripStyle = ToolStripGripStyle.Visible;
            menuStripTop.Items.AddRange(new ToolStripItem[] { toolsToolStripMenuItem, registerToolStripMenuItem, financialControlToolStripMenuItem, inventoryControlToolStripMenuItem, salesToolStripMenuItem, helpToolStripMenuItem });
            menuStripTop.Name = "menuStripTop";
            menuStripTop.RenderMode = ToolStripRenderMode.Professional;
            // 
            // toolsToolStripMenuItem
            // 
            resources.ApplyResources(toolsToolStripMenuItem, "toolsToolStripMenuItem");
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultDatabaseToolStripMenuItem, issuanceOfInvoicesToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            // 
            // consultDatabaseToolStripMenuItem
            // 
            resources.ApplyResources(consultDatabaseToolStripMenuItem, "consultDatabaseToolStripMenuItem");
            consultDatabaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customersToolStripMenuItem1, productsToolStripMenuItem1, suppliersDBToolStripMenuItem });
            consultDatabaseToolStripMenuItem.Name = "consultDatabaseToolStripMenuItem";
            // 
            // customersToolStripMenuItem1
            // 
            resources.ApplyResources(customersToolStripMenuItem1, "customersToolStripMenuItem1");
            customersToolStripMenuItem1.Name = "customersToolStripMenuItem1";
            customersToolStripMenuItem1.Click += customersToolStripMenuItem1_Click;
            // 
            // productsToolStripMenuItem1
            // 
            resources.ApplyResources(productsToolStripMenuItem1, "productsToolStripMenuItem1");
            productsToolStripMenuItem1.Name = "productsToolStripMenuItem1";
            productsToolStripMenuItem1.Click += productsToolStripMenuItem1_Click;
            // 
            // suppliersDBToolStripMenuItem
            // 
            resources.ApplyResources(suppliersDBToolStripMenuItem, "suppliersDBToolStripMenuItem");
            suppliersDBToolStripMenuItem.Name = "suppliersDBToolStripMenuItem";
            suppliersDBToolStripMenuItem.Click += suppliersDBToolStripMenuItem_Click;
            // 
            // issuanceOfInvoicesToolStripMenuItem
            // 
            resources.ApplyResources(issuanceOfInvoicesToolStripMenuItem, "issuanceOfInvoicesToolStripMenuItem");
            issuanceOfInvoicesToolStripMenuItem.Name = "issuanceOfInvoicesToolStripMenuItem";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(exitToolStripMenuItem, "exitToolStripMenuItem");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Tag = "Fechar App";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // registerToolStripMenuItem
            // 
            resources.ApplyResources(registerToolStripMenuItem, "registerToolStripMenuItem");
            registerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customersToolStripMenuItem, productsToolStripMenuItem, suppliersToolStripMenuItem });
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            // 
            // customersToolStripMenuItem
            // 
            resources.ApplyResources(customersToolStripMenuItem, "customersToolStripMenuItem");
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Click += customersToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            resources.ApplyResources(productsToolStripMenuItem, "productsToolStripMenuItem");
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            // 
            // suppliersToolStripMenuItem
            // 
            resources.ApplyResources(suppliersToolStripMenuItem, "suppliersToolStripMenuItem");
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            // 
            // financialControlToolStripMenuItem
            // 
            resources.ApplyResources(financialControlToolStripMenuItem, "financialControlToolStripMenuItem");
            financialControlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { billsToPayToolStripMenuItem, billsToReceiveToolStripMenuItem, cashFlowToolStripMenuItem, issuanceOfBillsToolStripMenuItem });
            financialControlToolStripMenuItem.Name = "financialControlToolStripMenuItem";
            // 
            // billsToPayToolStripMenuItem
            // 
            resources.ApplyResources(billsToPayToolStripMenuItem, "billsToPayToolStripMenuItem");
            billsToPayToolStripMenuItem.Name = "billsToPayToolStripMenuItem";
            // 
            // billsToReceiveToolStripMenuItem
            // 
            resources.ApplyResources(billsToReceiveToolStripMenuItem, "billsToReceiveToolStripMenuItem");
            billsToReceiveToolStripMenuItem.Name = "billsToReceiveToolStripMenuItem";
            // 
            // cashFlowToolStripMenuItem
            // 
            resources.ApplyResources(cashFlowToolStripMenuItem, "cashFlowToolStripMenuItem");
            cashFlowToolStripMenuItem.Name = "cashFlowToolStripMenuItem";
            // 
            // issuanceOfBillsToolStripMenuItem
            // 
            resources.ApplyResources(issuanceOfBillsToolStripMenuItem, "issuanceOfBillsToolStripMenuItem");
            issuanceOfBillsToolStripMenuItem.Name = "issuanceOfBillsToolStripMenuItem";
            // 
            // inventoryControlToolStripMenuItem
            // 
            resources.ApplyResources(inventoryControlToolStripMenuItem, "inventoryControlToolStripMenuItem");
            inventoryControlToolStripMenuItem.Name = "inventoryControlToolStripMenuItem";
            // 
            // salesToolStripMenuItem
            // 
            resources.ApplyResources(salesToolStripMenuItem, "salesToolStripMenuItem");
            salesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pDVToolStripMenuItem, budgetsToolStripMenuItem, orderOfServiceToolStripMenuItem });
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            // 
            // pDVToolStripMenuItem
            // 
            resources.ApplyResources(pDVToolStripMenuItem, "pDVToolStripMenuItem");
            pDVToolStripMenuItem.Name = "pDVToolStripMenuItem";
            // 
            // budgetsToolStripMenuItem
            // 
            resources.ApplyResources(budgetsToolStripMenuItem, "budgetsToolStripMenuItem");
            budgetsToolStripMenuItem.Name = "budgetsToolStripMenuItem";
            // 
            // orderOfServiceToolStripMenuItem
            // 
            resources.ApplyResources(orderOfServiceToolStripMenuItem, "orderOfServiceToolStripMenuItem");
            orderOfServiceToolStripMenuItem.Name = "orderOfServiceToolStripMenuItem";
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(helpToolStripMenuItem, "helpToolStripMenuItem");
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // contentsToolStripMenuItem
            // 
            resources.ApplyResources(contentsToolStripMenuItem, "contentsToolStripMenuItem");
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            // 
            // indexToolStripMenuItem
            // 
            resources.ApplyResources(indexToolStripMenuItem, "indexToolStripMenuItem");
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            // 
            // searchToolStripMenuItem
            // 
            resources.ApplyResources(searchToolStripMenuItem, "searchToolStripMenuItem");
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(toolStripSeparator5, "toolStripSeparator5");
            toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(aboutToolStripMenuItem, "aboutToolStripMenuItem");
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuStripTop);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            HelpButton = true;
            IsMdiContainer = true;
            MainMenuStrip = menuStripTop;
            Name = "frmMain";
            WindowState = FormWindowState.Maximized;
            menuStripTop.ResumeLayout(false);
            menuStripTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStripTop;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem inventoryControlToolStripMenuItem;
        private ToolStripMenuItem financialControlToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem pDVToolStripMenuItem;
        private ToolStripMenuItem budgetsToolStripMenuItem;
        private ToolStripMenuItem orderOfServiceToolStripMenuItem;
        private ToolStripMenuItem billsToPayToolStripMenuItem;
        private ToolStripMenuItem billsToReceiveToolStripMenuItem;
        private ToolStripMenuItem cashFlowToolStripMenuItem;
        private ToolStripMenuItem issuanceOfBillsToolStripMenuItem;
        private ToolStripMenuItem consultDatabaseToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem1;
        private ToolStripMenuItem issuanceOfInvoicesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem productsToolStripMenuItem1;
        private ToolStripMenuItem suppliersDBToolStripMenuItem;
    }
}
