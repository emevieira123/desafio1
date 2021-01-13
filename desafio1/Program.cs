using System;

namespace desafio1
{
    class Program
    {


        static void Main(string[] args)
        {
            decimal divide(decimal divisor, decimal dividendo)
            { return divisor + dividendo; }

            decimal valor1 = 17.0m; decimal valor2 = 5.0m; decimal resultado = 0.0m;
            decimal i = 0.0m; decimal d = 0; decimal t = 0; //decimal m = 0;

            if (valor1 == 0 || valor2 == 0) { System.Console.WriteLine("Erro: 0 não é um número divisível!"); Console.ReadLine(); }
            
            resultado = valor2;
            while (resultado <= valor1)
            {
                i++;
                resultado = divide(resultado, valor2);
            }

            decimal resultado2 = valor2;
            // while (resultado2 <= valor1)
            // {
            //     resultado2 = divide(resultado2, valor2);
            //     d++;
            // }
            
            for(t=0; t <= valor2; t++)
            {
                resultado = valor2;
                while(resultado <= valor1)
                {
                    resultado = resultado + valor1;
                    d++;
                }
            }

            // for(t=0; t<valor2; t++)
            // {
            //     resultado2 = divide(resultado2, valor1);
                
            //     for(m=0; m<valor2; m++)
            //     {
            //         resultado2 = divide(resultado2, valor1);
            //         d++;
            //     }
            // }

            System.Console.WriteLine(resultado);
            System.Console.WriteLine(resultado2);
            System.Console.WriteLine("{0} dividido por {1} = {2}", valor1, valor2, i);

            //Calculo para fins de comparacao!
            decimal c;
            c = valor1 / valor2;
            System.Console.WriteLine("Para comparacao: {0}", c);

        }

    }

}
