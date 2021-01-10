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

            double valor1 = 17; double valor2 = 5; double resultado = 0;
            double t = 0.0; double i = 0; double j = 0; double d = 0;                                                
                 
                if(valor1 == 0 || valor2 == 0){ System.Console.WriteLine("Erro: 0 não é um número divisível!"); Console.ReadLine(); }
                
                resultado = valor2;
                while (resultado <= valor1)
                {
                    i++;
                    resultado = divide(resultado, valor2);
                }               
                
                //calculo abaixo funciona em partes, se o valor da variavel T = 0.0valor2, porém não consigo concatenar os 2 valores
                // j = valor1 % valor2;
                // double resultado2 = t;                
                // while(resultado2 <= j)
                // {
                //     d++;
                //     resultado2 = divide(resultado2, t);
                // }

                // for(t=0; t <= 10; t++)
                // {
                //     resultado = valor2;
                //     while(resultado < valor1)
                //     {
                //         resultado = resultado + valor2;
                //         d++;
                //     }
                // }

                resultado = valor2;
                while(resultado < valor1)
                {
                    resultado = divide(resultado, valor2);
                    d++;
                }

                // double resultado2 = valor2;
                // if(j != 0 )
                // {
                //     if(j==1){ j = 10; } if(j==2){ j = 20; } if(j==3){ j = 30; }
                // }
                // while(resultado2 <= j)
                // {
                //     d++;
                //     resultado2 = divide(resultado2, valor2);
                // }
                
                System.Console.WriteLine(t);               
                // System.Console.WriteLine(resultado2);        
                
                System.Console.WriteLine("{0} dividido por {1} = {2}.{3}", valor1, valor2, i, d);   

                //Calculo para fins de comparacao!
                 double c;
                c = valor1 / valor2;
                System.Console.WriteLine("Para comparacao: {0}", c);       

        }

    }

}
