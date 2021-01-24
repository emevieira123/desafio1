using System;

namespace desafio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOrdenacao = new int[] { 12, 25, 40, 11, 60, 8, 22, 67, 51, 83 };

            Ordenacao(arrayOrdenacao, 0, arrayOrdenacao.Length - 1);

            foreach (var item in arrayOrdenacao) { Console.Write(" " + item); }
            Console.WriteLine();
        }
        public static void Ordenacao(int[] arrayOrdenacao, int esquerda, int direita)
        {
            if (esquerda < direita)
            {
                int numeroSelecionado = OrdenaSequencia(arrayOrdenacao, esquerda, direita);

                if (numeroSelecionado > 1) { Ordenacao(arrayOrdenacao, esquerda, numeroSelecionado - 1); }

                if (numeroSelecionado + 1 < direita) { Ordenacao(arrayOrdenacao, numeroSelecionado + 1, direita); }
            }
        }
        public static int OrdenaSequencia(int[] arrayOrdenacao, int esquerda, int direita)
        {
            int numeroSelecionado = arrayOrdenacao[esquerda];
            while (true)
            {
                while (arrayOrdenacao[esquerda] < numeroSelecionado) { esquerda++; }
                while (arrayOrdenacao[direita] > numeroSelecionado) { direita--; }

                if (esquerda < direita)
                {
                    if (arrayOrdenacao[esquerda] == arrayOrdenacao[direita]) return direita;

                    int valor = arrayOrdenacao[esquerda];
                    arrayOrdenacao[esquerda] = arrayOrdenacao[direita];
                    arrayOrdenacao[direita] = valor;
                }
                else { return direita; }
            }
        }

    }
}