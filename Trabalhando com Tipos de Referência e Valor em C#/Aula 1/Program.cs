using static System.Console;
public class Program {
    static void Demo6() {
        var numeros = new int[] {0,2,4,6,8};
        WriteLine($"Digite o numero que gostaria de encontrar: ");
        var numero = int.Parse(ReadLine());
        var idxEncontrado = EncontrarNumeros(numeros,numero);


        if(idxEncontrado >= 0) {
            WriteLine($"O numero digitado esta na posicao {idxEncontrado}");
        } else {
            WriteLine("O numero digitado nao foi encontrado");
        }
    }

    static void Demo5() {
        var pares = new int[] {0,2,4,6,8};
        MudarParaImpar(pares);
        WriteLine($"Os impares {string.Join(",", pares)}");
    }

    static void Demo4() {
        string nome = "Matheus";
        TrocarNome(nome, "Josue");

        WriteLine($"O novo nome eh: {nome}");
    }

    static void Demo3() {
        StructPessoa p1 = new StructPessoa() {
            Documento = "1234",
            Idade = 18,
            Nome = "Matheus"
        };
        var p2 = p1;
        p1 = TrocarNomeStruct(p1, "Jonas");
        WriteLine($@"
            Nome do p1 eh: {p1.Nome} 
            Nome do p2 eh: {p2.Nome}
        ");
    }

    static void Demo2() {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Matheus";
        p1.Idade = 18;
        p1.Documento = "1234";
        var p2 = p1.Clone();

        TrocarNome(p1, "Jorginho");

        WriteLine($@"
        O nome de p1 eh: {p1.Nome}
        O nome de p2 eh: {p2.Nome}
        ");
    }

    static void Demo1() {
        int a = 2;
        a = Adicionar20(a);
        WriteLine($"O valor da variavel a eh: {a}");
    }

    static int Adicionar20(int a) {
        return a + 20;
    }

    static void TrocarNome(Pessoa p1, string nomeNovo) {
        p1.Nome = nomeNovo;
    }

    static StructPessoa TrocarNomeStruct(StructPessoa p1, string nomeNovo) {
        p1.Nome = nomeNovo;
        return p1;
    }

    static void TrocarNome(string nome, string nomeNovo) {
        nome = nomeNovo;
    }

    static void MudarParaImpar(int[] pares) {
        for(int i=0; i<pares.Length; i++) {
            pares[i] = pares[i] + 1;
        }
    }

    static int EncontrarNumeros(int[] numeros, int numero) {
        for(int i=0;i <numeros.Length; i++) {
            if(numeros[i] == numero) {
                return i;
            }
            
        }
        return -1;
    }

    static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa) {
        foreach (var item in pessoas) {
            if(item.Equals(pessoa)) {
                return true;
            }
        }
        return false;
    }
    public static void Main() {
        List<StructPessoa> pessoas = new List<StructPessoa>() {
            new StructPessoa() {Nome = "Matheus"},
            new StructPessoa() {Nome = "Jospem"},
            new StructPessoa() {Nome = "Fabiana"},
            new StructPessoa() {Nome = "Jose"},
            new StructPessoa() {Nome = "Eduarda"}
        };
        WriteLine("Digite a pessoa que gostaria de localizar: ");
        var nome = ReadLine();
        var pessoa = new StructPessoa() {Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);
        if(encontrado) {
            WriteLine("Pessoa localizada");
        } else {
            WriteLine("Pessoa nao localizada");
        }
    }
}