using System.Configuration;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace SGI.frm.ConsultDatabase.frmSuppliersDb
{
    public partial class frmSuppliersDb : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["OracleConnectionString"].ConnectionString.ToString();

        public frmSuppliersDb()
        {
            InitializeComponent();
        }

        private void frmSuppliersDb_Load(object sender, EventArgs e)
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
                    gridSuppliersDb.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    gridSuppliersDb.Rows.Add(line.ItemArray);
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

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            gridSuppliersDb.Rows.Clear();

            OracleConnection connection = new OracleConnection(connectionString);

            try
            {
                string query = @"select *
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
                    gridSuppliersDb.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    gridSuppliersDb.Rows.Add(line.ItemArray);
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

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchToolStripButton_Click(sender, e);
            }
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            gridSuppliersDb.Rows.Clear();

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
                    gridSuppliersDb.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    gridSuppliersDb.Rows.Add(line.ItemArray);
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


        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel1.ForeColor = toolStripLabel1.ForeColor == Color.Black ? Color.Lime : Color.Black;
        }
    }
}
