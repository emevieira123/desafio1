using System;

namespace desafio1
{
    class Program
    {


        static void Main(string[] args)
        {
            Decimal valor1 = 17; Decimal valor2 = 5;
            Decimal i = 0; Decimal d = 0;
            Decimal recebeDecimal = 0.1m;          

            Decimal resultado = valor2;
            while (resultado <= valor1)
            {
                i++;
                resultado = resultado +valor2;
            }
            
            Decimal resultado2 = resultado + resultado;

            while(valor2 <= resultado2)
            {
                d++;
                resultado2 = valor2 + valor2;                
            }

            i = i + recebeDecimal;

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

        public static Decimal Divide(Decimal dividendo, Decimal divisor)
        {
            Decimal i = 0;
            Decimal quociente = divisor;

            while(quociente <= dividendo)
            {
                i++;
                quociente = quociente + divisor;
            }

            Decimal resto = 0;

            //Fazer aqui o codigo para descobrir o resto;

            Decimal novoDividendo = Multiplica(resto, 10);

            var decimais = Divide(novoDividendo, divisor);

            return 0.1m;
        }

    }

}
