using System.IO.Compression;
using System.Diagnostics;
using Newtonsoft.Json;

class AutoUpdate
{
    // URL da API do GitHub para pegar a última release
    private static readonly string githubApiUrl = "https://api.github.com/repos/joaovamorim/sgi/releases/latest"; // Ajuste com seu repositório

    // Caminho onde o SGI.exe é instalado
    private static readonly string installPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "SGI");

    static async Task Main(string[] args)
    {
        // Verifica se já foi executado (evitar execução repetida)
        if (args.Length > 0 && args[0] == "already_executed")
        {
            // Se o argumento 'already_executed' for passado, significa que a atualização foi feita, então só abre o SGI.exe.
            StartSGI();
            return;
        }

        // Obter a versão do SGI.exe
        string localVersion = GetLocalVersion();

        // Obter a versão mais recente do GitHub
        string remoteVersion = await GetLatestGitHubReleaseVersion();

        // Comparar as versões
        if (localVersion != remoteVersion)
        {
            // Se a versão local for diferente da versão remota, fazer a atualização
            MessageBox.Show("Nova versão encontrada. Iniciando atualização...");
            string publishZipUrl = await GetPublishZipUrl(); // Obter a URL do publish.zip
            await DownloadAndExtractUpdate(publishZipUrl); // Realiza o download e extração
        }
        else
        {
            // Se as versões estão iguais, abre o SGI.exe diretamente
            StartSGI();
        }
    }

    // Obter versão do SGI.exe diretamente do arquivo executável
    static string GetLocalVersion()
    {
        string exePath = Path.Combine(installPath, "SGI.exe"); // Caminho completo para o SGI.exe
        FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(exePath);
        return versionInfo.FileVersion!; // Retorna a versão do produto
    }

    // Obter a versão mais recente do GitHub Release
    static async Task<string> GetLatestGitHubReleaseVersion()
    {
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd("request");
            var response = await client.GetStringAsync(githubApiUrl);
            dynamic release = JsonConvert.DeserializeObject(response);
            // Obter o tag_name (versão) da última release
            string version = release.tag_name.ToString();
            return version; // Remove o 'v' do início da versão
        }
    }

    // Função para pegar a URL do publish.zip da última release
    static async Task<string> GetPublishZipUrl()
    {
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd("request");
            var response = await client.GetStringAsync(githubApiUrl);
            dynamic release = JsonConvert.DeserializeObject(response);
            foreach (var asset in release.assets)
            {
                string name = asset.name.ToString();
                if (name.EndsWith(".zip"))
                {
                    return asset.browser_download_url.ToString(); // Retorna a URL do publish.zip
                }
            }
        }

        return string.Empty; // Se não encontrar o arquivo .zip
    }

    // Baixar e extrair o arquivo publish.zip na pasta de instalação
    static async Task DownloadAndExtractUpdate(string publishZipUrl)
    {
        if (string.IsNullOrEmpty(publishZipUrl))
        {
            MessageBox.Show("Erro: Não foi possível encontrar o arquivo de atualização.");
            return;
        }

        string zipFilePath = Path.Combine(installPath, "publish.zip"); // Caminho para o arquivo zip temporário

        // Baixar o arquivo publish.zip
        using (var client = new HttpClient())
        {
            var fileBytes = await client.GetByteArrayAsync(publishZipUrl);
            await File.WriteAllBytesAsync(zipFilePath, fileBytes);
        }

        // Extração do arquivo zip na pasta de instalação
        ZipFile.ExtractToDirectory(zipFilePath, installPath, true); // Extraímos e sobrescrevemos os arquivos existentes

        MessageBox.Show("Atualização concluída!");

        // Remover o arquivo zip após extração
        File.Delete(zipFilePath);

        // Aguarda a conclusão da extração e então iniciar o SGI.exe
        await Task.Delay(500);  // Garantir que o SGI.exe seja iniciado após a extração

        // Iniciar o SGI.exe após a atualização e passar o argumento para evitar a reexecução do AutoUpdate
        StartSGI(true);
    }

    // Função para iniciar o SGI.exe após a atualização
    static void StartSGI(bool isUpdate = false)
    {
        try
        {
            // Inicia o SGI.exe com o argumento 'already_executed' para evitar a execução do AutoUpdate
            Process.Start(Path.Combine(installPath, "SGI.exe"), isUpdate ? "already_executed" : "");

            // Encerra o AutoUpdate.exe
            Environment.Exit(0); // Saímos completamente do AutoUpdate.exe
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao iniciar o SGI.exe: {ex.Message}");
        }
    }
}