using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;

namespace SGI.frm.ConsultDatabase.frmCustomersDb
{
    public partial class frmCustomersDb : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["OracleConnectionString"].ConnectionString.ToString();
        private static OracleConnection connection = new OracleConnection(connectionString);
        private static string? query;

        public frmCustomersDb()
        {
            InitializeComponent();
        }

        private void frmCustomersDb_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            try
            {
                query = @"select * 
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
                MessageBox.Show("Load error.\n" + Error.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.CloseAsync();
            }
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            gridCustomersDb.Rows.Clear();

            try
            {
                query = @"select * 
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
                MessageBox.Show("Error updating the database.\n" + Error.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            gridCustomersDb.Rows.Clear();

            try
            {
                query = @"select *
                          from alunos";

                if (toolStripTextBox1.Text != "")
                {
                    query = @"select * 
                              from alunos
                              where nome like '%" + toolStripTextBox1.Text.ToUpper() + "%'";
                }
                else
                {
                    MessageBox.Show("The text box is empty.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

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

                MessageBox.Show("Error searching the database.\n" + Error.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                toolStripTextBox1.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel1.ForeColor = toolStripLabel1.ForeColor == Color.Black ? Color.Lime : Color.Black;
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchToolStripButton_Click(sender, e);
            }
        }
    }
}
