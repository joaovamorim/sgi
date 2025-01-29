using System.Reflection;
using SGI.frm.ConsultDatabase.frmCustomersDb;
using SGI.frm.ConsultDatabase.frmProductsDb;
using SGI.frm.ConsultDatabase.frmSuppliersDb;
using SGI.frm.Register.frmRegisterCustomers;

namespace SAA
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            DisplayAppVersion();
        }

        private void DisplayAppVersion()
        {
            // Obtém a versão do assembly
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text += $" | Versão: {version} - Teste";
        }

        private void FecharFormulariosFilhos()
        {
            // percorre todos os formularios abertos
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                // se o formulario for filho
                if (Application.OpenForms[i].IsMdiChild)
                {
                    // fecha o formulario
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void customersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            // Instancia da frmCustomersDb no Mdi
            frmCustomersDb openMdi_CustomersDb = new frmCustomersDb();
            openMdi_CustomersDb.MdiParent = this;
            openMdi_CustomersDb.Show();
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            // Instancia da frmProductsDb no Mdi
            frmProductsDb openMdi_ProductsDb = new frmProductsDb();
            openMdi_ProductsDb.MdiParent = this;
            openMdi_ProductsDb.Show();
        }

        private void suppliersDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            // Instancia da frmSuppliersDb no Mdi
            frmSuppliersDb openMdi_SuppliersDb = new frmSuppliersDb();
            openMdi_SuppliersDb.MdiParent = this;
            openMdi_SuppliersDb.Show();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            // Instancia da frmRegisterCustomers no Mdi
            frmRegisterCustomers openMdi_RegisterCustomers = new frmRegisterCustomers();
            openMdi_RegisterCustomers.MdiParent = this;
            openMdi_RegisterCustomers.Show();
        }
    }
}
