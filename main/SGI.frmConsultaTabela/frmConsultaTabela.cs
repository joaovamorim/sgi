using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;

namespace SAA
{
    public partial class frmConsultaTabela : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["OracleConnectionString"].ConnectionString.ToString();

        public frmConsultaTabela()
        {
            InitializeComponent();
        }

        private void frm_ConsultarTabela_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;


            OracleConnection conexao = new OracleConnection(connectionString);

            try
            {
                string query = "SELECT * FROM ALUNOS";

                DataTable dados = new DataTable();

                OracleDataAdapter adaptador = new OracleDataAdapter(query, connectionString);

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

            OracleConnection conexao = new OracleConnection(connectionString);

            try
            {
                string query = "SELECT * FROM ALUNOS";

                DataTable dados = new DataTable();

                OracleDataAdapter adaptador = new OracleDataAdapter(query, connectionString);

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
                OracleConnection conexao = new OracleConnection(connectionString);

                string query = "SELECT * FROM ALUNOS";

                query = "SELECT * FROM ALUNOS WHERE nome LIKE '" + text?.ToUpper() + "'";

                try
                {
                    DataTable dados = new DataTable();

                    OracleDataAdapter adaptador = new OracleDataAdapter(query, connectionString);

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
