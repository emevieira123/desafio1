using System;

namespace desafio1
{
    class Program
    {


        static void Main(string[] args)
        {
            Decimal divide(Decimal divisor, Decimal dividendo)
            { return divisor + dividendo; }

            Decimal valor1 = 17; Decimal valor2 = 5;
            Decimal i = 0; Decimal d = 0; Decimal count = 0; 
            Decimal recebeDecimal = 0.1m;          

            Decimal resultado = valor2;
            while (resultado <= valor1)
            {
                i++;
                resultado = divide(resultado, valor2);
            }

            //Decimal resultado2 = valor2;
            //Decimal resultado2 = valor2 + i;
            Decimal resultado2 = resultado + resultado;
            Decimal teste = valor2;
            Decimal resultadoDecimal = recebeDecimal;

            // for(d = 0; d < resultado2; d++)
            // {
            //     t++;
            //     resultado2 = resultadoDecimal + resultadoDecimal;
            // }

            while(valor2 <= resultado2)
            {
                d++;
                resultado2 = divide(teste, teste);                
            }

            i = i + recebeDecimal;

            System.Console.WriteLine(resultado2);
            System.Console.WriteLine(count);
            System.Console.WriteLine(d);
            System.Console.WriteLine("{0} dividido por {1} = {2:N2}", valor1, valor2, i);



            
            // Decimal dividendo = 17;
            // Decimal divisor = 5;
            
            //     Console.WriteLine("{0} dividido por {1} = {2:N2}", dividendo, divisor,
            //                       Decimal.Divide(dividendo, divisor));                
            

            // //Calculo para fins de comparacao!
            // Decimal c;
            // c = valor1 / valor2;
            // System.Console.WriteLine("Para comparacao: {0}", c);

        }

    }

}
