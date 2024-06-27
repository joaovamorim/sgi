using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;

namespace SGI.frm.ConsultDatabase.frmCustomersDb
{
    public partial class frmCustomersDb : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["OracleConnectionString"].ConnectionString.ToString();

        public frmCustomersDb()
        {
            InitializeComponent();
        }

        private void RefreshDataTable()
        {
            OracleConnection connection = new OracleConnection(connectionString);

            try
            {
                string query = @"select * 
                                 from alunos";

                DataTable data = new DataTable();

                OracleDataAdapter adapter = new OracleDataAdapter(query, connectionString);

                connection.Open();

                adapter.Fill(data);

                foreach (DataRow line in data.Rows)
                {
                    gridCustomersDb.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    gridCustomersDb.Rows.Add(line.ItemArray);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }
        }

        private void frmCustomersDb_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            OracleConnection connection = new OracleConnection(connectionString);

            try
            {
                string query = @"select * 
                                 from alunos";

                DataTable data = new DataTable();

                OracleDataAdapter adapter = new OracleDataAdapter(query, connectionString);

                connection.OpenAsync();

                adapter.Fill(data);

                foreach (DataRow line in data.Rows)
                {
                    gridCustomersDb.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    gridCustomersDb.Rows.Add(line.ItemArray);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Erro ao se conectar com Banco de Dados.\n" + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.CloseAsync();
            }
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            gridCustomersDb.Rows.Clear();

            OracleConnection connection = new OracleConnection(connectionString);

            try
            {
                string query = @"select * 
                                 from alunos";

                DataTable data = new DataTable();

                OracleDataAdapter adapter = new OracleDataAdapter(query, connectionString);

                connection.Open();

                adapter.Fill(data);

                foreach (DataRow line in data.Rows)
                {
                    gridCustomersDb.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    gridCustomersDb.Rows.Add(line.ItemArray);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Erro ao se conectar com Banco de Dados.\n" + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            gridCustomersDb.Rows.Clear();

            OracleConnection connection = new OracleConnection(connectionString);

            try
            {
                string query = @"select * 
                                 from alunos
                                 where nome like '" + toolStripTextBox1.Text.ToUpper() + "'";

                DataTable data = new DataTable();

                OracleDataAdapter adapter = new OracleDataAdapter(query, connectionString);

                connection.Open();

                adapter.Fill(data);

                foreach (DataRow line in data.Rows)
                {
                    gridCustomersDb.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    gridCustomersDb.Rows.Add(line.ItemArray);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Erro ao se conectar com Banco de Dados.\n" + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                RefreshDataTable();
            }
        }
    }
}
