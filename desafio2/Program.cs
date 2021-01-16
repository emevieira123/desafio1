using System;

namespace desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematica matematica = new Matematica();

            matematica.Soma(10, 5);
            System.Console.WriteLine("Soma = {0}", matematica.Somar); //Resultado do calculo de soma

            matematica.Subtrai(-40, -7);
            System.Console.WriteLine("Subtração = {0}", matematica.Subtrair); //Resultado do calculo de subtração

            int multiplicacao = matematica.Multiplica(9, -2); //Resultado do calculo de multiplicação
            System.Console.WriteLine("Multiplicação = {0}", multiplicacao);

            matematica.Exponencia(-9, 3);
            System.Console.WriteLine("Exponenciação = {0}", matematica.Exponenciar); //Resultado do calculo de exponenciação

            //Essa formula é somente para comparação, para ver se os valores estão batendo
            // int teste = -9 * (-9);
            // System.Console.WriteLine("Comparacao * = {0}", teste);
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
            return this.Somar = primeiroValor + segundoValor; //Formula que realiza a soma de dois valores
        }
        public int Subtrai(int primeiroValor, int segundoValor) //Formula que realiza a subtração de dois valores
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
                count += -1;
            }
            return this.Subtrair = count;
        }
        public int Multiplica(int multiplicando, int multiplicador) //Formula que realiza a multiplicação de dois valores
        {            
            int result = 0; int resultado = 0; //Variaveis que recebe o resulta de um calculo
            int i = 0; int d = 0; int count = 0; //Variaveis utilizadas como contador
            if (multiplicando < result || multiplicador < result)
            {
                for (i = 0; i < multiplicando; i++)
                {
                    result = result + multiplicador;
                }
            }            

            if (multiplicando < 0 && multiplicador < 0)
                {                    
                    for (i = 0; i > multiplicador; i += -1) {
                        resultado = resultado + multiplicando; 
                    }
                    for (d = 0; d > resultado; d += -1) 
                    {
                        count++;
                    }
                    result = count;
                }

            for (i = 0; i < multiplicador; i++)
            {
                result = result + multiplicando;
            }
            return this.Multiplicar = result;
        }
        public int Exponencia(int numeroBase, int expoente) //Formula que realiza a exponenciação de dois valores
        {            
            int resultado = numeroBase; //Essa variavel recebe o valor do numeroBase
            int i = 0; //Variavel utilizadal como contador             
            //int sub = 0;
                expoente += -1;
                for (i = 0; i < expoente; i++)
                { resultado = Multiplica(resultado, numeroBase); }
                
                return this.Exponenciar = resultado;
        }
    }
}


                // if (numeroBase < 0)
                // {
                //     sub = Subtrai(resultado, resultado);
                //     return this.Exponenciar = Subtrai(sub, resultado);                    
                // }
                // else
                // { return this.Exponenciar = resultado; }