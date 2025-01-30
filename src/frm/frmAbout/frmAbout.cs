using System.Diagnostics;

namespace SGI.frm.frmAbout
{
    public partial class frmAbout : Form
    {
        // Caminho onde o SGI.exe é instalado
        private static readonly string installPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "SGI");

        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            string exePath = Path.Combine(installPath, "SGI.exe"); // Caminho completo para o SGI.exe
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(exePath);
            string version = versionInfo.FileVersion;
            // Obtém a versão do assembly
            lblVersion.Text = $" Versão: v{version}";
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }
    }
}
