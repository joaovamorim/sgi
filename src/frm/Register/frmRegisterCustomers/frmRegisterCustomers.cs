using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace SGI.frm.Register.frmRegisterCustomers
{
    public partial class frmRegisterCustomers : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["OracleConnectionString"].ConnectionString.ToString();
        private static OracleConnection connection = new OracleConnection(connectionString);
        private static OracleCommand command = new OracleCommand();
        
        public frmRegisterCustomers()
        {
            InitializeComponent();
        }

        private void frmRegisterCustomers_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.AcceptButton = btnRegisterUser;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusLabel.ForeColor = statusLabel.ForeColor == Color.Black ? Color.Lime : Color.Black;
        }

        private void ClearTextBox()
        {
            txtName.Clear();
            txtDateBirth.Clear();
            txtCpf.Clear();
            txtTelephone.Clear();
            txtEmail.Clear();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtName.Text == null)
            {
                MessageBox.Show("The Name field must be filled in.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtDateBirth.MaskCompleted == false)
            {
                MessageBox.Show("The Date of Birth field must be filled in.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtCpf.MaskCompleted == false)
            {
                MessageBox.Show("The CPF field must be filled in.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtTelephone.MaskCompleted == false)
            {
                MessageBox.Show("The Telephone field must be filled in.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtEmail.Text == "" || txtEmail.Text == null)
            {
                MessageBox.Show("The Email field must be filled in.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    connection.Open();

                    command.Connection = connection;

                    int cod_ch_func = new Random(DateTime.Now.Millisecond).Next(100000, 1000000);
                    string nome_func = txtName.Text.ToUpper();
                    string data_nasc = txtDateBirth.Text;
                    string cod_cpf = txtCpf.Text;
                    string num_tel = txtTelephone.Text;
                    string email = txtEmail.Text;
                    string ativ_atl = "Ativo";

                    command.CommandText = "insert into alunos values (" + cod_ch_func + ", '" + nome_func + "', '" + data_nasc + "', '" + cod_cpf + "', '" + num_tel + "', '" + email + "', '" + ativ_atl + "')";

                    command.ExecuteNonQuery();

                    MessageBox.Show("Registration entered successfully!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    command.Dispose();
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Error:\n{error.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ClearTextBox();
                    txtName.Focus();
                    connection.Close();
                }
            }
        }
    }
}
