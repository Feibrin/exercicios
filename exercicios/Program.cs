using System;

class Program
{
    static void Main(string[] args)
    {
        int num;

        do
        {
            Console.Write("DIGITE UM NUMERO ENTRE 1 A 10: ");
            num = int.Parse(Console.ReadLine());
        } while (num < 1 || num > 10);

        Console.WriteLine("VOCÊ DIGITOU O NÚMERO " + num + ".");
    }
}
