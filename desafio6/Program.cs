using System;

namespace desafio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] deUMaCEM = new int[]{1, 100};
            int numeroPalpite = 0;
            int numeroInicial = deUMaCEM[0];
            int numeroFinal = deUMaCEM[1];

            System.Console.WriteLine("PENSE EM UM NÚMERO DE {0} A {1}.", numeroInicial, numeroFinal);
            System.Console.WriteLine("Informe com '<' ou '>' se o numero for maior ou menor");
            System.Console.WriteLine("Quando acertar o numero pensado digite '=' ");
            System.Console.WriteLine("");
            System.Console.WriteLine("Tecle Enter para iniciar!");
            System.Console.ReadLine();

            for (int i = 1; i < 10; i++)
            {
                System.Console.WriteLine("Tentativa {0}", i);
                numeroPalpite = (numeroInicial + numeroFinal) / 2;

                System.Console.WriteLine("O número pensado é {0}?", numeroPalpite);
                string recebeSinal = System.Console.ReadLine();

                if (recebeSinal == ">")
                {   
                    numeroInicial = numeroPalpite;
                    System.Console.WriteLine(numeroPalpite);
                }
                else if (recebeSinal == "<") { numeroFinal = numeroPalpite; }
                else if (recebeSinal == "=") { System.Console.WriteLine("Até que enfim eu acertei kkk"); break; }
                if (i == 9) { System.Console.WriteLine("Voce excedeu seu numero de tentativas"); break; }
            }
        }
    }
}
