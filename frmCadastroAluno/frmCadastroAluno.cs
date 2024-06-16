using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace SAA
{
    public partial class frmCadastroAluno : Form
    {
        public frmCadastroAluno()
        {
            InitializeComponent();
        }

        private async void frm_CadastroAluno_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;


            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.0.85)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=xepdb1)));Persist Security Info=True;User ID=sys;Password=root;DBA Privilege=SYSDBA";
            OracleConnection connection = new OracleConnection(connectionString);

            try
            {
                string query = "SELECT * FROM ALUNOS";

                DataTable dados = new DataTable();

                OracleDataAdapter adaptador = new OracleDataAdapter(query, connectionString);

                await connection.OpenAsync();

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
                await connection.CloseAsync();
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

        private async void RefreshTable()
        {
            grid_CadastroAluno.Rows.Clear();

            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.0.85)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=xepdb1)));Persist Security Info=True;User ID=sys;Password=root;DBA Privilege=SYSDBA";
            OracleConnection connection = new OracleConnection(connectionString);

            try
            {
                string query = "SELECT * FROM ALUNOS";

                DataTable dados = new DataTable();

                OracleDataAdapter adaptador = new OracleDataAdapter(query, connectionString);

                await connection.OpenAsync();

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
                await connection.CloseAsync();
            }
        }

        private async void btn_CadastrarAluno_Click(object sender, EventArgs e)
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
                string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.0.85)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=xepdb1)));Persist Security Info=True;User ID=sys;Password=root;DBA Privilege=SYSDBA";
                OracleConnection connection = new OracleConnection(connectionString);

                try
                {
                    await connection.OpenAsync();

                    OracleCommand comando = new OracleCommand();
                    comando.Connection = connection;

                    int matricula = new Random(DateTime.Now.Millisecond).Next(100000, 1000000);
                    string NOME = txtBox_NomeCompleto.Text;
                    string data_nascimento = mask_DataNascimento.Text;
                    string cpf = mask_CPF.Text;
                    string telefone = mask_Telefone.Text;
                    string email = txtBox_Email.Text;
                    string status = "Ativo";

                    comando.CommandText = "INSERT INTO ALUNOS VALUES (" + matricula + ", '" + NOME + "', '" + data_nascimento + "', '" + cpf + "', '" + telefone + "', '" + email + "', '" + status + "')";

                    await comando.ExecuteNonQueryAsync();

                    lbl_CadastroAlunoMsg.Text = "Registro inserido com Sucesso!";

                    await comando.DisposeAsync();
                }
                catch (Exception ex)
                {
                    lbl_CadastroAlunoMsg.Text = ex.Message;
                }
                finally
                {
                    LimparTextsBox();

                    RefreshTable();

                    await connection.CloseAsync();
                }
            }
        }

        private async void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            txtBox_Pesquisar.Clear();
            grid_CadastroAluno.Rows.Clear();

            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.0.85)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=xepdb1)));Persist Security Info=True;User ID=sys;Password=root;DBA Privilege=SYSDBA";

            OracleConnection connection = new OracleConnection(connectionString);

            try
            {
                string query = "SELECT * FROM ALUNOS";

                if (txtBox_Pesquisar.Text != "")
                {
                    query = "SELECT * FROM ALUNOS WHERE NOME LIKE '" + txtBox_Pesquisar.Text + "'";
                }

                DataTable dados = new DataTable();

                OracleDataAdapter adaptador = new OracleDataAdapter(query, connectionString);

                await connection.OpenAsync();

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
                await connection.CloseAsync();
            }
        }
    }
}
