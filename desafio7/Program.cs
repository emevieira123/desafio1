using System;

namespace desafio7
{
    class Program
    {
        static void Main(string[] args)
        {            
            SomarArray somarArray = new SomarArray();
            int[] array = new int[]{3, 5, 7, 9, 11};            
            System.Console.WriteLine(somarArray.recebeArray(array, 0));
        }
    }
    public class SomarArray
    {
        public int recebeArray(int[] array, int i)
        {
            var result = 0;
            if(i < array.Length)           
                result = array[i] + recebeArray(array, i + 1);                     
            
            return result;           
        }
    }
}
