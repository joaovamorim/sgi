using System.Diagnostics;

namespace AutoUpdate
{
    static class Program
    {
        private static string networkPath = @"\\lnxcs30\sgi\publish"; // Caminho da pasta de rede onde os arquivos de atualização estão
        private static string localPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs", "SGI - Sistema Gerenciamento Integrado");        
        private static string tempPath = Path.Combine(Path.GetTempPath(), "SGI_Update"); // Caminho da pasta temporária para os arquivos de atualização

        [STAThread]
        static void Main()
        {
            try
            {
                CheckForUpdates();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar atualizações: {ex.Message}");
            }
        }

        static void CheckForUpdates()
        {
            try
            {
                // Verifica se o SGI.exe existe na pasta de rede
                string networkExecutable = Path.Combine(networkPath, "SGI.exe");
                if (!File.Exists(networkExecutable))
                {
                    MessageBox.Show("Arquivo SGI.exe não encontrado na pasta de rede.");
                    return;
                }

                // Obtém a versão do arquivo SGI.exe da pasta de rede
                FileVersionInfo networkVersionInfo = FileVersionInfo.GetVersionInfo(networkExecutable);
                string networkVersion = networkVersionInfo.FileVersion;

                // Obtém a versão do executável local SGI.exe (ajuste o caminho da pasta local para o SGI)
                string localExecutable = Path.Combine(localPath, "SGI.exe");
                if (!File.Exists(localExecutable))
                {
                    MessageBox.Show("Arquivo SGI.exe não encontrado na pasta local.");
                    return;
                }

                FileVersionInfo localVersionInfo = FileVersionInfo.GetVersionInfo(localExecutable);
                string localVersion = localVersionInfo.FileVersion;

                // Compara as versões
                if (networkVersion != localVersion)
                {
                    MessageBox.Show($"Atualização disponível. Versão atual: {localVersion}, Nova versão: {networkVersion}");

                    // Copia os arquivos para a pasta temporária
                    CopyFiles(networkPath, tempPath);
                    MessageBox.Show("Arquivos de atualização copiados para a pasta temporária.");

                    // Aplica a atualização e inicia o SGI.exe
                    ApplyUpdateAndStartSGI();
                }
                else
                {
                    MessageBox.Show("O sistema já está atualizado.");
                    StartSGI(); // Inicia o SGI.exe normalmente
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar atualizações: {ex.Message}");
            }
        }

        static void ApplyUpdateAndStartSGI()
        {
            try
            {
                // Verifica se o SGI.exe está em uso
                if (IsFileInUse(Path.Combine(localPath, "SGI.exe")))
                {
                    MessageBox.Show("SGI.exe está em uso. Feche o aplicativo para continuar com a atualização.");
                    return;
                }

                // Copia os arquivos da pasta temporária para a pasta de instalação
                CopyFiles(tempPath, localPath);

                // Exclui os arquivos temporários após a atualização
                Directory.Delete(tempPath, true);

                // Inicia o SGI.exe após a atualização
                StartSGI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao aplicar a atualização: {ex.Message}");
            }
        }

        static void StartSGI()
        {
            try
            {
                // Inicia o SGI.exe
                Process.Start(Path.Combine(localPath, "SGI.exe"));
                Application.Exit(); // Fecha o AutoUpdate.exe após iniciar o SGI.exe
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao iniciar o SGI.exe: {ex.Message}");
            }
        }

        static void CopyFiles(string sourceDir, string targetDir)
        {
            try
            {
                // Cria o diretório temporário, se não existir
                if (!Directory.Exists(targetDir))
                {
                    Directory.CreateDirectory(targetDir);
                }

                // Copia todos os arquivos da pasta de origem para a pasta temporária
                foreach (string file in Directory.GetFiles(sourceDir))
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(targetDir, fileName);

                    File.Copy(file, destFile, true); // Sobrescreve os arquivos existentes
                }

                // Opcionalmente, também pode copiar subdiretórios (se necessário)
                foreach (string dir in Directory.GetDirectories(sourceDir))
                {
                    string dirName = Path.GetFileName(dir);
                    string destDir = Path.Combine(targetDir, dirName);

                    if (!Directory.Exists(destDir))
                    {
                        Directory.CreateDirectory(destDir);
                    }

                    CopyFiles(dir, destDir); // Chama o método recursivamente para copiar subdiretórios
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao copiar arquivos: {ex.Message}");
            }
        }

        // Função para verificar se um arquivo está em uso
        static bool IsFileInUse(string filePath)
        {
            try
            {
                using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    return false; // Arquivo não está em uso
                }
            }
            catch (IOException)
            {
                return true; // Arquivo está em uso
            }
        }
    }
}
