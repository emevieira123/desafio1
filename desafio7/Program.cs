using System;

namespace desafio7
{
    class Program
    {
        static void Main(string[] args)
        {            
            Array array = new Array();
            System.Console.WriteLine(array.SomaDoArray());
        }
    }
    public class Array
    {
        public int SomaDoArray()
        {
            int totalSoma = 0;
            int[] arraySoma = new int[]{3, 5, 7, 9, 11};
            
            totalSoma = arraySoma[0] + arraySoma[1] + arraySoma[2] + arraySoma[3] + arraySoma[4];

            return totalSoma;
        }
    }
}
