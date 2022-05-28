using static System.Console;

WriteLine("Digite o primeiro valor"); // Funcao que escreve o que tem entre as aspas
var valor1 = int.Parse(ReadLine()); // Funcao que le o que tem entre as aspas e converte para inteiro
WriteLine("Digite o segundo valor");
var valor2 = int.Parse(ReadLine());

WriteLine($"A soma dos valores é {valor1 + valor2}"); // Funcao que escreve o que tem entre as aspas e interpola o valor


