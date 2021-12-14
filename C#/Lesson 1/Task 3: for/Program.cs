/*
    За каждый месяц банк начисляет к сумме вклада 7% от суммы.
    Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев.
    А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
*/


using System;

namespace ProcentCalc
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.Write("Введите сумму вклада: ");
            decimal Contribution = Convert.ToDecimal(Console.ReadLine());
            
            Console.Write("Введите кол-во месяцве: ");
            int Month = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < Month; i++)
            {
                Contribution += Contribution * 0.07M;
                Console.WriteLine($"Ваш вклад за {i+1} месяц составляет: {Contribution}");
            }
            
            Console.ReadKey();
            
        }
        
    }
    
}
