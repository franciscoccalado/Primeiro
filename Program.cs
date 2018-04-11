using System;

namespace PrimeiroGit
{
    class Program
    {
        static void Main(string[] args)
        {
         //Declaraçao das variaveis para guardar os valores
// que o usuario entrara
double valor1,valor2,resultado;
Console.WriteLine("Digite um valor:");
valor1 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com outro valor");
valor2 = double.Parse(Console.ReadLine()); 
resultado = valor1+valor2;
Console.WriteLine("o resultado da soma é: "+resultado);
        }
    }
}


