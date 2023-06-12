using System;

class Program
{
    static int Soma(int a, int b)
    {
        int resultado = a + b;
        return resultado;
    }

    static int Subtracao(int a, int b)
    {
        int resultado = a - b;
        return resultado;
    }

    static int Multiplicacao(int a, int b)
    {
        int resultado = a * b;
        return resultado;
    }

    static int Divisao(int a, int b)
    {
        int resultado = a / b;
        return resultado;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Soma(30, 5));
        Console.WriteLine(Subtracao(30, 5));
        Console.WriteLine(Multiplicacao(30, 5));
        Console.WriteLine(Divisao(30, 5));
    }
}
