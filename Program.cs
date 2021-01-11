using System;

namespace desafio1
{
    class Program
    {


        static void Main(string[] args)
        {
            double divide(double divisor, double dividendo)
            { return divisor + dividendo; }

            double valor1 = 40; double valor2 = 3; double resultado = 0;
            double i = 0; double d = 0; //double t = 0.0; double m = 0;

            if (valor1 == 0 || valor2 == 0) { System.Console.WriteLine("Erro: 0 não é um número divisível!"); Console.ReadLine(); }
            
            resultado = valor2;
            while (resultado <= valor1)
            {
                i++;
                resultado = divide(resultado, valor2);
            }

            double resultado2 = valor2;
            while (resultado2 <= valor1)
            {
                resultado2 = divide(resultado2, valor2);
                d++;
            }

            // for(t=0; t<valor2; t++)
            // {
            //     resultado2 = divide(resultado2, valor1);
            //     for(m=0; m<valor2; m++)
            //     {
            //         resultado2 = divide(resultado2, valor1);
            //     }
            // }

            // j = valor1 % valor2;
            // double resultado2 = valor2;
            // if(j != 0 )
            // {
            //     if(j==1){ j = 100; } if(j==2){ j = 200; } if(j==3){ j = 300; } if(j==4){ j = 400; } if(j==5){ j = 500; }
            //     if(j==6){ j = 600; } if(j==7){ j = 700; } if(j==8){ j = 800; } if(j==9){ j = 900; } 
            // }
            // while(resultado2 <= j)
            // {
            //     d++;
            //     resultado2 = divide(resultado2, valor2);
            // }                

            /*calculo abaixo funciona em partes com o %, se o valor da variavel T = 0.0valor2, porém não consigo concatenar os 2 valores */

            // double resultado2 = t;                
            // while(resultado2 <= j)
            // {
            //     d++;
            //     resultado2 = divide(resultado2, t);
            // }

            // for(t=0; t <= valor1; t++)
            // {
            //     resultado = valor2;
            //     while(resultado < valor1)
            //     {
            //         resultado = resultado + valor2;
            //         d++;
            //     }
            // }                              

            
            System.Console.WriteLine(resultado);
            System.Console.WriteLine(resultado2);
            System.Console.WriteLine("{0} dividido por {1} = {2}.{3}", valor1, valor2, i, d);

            //Calculo para fins de comparacao!
            double c;
            c = valor1 / valor2;
            System.Console.WriteLine("Para comparacao: {0}", c);

        }

    }

}
