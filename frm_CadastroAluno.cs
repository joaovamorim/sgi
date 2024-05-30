﻿using System.Data;
using MySql.Data.MySqlClient;

namespace SAA
{
    public partial class frm_CadastroAluno : Form
    {
        public frm_CadastroAluno()
        {
            InitializeComponent();
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

        // Verifica se os campos estão vazios
        // private bool textBoxVazias()
        // {
        //     foreach (Control c in this.Controls)
        //         if (c is TextBox)
        //         {
        //             TextBox textBox = c as TextBox;
        //             if (string.IsNullOrWhiteSpace(textBox.Text))
        //                 return true;
        //         }
        //     return false;
        // }

        private void btn_CadastrarAluno_Click(object sender, EventArgs e)
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

                RefreshTable();
            }
            catch (Exception ex)
            {
               lbl_CadastroAlunoMsg.Text = ex.Message;
            }
            finally
            {
               conexao.Close();
            }
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
