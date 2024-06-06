using System.Data;
using MySql.Data.MySqlClient;



namespace SAA
{
    public partial class frm_CadastroAluno : Form
    {
        public frm_CadastroAluno()
        {
            InitializeComponent();
        }

        private void LimparTextsBox()
        {
            txtBox_NomeCompleto.Clear();
            mask_DataNascimento.Clear();
            mask_CPF.Clear();
            mask_Telefone.Clear();
            txtBox_Email.Clear();
        }

        private void RefreshTable()
        {
            grid_CadastroAluno.Rows.Clear();

            string strConnection = "server=127.0.0.1;User Id=root;database=academia;password=1234";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                string query = "SELECT * FROM alunos";

                DataTable dados = new DataTable();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConnection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    grid_CadastroAluno.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conexao.Close();
            }
        }
        
        private void frm_CadastroAluno_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;


            string strConnection = "server=127.0.0.1;User Id=root;database=academia;password=1234";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                string query = "SELECT * FROM alunos";

                DataTable dados = new DataTable();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConnection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    grid_CadastroAluno.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Erro ao se conectar com Banco de Dados.\n" + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btn_CadastrarAluno_Click(object sender, EventArgs e)
        {
            if (txtBox_NomeCompleto.Text == "" || txtBox_NomeCompleto.Text == null)
            {
                MessageBox.Show("O campo Nome Completo deve estar preenchido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mask_DataNascimento.MaskCompleted == false)
            {
                MessageBox.Show("O campo Data Nascimento deve estar preenchido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mask_CPF.MaskCompleted == false)
            {
                MessageBox.Show("O campo CPF deve estar preenchido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mask_Telefone.MaskCompleted == false)
            {
                MessageBox.Show("O campo Telefone deve estar preenchido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtBox_Email.Text == "" || txtBox_Email.Text == null)
            {
                MessageBox.Show("O campo E-mail deve estar preenchido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string strConnection = "server=127.0.0.1;User Id=root;database=academia;password=1234";
                MySqlConnection conexao = new MySqlConnection(strConnection);

                try
                {
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = conexao;

                    int matricula = new Random(DateTime.Now.Millisecond).Next(100000, 1000000);
                    string nome = txtBox_NomeCompleto.Text;
                    string dataNascimento = mask_DataNascimento.Text;
                    string cpf = mask_CPF.Text;
                    string telefone = mask_Telefone.Text;
                    string email = txtBox_Email.Text;

                    comando.CommandText = "INSERT INTO alunos VALUES (" + matricula + ", '" + nome + "', '" + dataNascimento + "', '" + cpf + "', '" + telefone + "', '" + email + "')";

                    comando.ExecuteNonQuery();

                    lbl_CadastroAlunoMsg.Text = "Registro inserido com Sucesso!";

                    comando.Dispose();
                }
                catch (Exception ex)
                {
                    lbl_CadastroAlunoMsg.Text = ex.Message;
                }
                finally
                {
                    LimparTextsBox();

                    RefreshTable();

                    conexao.Close();
                }
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            txtBox_Pesquisar.Clear();
            grid_CadastroAluno.Rows.Clear();

            string strConnection = "server=127.0.0.1;User Id=root;database=academia;password=1234";

            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                string query = "SELECT * FROM alunos";

                if (txtBox_Pesquisar.Text != "")
                {
                    query = "SELECT * FROM alunos WHERE nome LIKE '" + txtBox_Pesquisar.Text + "'";
                }

                // // Aviso se o txtBox_Pesquisar estiver vazio - A Resolver
                // if (String.IsNullOrEmpty(txtBox_Pesquisar.Text))
                // {
                //     MessageBox.Show("O preenchimento do campo é obrigatório.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // }

                DataTable dados = new DataTable();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConnection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    grid_CadastroAluno.Rows.Add(linha.ItemArray);
                }

                lbl_CadastroAlunoMsg.Text = "Pesquisa realizada com Sucesso.";
            }
            catch (Exception Error)
            {
                grid_CadastroAluno.Rows.Clear();
                lbl_CadastroAlunoMsg.Text = "Erro ao Consultar Dados. " + Error.Message;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
