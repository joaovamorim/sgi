namespace SAA
{
    public partial class frm_Main : Form
    {
        public frm_Main()
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

        private void cadastrarAlunoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            // Instancia da Form Cadastrar Aluno no Mdi
            frm_CadastroAluno openMdi_CadastroAluno = new frm_CadastroAluno();
            openMdi_CadastroAluno.MdiParent = this;
            openMdi_CadastroAluno.Show();
        }

        private void consultarAlunoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            
        }

        private void editarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            frm_EditarAluno openMdi_EditarAluno = new frm_EditarAluno();
            openMdi_EditarAluno.MdiParent = this;
            openMdi_EditarAluno .Show();
        }
    }
}
