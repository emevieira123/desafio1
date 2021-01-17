using System;

namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divisão = " + Program.Calculo(500m, 33m));
        }
        public static Decimal Calculo(Decimal dividendo, Decimal divisor)
        {
            Decimal valorDivisao = Divide(dividendo, divisor);//Recebe o valor da divisao
            Decimal valorSoma = somaDivisor(dividendo, divisor);//retorna o Valor da soma do divisor até chegar ao valor do dividendo
            Decimal valorSubtracao = Subtrai(valorSoma, divisor);//Pega o valorSoma e subtrai pelo divisor
            Decimal obtemResto = Subtrai(dividendo, valorSubtracao);//Pega o valorSubtracao e subtrai pelo dividendo e obtem o resto da divisao entre dividendo e divisor
            Decimal multResto = Multiplica(obtemResto, 10m);//Multiplica o Resto por 10
            Decimal divResto = Divide(multResto, divisor);//Pega o valor da multiplicacao e divide pelo divisor
            Decimal obtemDecimal = Multiplica(divResto, 0.1m);

            //Obter o segundo decimal            
            Decimal valorSoma2 = somaDivisor(multResto, divisor);
            Decimal valorSubtracao2 = Subtrai(valorSoma2, divisor);
            Decimal obtemResto2 = Subtrai(multResto, valorSubtracao2);
            Decimal multResto2 = Multiplica(obtemResto2, 10m);
            Decimal divResto2 = Divide(multResto2, divisor);
            Decimal obtemDecimal2 = Multiplica(divResto2, 0.01m);

            Decimal aux = valorDivisao + obtemDecimal + obtemDecimal2;

            return aux;
        }

        public static Decimal somaDivisor(Decimal dividendo, Decimal divisor)
        {
            Decimal i = 0;
            Decimal quociente = divisor;
            if (dividendo < 0 || divisor < 0)
            {
                while (quociente >= dividendo)
                {
                    i += -1;
                    quociente = quociente + divisor;
                }
            }

            while (quociente <= dividendo)
            {
                i++;
                quociente = quociente + divisor;
            }
            return quociente;//Retorna a soma do valor do divisor
        }

        public static Decimal Divide(Decimal dividendo, Decimal divisor)
        {
            Decimal i = 0;
            Decimal quociente = divisor;

            if (dividendo < 0 || divisor < 0)
            {
                while (quociente >= dividendo)
                {
                    i += -1;
                    quociente += divisor;
                }
                //return i;
            }
            else if(divisor < 0 && dividendo < 0)
            {
                while(quociente >= divisor)
                {
                    i += -1;
                    quociente += dividendo;
                }
            }

            while (quociente <= dividendo)
            {
                i++;
                quociente = quociente + divisor;
            }
            return i;//Retorna o valor do contador
        }

        public static Decimal Subtrai(Decimal primeiroValor, Decimal segundoValor) //Formula que realiza a subtração de valores
        {
            Decimal count = 0;
            Decimal valor = segundoValor;
            Decimal resultado = primeiroValor;
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
            return count;
        }

        public static Decimal Multiplica(Decimal multiplicando, Decimal multiplicador) //Formula que realiza a multiplicação de valores
        {
            Decimal result = 0; Decimal resultado = 0; //Variaveis que recebe o resultado de um calculo
            Decimal i = 0; Decimal d = 0; Decimal count = 0; //Variaveis utilizadas como contador
            if (multiplicando < result || multiplicador < result)
            {
                for (i = 0; i < multiplicando; i++)
                {
                    result = result + multiplicador;
                }
            }

            if (multiplicando < 0 && multiplicador < 0)
            {
                for (i = 0; i > multiplicador; i += -1)
                {
                    resultado = resultado + multiplicando;
                }
                for (d = 0; d > resultado; d += -1)
                {
                    count++;
                }
                result = count;
            }

            for (i = 0; i < multiplicando; i++)
            {
                result = result + multiplicador;
            }
            return result;
        }

    }

}
