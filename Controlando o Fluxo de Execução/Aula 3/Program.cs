using static System.Console;

/* var condicao = true; */

/* while(condicao) {
    WriteLine("Digite um número: ");
    var numero = int.Parse(ReadLine());
    if(numero == 0) {
        condicao = false;
        WriteLine("Fim da aplicacao");
    } else {
        WriteLine($"O número digitado foi: {numero}");
    }
} */

/* do {
    WriteLine("Digite um número: ");
    var numero = int.Parse(ReadLine());
    if(numero == 0) {
        condicao = false;
        WriteLine("Fim da aplicacao");
    } else {
        WriteLine($"O número digitado foi: {numero}");
    }
} while(condicao); */

/* var valor = int.Parse(ReadLine());

for(var i = 0; i < valor; i++) {
    WriteLine($"O número digitado foi: {i}");
} */

var lista = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
foreach(var item in lista) {
    WriteLine(item);
}
