using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
// Lê um número inteiro digitado pelo usuário e converte para o tipo int
        Console.Write("Digite um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());

        Console.Write("Os primeiros " + num + " números pares são: ");
// Inicia um loop que itera de 2 até o dobro do número digitado
        for (int i = 2; i <= num * 2; i += 2)
        {
// Imprime o número par atual seguido de um espaço            
            Console.Write(i + " ");
        }
    }
}
