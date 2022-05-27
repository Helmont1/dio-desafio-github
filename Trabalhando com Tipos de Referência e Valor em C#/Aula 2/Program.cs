using static System.Console;


class Program {
    static void Demo2() {
        var nomes = new string[] { "João", "Maria", "José", "Ricador"};
        WriteLine("Digite o nome a ser substituido:");
        var nome = ReadLine();
        WriteLine("Digite o nome a ser substituido:");
        var nomeNovo = ReadLine();
        AlterarNome(nomes, nome, nomeNovo);
        WriteLine($@"
            Nomes alterados:
            {string.Join(", ", nomes)})
            ");
    }

    static void Demo1() {
        int a = 5;
        Adicionar20(ref a);
        WriteLine($"O valor de a eh: {a}");
    }

    static void Adicionar20(ref int x) {
        x += 20;
    }

    static void AlterarNome(string[] nomes, string nomeAtual, string nomeNovo) {
        for(int i = 0; i < nomes.Length; i++) {
            if(nomes[i] == nomeAtual) {
                nomes[i] = nomeNovo;
            }
        }
    }

    static ref string LocalizarNome(string[] nomes, string nome) {
        for(int i = 0; i < nomes.Length; i++) {
            if(nomes[i] == nome) {
                return ref nomes[i];
            }
        }
        throw new Exception("Nome não encontrado");
    }

    static void Main() {
        var nomes = new string[] { "João", "Maria", "José", "Ricador"};
        WriteLine("Digite o nome a ser substituido:");
        var nome = ReadLine();
        WriteLine("Digite o nome a ser substituido:");
        var nomeNovo = ReadLine();
        ref var nomeAchado = ref LocalizarNome(nomes, nome);
        
        if(!string.IsNullOrWhiteSpace(nomeAchado)) {
            nomeAchado = nomeNovo;

            WriteLine($@"
                Nomes alterados:
                {string.Join(", ", nomes)})
                ");
        }
    }
}
