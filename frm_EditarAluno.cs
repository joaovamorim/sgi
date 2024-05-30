using System.Data;
using MySql.Data.MySqlClient;

namespace SAA
{
    public partial class frm_EditarAluno : Form
    {
        public frm_EditarAluno()
        {
            InitializeComponent();
        }

        // Load do frm
        private void frm_EditarAluno_Load(object sender, EventArgs e)
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
                    grid_EditarAluno.Rows.Add(linha.ItemArray);
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

        private void LimparTextsBox()
        {
            txtBox_NomeCompleto.Clear();
            mask_DataNascimento.Clear();
            mask_CPF.Clear();
            mask_Telefone.Clear();
            txtBox_Email.Clear();
        }

        private void btn_EditarAluno_Click(object sender, EventArgs e)
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

                    int matricula = (int)grid_EditarAluno.SelectedRows[0].Cells[0].Value;
                    string nome = txtBox_NomeCompleto.Text;
                    string dataNascimento = mask_DataNascimento.Text;
                    string cpf = mask_CPF.Text;
                    string telefone = mask_Telefone.Text;
                    string email = txtBox_Email.Text;

                    string query = "UPDATE alunos SET nome = '" + nome + "', data_nascimento = '" + dataNascimento + "', cpf = '" + cpf + "', telefone = '" + telefone + "', email = '" + email + "' WHERE matricula LIKE '" + matricula + "'";

                    comando.CommandText = query;

                    comando.ExecuteNonQuery();

                    lbl_ResultadoMsg.Text = "Registro Alterado com Sucesso!";

                    comando.Dispose();
                }
                catch (Exception ex)
                {
                    lbl_ResultadoMsg.Text = ex.Message;
                }
                finally
                {
                    LimparTextsBox();
                    
                    RefreshTable();

                    conexao.Close();
                }
            }
        }

        private void RefreshTable()
        {
            grid_EditarAluno.Rows.Clear();

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
                    grid_EditarAluno.Rows.Add(linha.ItemArray);
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

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            txtBox_Pesquisar.Clear();
            grid_EditarAluno.Rows.Clear();

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
                    grid_EditarAluno.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception Error)
            {
                grid_EditarAluno.Rows.Clear();
                MessageBox.Show("Erro ao Consultar Dados.\n" + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btn_DeletarRegistro_Click(object sender, EventArgs e)
        {
            string strConnection = "server=127.0.0.1;User Id=root;database=academia;password=1234";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                int matricula = (int)grid_EditarAluno.SelectedRows[0].Cells[0].Value;

                comando.CommandText = "DELETE FROM alunos WHERE matricula = '" + matricula + "'";

                comando.ExecuteNonQuery();

                lbl_ResultadoMsg.Text = "Registro excluido com Sucesso!";

                comando.Dispose();

                RefreshTable();
            }
            catch (Exception ex)
            {
                lbl_ResultadoMsg.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
