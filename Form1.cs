namespace SAA
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancia da Form Cadastrar Aluno no Mdi
            frm_CadastroAluno openMdi_CadastroAluno = new frm_CadastroAluno();
            openMdi_CadastroAluno.MdiParent = this;
            openMdi_CadastroAluno.Show();

            // Instancia da Form TabelaDB no Mdi
            frm_TabelaDB openMdi_TabelaDB = new frm_TabelaDB();
            openMdi_TabelaDB.MdiParent = this;
            openMdi_TabelaDB.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
