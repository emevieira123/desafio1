using System;

namespace desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematica matematica = new Matematica();

            matematica.Soma(10, 5);
            matematica.Subtrai(40, 7);
            // matematica.Mutiplica(9, 9);
            matematica.Exponencia(9, 3);

            System.Console.WriteLine(matematica.Somar);
            System.Console.WriteLine(matematica.Subtrair);
            // System.Console.WriteLine(matematica.Multiplicar);
            int multiplicacao = matematica.Mutiplica(9,9);
            System.Console.WriteLine(multiplicacao); 
            System.Console.WriteLine(matematica.Exponenciar);         

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
            if (primeiroValor > segundoValor)
            {
                int resultado = segundoValor;

                while (resultado < primeiroValor)
                {
                    resultado = resultado + 1;
                    count++;
                }
            }
            else
            {
                int resultado = primeiroValor;

                while (resultado < segundoValor)
                {
                    resultado = resultado + 1;
                    count++;
                }
            }
            return this.Subtrair = count;
        }

        public int Mutiplica(int multiplicando, int multiplicador)
        {
            int multiplicacao = 0;
            for (int i = 0; i < multiplicando; i++)
            {
                multiplicacao = multiplicacao + multiplicador;
            }
            return multiplicacao;
        }

        public int Exponencia(int numeroBase, int expoente)
        {
            int result = numeroBase;
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
