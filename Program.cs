using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numerador e um denominador");
            Console.Write("Digite o numerador: ");
            int numerador=Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o denominador: ");
            int denominador=Convert.ToInt32(Console.ReadLine());

            int resultado=numerador / denominador;

            Console.Clear();

            if(denominador==0)
            Console.WriteLine($"{numerador} não é possivel dividir por {denominador}");
            else if(denominador>0)
            Console.WriteLine($"{numerador} dividido por {denominador} é= {resultado}");
            

            
            
        }
    }
}
