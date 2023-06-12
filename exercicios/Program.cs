using System;

class Program
{
    static void Main(string[] args)
    {
        int num;

        do
        {
// Solicita ao usuário que digite um número entre 1 e 10            
            Console.Write("DIGITE UM NUMERO ENTRE 1 A 10: ");
            num = int.Parse(Console.ReadLine());
        } while (num < 1 || num > 10);
// Imprime a mensagem informando o número digitado pelo usuário
        Console.WriteLine("VOCÊ DIGITOU O NÚMERO " + num + ".");
    }
}
