using SGI.frm.ConsultDatabase.frmCustomersDb;

namespace SAA
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FecharFormulariosFilhos()
        {
            // percorre todos os formul�rios abertos
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                // se o formul�rio for filho
                if (Application.OpenForms[i].IsMdiChild)
                {
                    // fecha o formul�rio
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

            // Instancia da Form Cadastrar Aluno no Mdi
            frmCustomersDb openMdi_CustomersDb = new frmCustomersDb();
            openMdi_CustomersDb.MdiParent = this;
            openMdi_CustomersDb.Show();
        }
    }
}
