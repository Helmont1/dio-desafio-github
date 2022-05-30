using System.Globalization;
using CsvHelper;

var path =  Path.Combine(Environment.CurrentDirectory, "Entrada", "teste.csv");

var fi = new FileInfo(path);

if(!fi.Exists)
    throw new FileNotFoundException($"O arquivo {path} nao existe");

using var sr = new StreamReader(fi.FullName);
var csvConfig = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture);
using var csvReader = new CsvReader(sr, csvConfig);

var registros = csvReader.GetRecords<dynamic>();

foreach (var registro in registros)
{
    System.Console.WriteLine($"nome:{registro.produto}");
    System.Console.WriteLine($"nome:{registro.marca}");
    System.Console.WriteLine($"nome:{registro.preco}");
}






































//7a demo

/* static StreamReader LeCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "teste.csv");
    var sr = new StreamReader(path);
    var cabecalho = sr.ReadLine()?.Split(',');
    while (true)
    {
        var registro = sr.ReadLine()?.Split(',');
        if (registro == null)
        {
            break;
        }
        for (int i = 0; i < registro.Length; i++)
        {
            System.Console.WriteLine($"{cabecalho?[i]}:{registro?[i]}");
        }
        System.Console.WriteLine("----------------------");
    }

    return sr;
}

static void CriarCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "teste.csv");
}
System.Console.WriteLine("\n\nPressione enter para finalizar!");
Console.ReadKey();

 */

//6a demo

/* string linha, paragrafo = null;

var sr = new StringReader(textao);

while(true)
{
    linha = sr.ReadLine();
    if(linha != null)
    {
        paragrafo += paragrafo + linha + " ";
    }
    else 
    {
        paragrafo += '\n';
        break;
    }
}

System.Console.WriteLine($"Texto modificado {paragrafo}");
int caractereLido;
char caractereConvertido;


var sw = new StringWriter();
sr = new StringReader(paragrafo);

while(true)
{
    caractereLido = sr.Read();
    if(caractereLido == -1)
    {
        break;
    }

    caractereConvertido = Convert.ToChar(caractereLido);

    if(caractereConvertido == '.')
    {
        sw.Write("\n\n");

        sr.Read();
        sr.Read();
    }
    else
    {
        sw.Write(caractereConvertido);
    }
    Console.WriteLine($"Texto armazenado no stringwriter: {sw.ToString}");
}
System.Console.WriteLine("\n\nDigite enter para finalizar!");
Console.ReadLine();
 */
































// 5a demo

/* using System.Text;

var sb = new StringBuilder();
sb.AppendLine("Caracteres na primeira linha");
sb.AppendLine("Caracteres na segunda linha");
sb.AppendLine("E o fim");

using var sr = new StringReader(sb.ToString());
var buffer = new char[10];
var tamanho = 0;

do
{
    buffer = new char[10];
    tamanho = sr.Read(buffer);
    System.Console.Write($"{string.Join("", buffer)}");



} while (tamanho >= buffer.Length);

System.Console.WriteLine("Digite enter para finalizar!");
Console.ReadLine(); */

// 4a demo

/* var path = @"C:\Users\defaultuser0\OneDrive\Área de Trabalho\Programs\DIO\dio-desafio-github\Arquivos e Streams\globo";

using var fsw = new FileSystemWatcher(path);
fsw.Created += OnCreated;
fsw.Deleted += OnDeleted;
fsw.Renamed += OnRenamed;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

System.Console.WriteLine("Colocando os eventos na pasta {0}", path);
System.Console.WriteLine("Pressione enter para finalizar..........");
Console.ReadLine();

void OnRenamed(object sender, RenamedEventArgs e)
{
    System.Console.WriteLine($"O arquivo {e.OldName} foi renomeado para {e.Name}");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    System.Console.WriteLine($"Foi excluido o arquivo {e.Name}");
}

void OnCreated(object sender, FileSystemEventArgs e)
{
    System.Console.WriteLine($"Foi criado o arquivo {e.Name}");
} */

//3a demo

/* var path = @"C:\Users\defaultuser0\OneDrive\Área de Trabalho\Programs\DIO\dio-desafio-github\Arquivos e Streams\globo";
//LerDiretorios(path);
LerArquivos(path);
Console.ReadLine();


static void LerArquivos(string path)
{
    var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
    foreach (var arquivo in arquivos)
    {
        var fileInfo = new FileInfo(arquivo);
        System.Console.WriteLine(fileInfo.Name);
        System.Console.WriteLine(fileInfo.Length);
        System.Console.WriteLine(fileInfo.LastAccessTime);
        System.Console.WriteLine("------------------------------------------");
    }
}

static void LerDiretorios(string path)
{

    if (Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
        foreach (var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
            System.Console.WriteLine($"[Nome]:{dirInfo.Name}");
            System.Console.WriteLine($"[Raiz]:{dirInfo.Root}");
            if (dirInfo.Parent != null)
                System.Console.WriteLine($"[Pai]:{dirInfo.Parent.Name}");
            System.Console.WriteLine("---------------------------------------");
        }
    }
    else
    {
        System.Console.WriteLine($"{path} nao existe");
        return;
    }

} */


// 2a demo

/* CriarDiretoriosGlobo();
CriarArquivo();
var origem = Path.Combine(Environment.CurrentDirectory,"brazil.txt");
var destino = Path.Combine(Environment.CurrentDirectory,"globo", "America do sul", "Brazil","brazil.txt");
MoverArquivo(origem, destino);
CopiarArquivo(origem, destino);


static void CopiarArquivo(string pathOrigem, string destino)
{
    File.Copy(pathOrigem, destino);
}

static void MoverArquivo(string pathOrigem, string destino)
{
    if(!File.Exists(pathOrigem))
    {
        System.Console.WriteLine("Arquivo de origem nao existe");
        return;
    }
    if(File.Exists(pathOrigem))
    {
        System.Console.WriteLine("Arquivo ja existe na pasta de destino");
        return;
    }
    File.Move(pathOrigem,destino);
}


static void CriarDiretoriosGlobo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo");
    if (!Directory.Exists(path))
    {
        var diretorioGlobo = Directory.CreateDirectory(path);
        var dirAmNorte = diretorioGlobo.CreateSubdirectory("America do Norte");
        var dirAmCentral = diretorioGlobo.CreateSubdirectory("America Central");
        var dirAmSul = diretorioGlobo.CreateSubdirectory("America do Sul");

        dirAmNorte.CreateSubdirectory("USA");
        dirAmNorte.CreateSubdirectory("Mexico");
        dirAmNorte.CreateSubdirectory("Canada");

        dirAmCentral.CreateSubdirectory("Costa Rica");
        dirAmCentral.CreateSubdirectory("Panama");

        dirAmSul.CreateSubdirectory("Brazil");
        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Paraguay");
    }

}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brazil.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Populacao: 234MM de habitantes");
        sw.WriteLine("IDH: 0.901");
        sw.WriteLine("Dados atualizados em 20/04 de 2018");
    }

} */

// 1a demo

/* System.Console.WriteLine("Digite o nome do arquivo: ");
var nome = Console.ReadLine();
nome = Sanitize(nome);

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path);

System.Console.WriteLine("Digite ENTER para finalizar ...");
Console.ReadLine();

static string Sanitize(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '-');
    }
    return nome;
}

static void CriarArquivo(string path)
{
    try
    {
        var sw = File.CreateText(path);
        sw.WriteLine("Esta eh a linha 1 do arquivo");
        sw.WriteLine("Esta eh a linha 2 do arquivo");
        sw.WriteLine("Esta eh a linha 3 do arquivo");
        sw.Flush();
    }
    catch
    {

        System.Console.WriteLine("O nome do arquivo esta invalido");
    }
} */