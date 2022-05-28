using static System.Console;

WriteLine("Digite a sua idade: ");
var idade = int.Parse(ReadLine());

if(idade >= 18) { 
    WriteLine("Você é maior de idade");
} else {
    WriteLine("Você é menor de idade");
}

WriteLine("Digite o numero do mes: ");
var mes = int.Parse(ReadLine());
/* if(mes == 1) {
    WriteLine("Janeiro");
} else if(mes == 2) {
    WriteLine("Fevereiro");
} else if(mes == 3) {
    WriteLine("Março");
} // ...  
else {
    WriteLine("Mês inválido");
} */

switch(mes) {
    case 1:
        WriteLine("Janeiro");
        break;
    case 2:
        WriteLine("Fevereiro");
        break;
    case 3:
        WriteLine("Março");
        break;
    case 4:
        WriteLine("Abril");
        break;
    case 5:
        WriteLine("Maio");
        break;
    case 6:
        WriteLine("Junho");
        break;
    case 7:
        WriteLine("Julho");
        break;
    case 8:
        WriteLine("Agosto");
        break;
    case 9:
        WriteLine("Setembro");
        break;
    case 10:
        WriteLine("Outubro");
        break;
    case 11:
        WriteLine("Novembro");
        break;
    case 12:
        WriteLine("Dezembro");
        break;
    default:
        WriteLine("Mês inválido");
        break;
}