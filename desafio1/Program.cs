using System;

namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divisão1 = " + Program.Divide(40m, 8m));
            Console.WriteLine("Divisão2 = " + Program.Divide(-8m, 2m));
            Console.WriteLine("Divisão3 = " + Program.Divide(-40m, -3m));
            Console.WriteLine("Divisão4 = " + Program.Divide(40m, 3m));
            // Console.WriteLine("Divisão = " + Program.Calculo(7m, 3m));
            Console.WriteLine("Divisão5 = " + Program.Subtrai(-40m, -39m));
            Console.WriteLine("Divisão6 = " + Program.Multiplica(3m, 0.1m));

            Console.WriteLine("Divisão7 = " + Program.Multiplica(13m, -3m));
            Console.WriteLine("Divisão8 = " + Program.Multiplica(-1m, 10m));
            Console.WriteLine("Divisão9 = " + Program.Multiplica(3m, 0.1m));
            Console.WriteLine("Divisão10 = " + Program.Multiplica(3m, -3m));
            Console.WriteLine("Divisão11 = " + Program.Multiplica(1m, 10m));

            Console.WriteLine("Divisão12 = " + Program.DivideInteiro(10m, -3m));



        }
        public static Decimal Divide(Decimal dividendo, Decimal divisor)
        {
            Decimal quociente = DivideInteiro(dividendo, divisor);//Recebe o valor da divisao 
            Decimal resto = Subtrai(dividendo, Multiplica(quociente, divisor));
            if (resto != 0)
            {
                Decimal n = Multiplica(resto, 10m);
                Decimal valorPrimeiroDecimal = DivideInteiro(n, divisor);
                quociente += Multiplica(valorPrimeiroDecimal, 0.1m);

                resto = Subtrai(n, Multiplica(valorPrimeiroDecimal, divisor));
                if (resto != 0)
                {
                    Decimal m = Multiplica(resto, 10m);
                    Decimal valorSegundoDecimal = DivideInteiro(m, divisor);
                    quociente += Multiplica(valorSegundoDecimal, 0.01m);
                }
            }

            return quociente;
        }

        public static Decimal somaDivisor(Decimal dividendo, Decimal divisor)
        {
            Decimal i = 0;
            Decimal quociente = divisor;        //Ainda realizando testes em todo o somaDivisor, os decimais negativos não
            Decimal aux = dividendo;            //estão funcionando

            if (dividendo < 0 && divisor < 0)
            {
                while (quociente >= dividendo)
                {
                    i++;
                    quociente = quociente + divisor;
                }
                return quociente;
            }
            else if (divisor < 0)
            {
                while (quociente + 1 > -dividendo)
                {
                    i += -1;
                    quociente = quociente + divisor;
                }
                //i += -1;
                return quociente;
            }
            else if (dividendo < 0)
            {
                while (quociente > dividendo)
                {
                    i += -1;
                    quociente = quociente + dividendo;
                }
                // while (aux < -divisor + 1)
                // {
                //     i += -1;
                //     aux = aux + divisor;
                // }
                //i += 1;
                return quociente;
            }
            else
            {
                while (quociente <= dividendo)
                {
                    i++;
                    quociente = quociente + divisor;
                }
                return quociente;
            }

            // Decimal i = 0;
            // Decimal quociente = divisor;
            // if (dividendo < divisor)
            // {
            //     while (quociente >= dividendo)
            //     {
            //         i += -1;
            //         quociente = quociente + dividendo + 5;
            //     }
            //     return quociente;
            // }

            // while (quociente <= dividendo)
            // {
            //     i++;
            //     quociente = quociente + divisor;
            // }
            // return quociente;//Retorna a soma do valor do divisor
        }

        public static Decimal DivideInteiro(Decimal dividendo, Decimal divisor)
        {
            Decimal i = 0;
            Decimal quociente = divisor;
            Decimal aux = dividendo;

            if (dividendo < 0 && divisor < 0)
            {
                while (quociente >= dividendo)
                {
                    i++;
                    quociente = quociente + divisor;
                }
                return i;
            }
            else if (divisor < 0)
            {
                while (quociente + 1 > -dividendo)
                {
                    i += -1;
                    quociente = quociente + divisor;
                }
                //i += -1;
                return i;
            }
            else if (dividendo < 0)              //Esse else if ainda nao esta funcionando, resultado nao esta preciso
            {
                // while (quociente > dividendo)
                // {
                //     i += -1;
                //     quociente = quociente + dividendo;
                // }
                while (aux < -divisor + 1)
                {
                    i += -1;
                    aux = aux + divisor;
                }
                return i;
            }

            while (quociente <= dividendo)
            {
                i++;
                quociente = quociente + divisor;
            }
            return i; //Retorna o valor do contador
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

        // public static Decimal Multiplica(Decimal multiplicando, Decimal multiplicador) //Formula que realiza a multiplicação de valores
        // {
        //     Decimal result = 0; Decimal resultado = 0; //Variaveis que recebe o resultado de um calculo
        //     // Decimal i = 0; Decimal d = 0; Decimal count = 0; //Variaveis utilizadas como contador
        //     // if (multiplicando < result || multiplicador < result)
        //     // {
        //     //     for (i = 0; i < multiplicando; i++)
        //     //     {
        //     //         result = result + multiplicador;
        //     //     }
        //     // }

        //     // if (multiplicando < 0 && multiplicador < 0)
        //     // {
        //     //     for (i = 0; i > multiplicador; i += -1)
        //     //     {
        //     //         resultado = resultado + multiplicando;
        //     //     }
        //     //     for (d = 0; d > resultado; d += -1)
        //     //     {
        //     //         count++;
        //     //     }
        //     //     result = count;
        //     // }

        //     // for (i = 0; i < multiplicando; i++)
        //     // {
        //     //     result = result + multiplicador;
        //     // }
        //     return result = multiplicando * multiplicador;
        // }

        public static Decimal Multiplica(Decimal multiplicando, Decimal multiplicador) //Formula que realiza a multiplicação de dois valores
        {
            Decimal result = 0; Decimal resultado = 0; //Variaveis que recebe o resulta de um calculo
            Decimal i = 0; Decimal d = 0; Decimal count = 0; //Variaveis utilizadas como contador
            // if (multiplicando < result || multiplicador < result)
            // {
            //     for (i = 0; i < multiplicando; i++)
            //     {
            //         result = result + multiplicador;
            //     }
            // }

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
            Decimal interador = multiplicador;
            Decimal interando = multiplicando;
            if(multiplicando > multiplicador)
            {
                interador = multiplicando;
                interando = multiplicador;
            }
            for (i = 0; i < interador; i++)
            {
                result = result + interando;
            }
            return result;
        }

    }

}
