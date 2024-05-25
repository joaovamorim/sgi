﻿using MySql.Data.MySqlClient;
using System.Data;

namespace SAA
{
    public partial class frm_ConsultarTabela : Form
    {
        public frm_ConsultarTabela()
        {
            InitializeComponent();
        }

        private void frm_ConsultarTabela_Load(object sender, EventArgs e)
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
                    grid_ConsultarTabela.Rows.Add(linha.ItemArray);
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

        private void btn_RecarregarTabela_Click(object sender, EventArgs e)
        {

        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            txtBox_Pesquisar.Clear();
            grid_ConsultarTabela.Rows.Clear();

            string strConnection = "server=127.0.0.1;User Id=root;database=academia;password=1234";

            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                string query = "SELECT * FROM alunos";

                if (txtBox_Pesquisar.Text != "")
                {
                    query = "SELECT * FROM alunos WHERE cpf LIKE '" + txtBox_Pesquisar.Text + "'";
                }

                DataTable dados = new DataTable();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConnection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    grid_ConsultarTabela.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                grid_ConsultarTabela.Rows.Clear();
                MessageBox.Show("Erro ao Pesquisar: " + ex);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
