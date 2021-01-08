using System;

namespace desafio1
{
    class Program
    {


        static void Main(string[] args)
        {            
            double divide(double divisor, double dividendo)
            {
                return divisor + dividendo;
            }

            double valor1 = 0;
            double valor2 = 0;
            double resultado = 0;
            double i = 0;

            do
            {
                Console.WriteLine("Digite o primeiro valor:");
                valor1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o primeiro valor:");
                valor2 = Convert.ToDouble(Console.ReadLine());

                resultado = divide(valor1, valor2);
                i++;

                while (resultado >= valor2)
                {
                    i++;
                    resultado = divide(resultado, valor2);
                }

                System.Console.WriteLine("{0} dividido por {1} = {2}", valor1, valor2, i);

                i = 0;
            }
            while (valor1 != 0);
            {
                Console.ReadKey();
            }

        }

    }

}
