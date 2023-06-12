using System;

class Program
{
// Função para realizar a soma de dois números inteiros    
    static int Soma(int a, int b)
    {
        int resultado = a + b;
        return resultado;
    }
// Função para realizar a subtração de dois números inteiros
    static int Subtracao(int a, int b)
    {
        int resultado = a - b;
        return resultado;
    }
// Função para realizar a multiplicação de dois números inteiros
    static int Multiplicacao(int a, int b)
    {
        int resultado = a * b;
        return resultado;
    }
// Função para realizar a divisão de dois números inteiros
    static int Divisao(int a, int b)
    {
        int resultado = a / b;
        return resultado;
    }

    static void Main(string[] args)
    {
// Chamada das funções e exibição dos resultados        
        Console.WriteLine(Soma(30, 5));
        Console.WriteLine(Subtracao(30, 5));
        Console.WriteLine(Multiplicacao(30, 5));
        Console.WriteLine(Divisao(30, 5));
    }
}
