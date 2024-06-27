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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            // Instancia da Form Cadastrar Aluno no Mdi
            frmCadastroAluno openMdi_CadastroAluno = new frmCadastroAluno();
            openMdi_CadastroAluno.MdiParent = this;
            openMdi_CadastroAluno.Show();
        }

        private void editarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            frmEditarAluno openMdi_EditarAluno = new frmEditarAluno();
            openMdi_EditarAluno.MdiParent = this;
            openMdi_EditarAluno.Show();
        }

        private void consultarTabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            frmConsultaTabela openMdi_ConsultarTabela = new frmConsultaTabela();
            openMdi_ConsultarTabela.MdiParent = this;
            openMdi_ConsultarTabela.Show();
        }
    }
}
