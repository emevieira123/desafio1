using System;

namespace desafio1
{
    class Program
    {


        static void Main(string[] args)
        {
            // double valor1, valor2;
            // double maior, menor;

            // Console.WriteLine("Digite o primeiro valor:");

            // valor1 = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("Digite o segundo valor:");

            // valor2 = Convert.ToDouble(Console.ReadLine()); 


            // //Faz a verificacao para ver qual variavel possui o maior valor
            // if (valor1 >= valor2)
            // {
            //     maior = valor1;

            //     menor = valor2;
            // }
            // else
            // {
            //     maior = valor2;

            //     menor = valor1;
            // }

            // //Atribui o maior valor a variavel divisao
            // double divisao = maior;

            // double resultado = 0;

            // while (divisao > 0)
            // {
            //     divisao = divisao + menor;

            //     resultado++;
            // }

            // Console.WriteLine(string.Format("Resultado da divisão: {0}", resultado));            

            // Console.ReadKey();

            double divide(double divisor, double dividendo)
            { return divisor + dividendo; }

            double valor1 = 40;
            double valor2 = 2;
            double resultado = 0;
            double i = 0;
            //double j = 0;
            // double t = 0;
            double d = 0;                             
                 
                resultado = valor2;                              

                while (resultado <= valor1)
                {
                    i++;
                    resultado = divide(resultado, valor2);
                }

                

                // t = 1;
                // j = valor1 + valor1 + valor1;
                // double resultado2 = t;

                // while(resultado2 <= j)
                // {
                //     d++;
                //     resultado2 = divide(resultado2, t);
                // }

                System.Console.WriteLine("{0} dividido por {1} = {2}.{3}", valor1, valor2, i, d);     

                double a = 40; double b = 2; double c;
                c = a / b;
                System.Console.WriteLine(c);       

        }

    }

}
