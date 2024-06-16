using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace SAA
{
    public partial class frmEditarAluno : Form
    {
        public frmEditarAluno()
        {
            InitializeComponent();
        }

        // Load do frm
        private void frm_EditarAluno_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;


            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.0.85)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=xepdb1)));Persist Security Info=True;User ID=sys;Password=root;DBA Privilege=SYSDBA";
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
            radio_Ativo.Checked = true;
        }

        private void TrueControlsFrm()
        {
            txtBox_NomeCompleto.Enabled = true;
            mask_DataNascimento.Enabled = true;
            mask_CPF.Enabled = true;
            mask_Telefone.Enabled = true;
            txtBox_Email.Enabled = true;
            btn_EditarAluno.Enabled = true;
            radio_Ativo.Enabled = true;
            radio_Inativo.Enabled = true;
        }

        private void FalseControlsFrm()
        {
            txtBox_NomeCompleto.Enabled = false;
            mask_DataNascimento.Enabled = false;
            mask_CPF.Enabled = false;
            mask_Telefone.Enabled = false;
            txtBox_Email.Enabled = false;
            btn_EditarAluno.Enabled = false;
            radio_Ativo .Enabled = false;
            radio_Inativo .Enabled = false;
        }

        private void grid_EditarAluno_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TrueControlsFrm();

            txtBox_NomeCompleto.Text = grid_EditarAluno.SelectedRows[0].Cells[1].Value.ToString();
            mask_DataNascimento.Text = grid_EditarAluno.SelectedRows[0].Cells[2].Value.ToString();
            mask_CPF.Text = grid_EditarAluno.SelectedRows[0].Cells[3].Value.ToString();
            mask_Telefone.Text = grid_EditarAluno.SelectedRows[0].Cells[4].Value.ToString();
            txtBox_Email.Text = grid_EditarAluno.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void RefreshTable()
        {
            grid_EditarAluno.Rows.Clear();

            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.0.85)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=xepdb1)));Persist Security Info=True;User ID=sys;Password=root;DBA Privilege=SYSDBA";
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
                    grid_EditarAluno.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                FalseControlsFrm();

                conexao.Close();
            }
        }

        private void btn_EditarAluno_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.0.85)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=xepdb1)));Persist Security Info=True;User ID=sys;Password=root;DBA Privilege=SYSDBA";
            OracleConnection conexao = new OracleConnection(connectionString);

            try
            {
                conexao.Open();

                OracleCommand comando = new OracleCommand();
                comando.Connection = conexao;

                decimal matricula = (decimal)grid_EditarAluno.SelectedRows[0].Cells[0].Value;
                string nome = txtBox_NomeCompleto.Text;
                string data_nascimento = mask_DataNascimento.Text;
                string cpf = mask_CPF.Text;
                string telefone = mask_Telefone.Text;
                string email = txtBox_Email.Text;
                string status = "";

                if (radio_Ativo.Checked == true)
                {
                    status = "Ativo";
                }
                if (radio_Inativo.Checked == true)
                {
                    status = "Inativo";
                }

                string query = "UPDATE ALUNOS SET nome = '" + nome + "', data_nascimento = '" + data_nascimento + "', cpf = '" + cpf + "', telefone = '" + telefone + "', email = '" + email + "', status = '" + status + "' WHERE matricula LIKE '" + matricula + "'";

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

        private void btn_DeletarRegistro_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.0.85)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=xepdb1)));Persist Security Info=True;User ID=sys;Password=root;DBA Privilege=SYSDBA";
            OracleConnection conexao = new OracleConnection(connectionString);

            try
            {
                conexao.Open();

                OracleCommand comando = new OracleCommand();
                comando.Connection = conexao;

                decimal matricula = (decimal)grid_EditarAluno.SelectedRows[0].Cells[0].Value;

                comando.CommandText = "DELETE FROM ALUNOS WHERE matricula = '" + matricula + "'";

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

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            txtBox_Pesquisar.Clear();
            grid_EditarAluno.Rows.Clear();

            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.0.85)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=xepdb1)));Persist Security Info=True;User ID=sys;Password=root;DBA Privilege=SYSDBA";

            OracleConnection conexao = new OracleConnection(connectionString);

            try
            {
                string query = "SELECT * FROM ALUNOS";

                if (txtBox_Pesquisar.Text != "")
                {
                    query = "SELECT * FROM ALUNOS WHERE nome LIKE '" + txtBox_Pesquisar.Text + "'";
                }

                DataTable dados = new DataTable();

                OracleDataAdapter adaptador = new OracleDataAdapter(query, connectionString);

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
    }
}
