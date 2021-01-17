using System;

namespace desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaNascimento = 1;
            int mesNascimento = 1;
            int anoNascimento = 2000;
            int diaAtual = 5;
            int mesAtual = 5;
            int anoAtual = 2007;
            int calculaDia = 0;
            int qtdeDias = 0;            

                if(diaNascimento < diaAtual)
                {
                    calculaDia = diaAtual - diaNascimento;
                }
                else
                {
                    calculaDia = diaNascimento - diaAtual;
                }

                int calculoMesNasc = 0;
                //Calcula os dias a partir do mes de nascimento até o ultimo mes do ano
                if(mesNascimento == 1)
                { calculoMesNasc = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30 + 31; }
                else if(mesNascimento == 2)
                { calculoMesNasc = 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30 + 31; }
                else if(mesNascimento == 3)
                { calculoMesNasc = 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30 + 31; }
                else if(mesNascimento == 4)
                { calculoMesNasc = 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30 + 31; }
                else if(mesNascimento == 5)
                { calculoMesNasc = 31 + 30 + 31 + 31 + 30 + 31 + 30 + 31; }
                else if(mesNascimento == 6)
                { calculoMesNasc = 30 + 31 + 31 + 30 + 31 + 30 + 31; }
                else if(mesNascimento == 7)
                { calculoMesNasc = 31 + 31 + 30 + 31 + 30 + 31; }
                else if(mesNascimento == 8)
                { calculoMesNasc = 31 + 30 + 31 + 30 + 31; }
                else if(mesNascimento == 9)
                { calculoMesNasc = 30 + 31 + 30 +31; }
                else if(mesNascimento == 10)
                { calculoMesNasc = 30 + 30 + 31; }
                else if(mesNascimento == 11)
                { calculoMesNasc = 30 + 31; }
                else if(mesNascimento == 12)
                { calculoMesNasc = 31; }

                int recebeValor = 0;
                //Calcula os dias do mes retroativamente                
                if(mesAtual == 1)
                { recebeValor = 0; }
                else if(mesAtual == 2)
                { recebeValor = 31; }
                else if(mesAtual == 3)
                { recebeValor = 31 + 28; }
                else if(mesAtual == 4)
                { recebeValor = 31 + 28 + 31; }
                else if(mesAtual == 5)
                { recebeValor = 31 + 28 + 31 + 30; }
                else if(mesAtual == 6)
                { recebeValor = 31 + 28 + 31 + 30 + 31; }
                else if(mesAtual == 7)
                { recebeValor = 31 + 28 + 31 + 30 + 31 + 30; }
                else if(mesAtual == 8)
                { recebeValor = 31 + 28 + 31 + 30 + 31 + 30 + 31; }
                else if(mesAtual == 9)
                { recebeValor = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31; }
                else if(mesAtual == 10)
                { recebeValor = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30; }
                else if(mesAtual == 11)
                { recebeValor = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31; }
                else if(mesAtual == 12)
                { recebeValor = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30; }
                
                int calculoAnos = anoAtual - anoNascimento - 1;
                int calculaMes = calculoMesNasc + recebeValor;           
                int calculaBissexto = calculoAnos / 4 + 1;
            
                qtdeDias = calculoAnos * 365 + calculaMes + calculaDia + calculaBissexto;
                System.Console.WriteLine(qtdeDias);
        }
    }
}
