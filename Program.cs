using System;

namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2;
            double maior, menor;
            
            Console.WriteLine("Digite o primeiro valor:");

            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");

            valor2 = Convert.ToDouble(Console.ReadLine());            

            if (valor1 >= valor2)
            {
                maior = valor1;

                menor = valor2;
            }
            else
            {
                maior = valor2;

                menor = valor1;
            }

            double divisao = maior;

            double resultado = 0;

            while (divisao > 0)
            {
                divisao = divisao + menor;

                resultado++;
            }
            
            Console.WriteLine(string.Format("Resultado da divisão: {0}", resultado));            

            Console.ReadKey();

        }
        
    }

}
