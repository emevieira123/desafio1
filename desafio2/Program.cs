using System;

namespace desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematica matematica = new Matematica();

            matematica.Soma(10, 5);
            System.Console.WriteLine(matematica.Somar);

            matematica.Subtrai(40, 7);
            System.Console.WriteLine(matematica.Subtrair);

            int multiplicacao = matematica.Mutiplica(-9, 9);
            System.Console.WriteLine(multiplicacao);

            matematica.Exponencia(9, 2);
            System.Console.WriteLine(matematica.Exponenciar);

            // matematica.Mutiplica(9, 9);
            // System.Console.WriteLine(matematica.Multiplicar);

            // int result = matematica.Exponencia(9, 3);
            // System.Console.WriteLine(result);


            int teste = -9 * (-9);
            System.Console.WriteLine("Comparacao * = {0}", teste);

        }
    }

    public class Matematica
    {
        public int Somar;
        public int Subtrair;
        public int Multiplicar;
        public int Exponenciar;

        public int Soma(int primeiroValor, int segundoValor)
        {
            return this.Somar = primeiroValor + segundoValor;
        }

        public int Subtrai(int primeiroValor, int segundoValor)
        {
            int count = 0;
            int valor = segundoValor;
            int resultado = primeiroValor;
            if (primeiroValor > segundoValor)
            {
                while (valor < primeiroValor)
                {
                    valor = valor + 1;
                    count++;
                }
            }
            while (resultado < segundoValor)
            {
                resultado = resultado + 1;
                count--;
            }
            return this.Subtrair = count;
        }

        public int Mutiplica(int multiplicando, int multiplicador)
        {
            int multiplicacao = 0;
            if (multiplicando < multiplicacao || multiplicador < multiplicacao)
            {
                for (int i = 0; i < multiplicando; i++)
                {
                    multiplicacao = multiplicacao + multiplicador;
                }
            }
            // if(multiplicando < 0 && multiplicador < 0)
            // {
            //     for (int i = 0; i > multiplicando; i--)
            //     {
            //         multiplicacao = multiplicacao + multiplicador;
            //     }
            // }

            for (int i = 0; i < multiplicador; i++)
            {
                multiplicacao = multiplicacao + multiplicando;
            }
            return this.Multiplicar = multiplicacao;
        }

        public int Exponencia(int numeroBase, int expoente)
        {
            int result = numeroBase;
            if (numeroBase < 0)
            {
                for (int count1 = 0; count1 < expoente - 1; count1++)
                {
                    result = Mutiplica(result, numeroBase);                    
                }
            }
            for (int count1 = 0; count1 < expoente - 1; count1++)
            {
                result = Mutiplica(result, numeroBase);
                // for (int i = 0; i < numeroBase; i++)
                // {
                //     result = result + expoente;
                // }
            }
            return this.Exponenciar = result;
        }
    }
}
