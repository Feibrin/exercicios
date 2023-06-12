// Fabrício Nogueira Santods - 11/06/23
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            float num1, num2;
// Solicita ao usuário que coloque o operador  
            Console.Write("ENTRE COM O OPERADOR: +, -, *, /: ");
            op = Console.ReadLine()[0];
// Solicita ao usuário que coloque 2 valores separados por espaço            
            Console.Write("ENTRE COM DOIS VALORES: ");
            string[] values = Console.ReadLine().Split(' ');
            num1 = float.Parse(values[0]);
            num2 = float.Parse(values[1]);
// Realiza a operação com base no operador digitado e exibe o resultado
            switch (op)
            {
                case '+':
                    Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("OPERADOR ERRADO, ENTRE COM O CORRETO");
                    break;
            }
        }
    }
}
