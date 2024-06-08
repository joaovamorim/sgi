using MySql.Data.MySqlClient;
using System.Data;
using System.Data.OracleClient;

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


            string strConnection = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.0.85)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=XEPDB1)));Persist Security Info=True;User ID=system;Password=root;";
            OracleConnection conexao = new OracleConnection(strConnection);

            try
            {
                string query = @"SELECT *
                                FROM all_objects
                                WHERE object_type in ('TABLE', 'VIEW')
                                AND object_name = 'alunos.academia'";

                DataTable dados = new DataTable();

                OracleDataAdapter adaptador = new OracleDataAdapter(query, strConnection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    grid_ConsultarTabela.Rows.Add(linha.ItemArray);
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

        private void btn_RecarregarTabela_Click(object sender, EventArgs e)
        {
            grid_ConsultarTabela.Rows.Clear();

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
            catch (Exception Error)
            {
                MessageBox.Show("Erro ao Recarregar a Tabela.\n" + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            txtBox_Pesquisar.Clear();
            grid_ConsultarTabela.Rows.Clear();
            string text = txtBox_Pesquisar.Text.ToUpper();

            if (text != "" || text != null)
            {
                MessageBox.Show("O preenchimento do campo é obrigatório.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string strConnection = "server=127.0.0.1;User Id=root;database=academia;password=1234";
                MySqlConnection conexao = new MySqlConnection(strConnection);

                string query = "SELECT * FROM alunos";

                query = "SELECT * FROM alunos WHERE nome LIKE '" + text.ToUpper() + "'";

                try
                {
                    DataTable dados = new DataTable();

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConnection);

                    conexao.Open();

                    adaptador.Fill(dados);

                    foreach (DataRow linha in dados.Rows)
                    {
                        grid_ConsultarTabela.Rows.Add(linha.ItemArray);
                    }
                }
                catch (Exception Error)
                {
                    grid_ConsultarTabela.Rows.Clear();
                    MessageBox.Show("Erro ao Consultar Dados.\n" + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                }              
            }
        }
    }
}
