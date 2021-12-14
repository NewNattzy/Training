/*
    Задан следующий массив { -n ... -4, -3, -2, -1, 0, 1, 2, 3, 4 ... n }
    Необходимо инвертировать данный массив в {n ... 4, 3, 2, 1, 0, -1, -2, -3, -4 ... -n }
*/

using System;

namespace ArraySort
{
    
    class program
    {
        
        static void Main(string[] args)
        {
            
            int[] Numbers = { -10, -8, -4, -3, -2, -1, 0, 1, 2, 3, 4, 10, 30, 50};
            int[] Result = new int[Numbers.Length];
            int j = Numbers.Length-1;
            
            foreach (int i in Numbers)
            {
                Result[j] = i;
                j--;
            }
            
            Console.Write("{ ");
            
            foreach (int i in Result)
            {
                Console.Write($"{i} ");
            }
            
            Console.Write("}");
    
        }
        
    }
    
}
