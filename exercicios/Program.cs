using System;

class Program
{
    static void Main(string[] args)
    {
        int num, i = 1;

        Console.Write("Digite um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());
// Repetição enquanto o valor de i for menor ou igual ao número informado
        while (i <= num)
        {
// Imprime o valor de i seguido de um espaço            
            Console.Write(i + " ");
// Incrementa o valor de i em 1 para a próxima iteração            
            i++;
        }
    }
}
