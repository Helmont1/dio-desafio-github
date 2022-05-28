using static System.Console;

var condicao = true;
do {
    WriteLine("Digite um número: ");
    var numero = int.Parse(ReadLine());
    if(numero == 0) {
        break;
    } else {
        continue;
    }
} while(condicao);