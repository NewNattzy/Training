/*
    В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться.
    Напишите консольную программу, в которую пользователь вводит сумму вклада.
    Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, то начисляется 7%.
    Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить сумму вклада с начисленными процентами.
*/

using System;

namespace PercentCalc
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите сумму вклада");
            
            double Money = Convert.ToDouble(Console.ReadLine());
            double Percent;
            
            if (Money < 100)
                Percent = Money / 100 * 5;
            else if (Money >= 100 && Money <= 200)
                Percent = Money / 100 * 7;
            else
                Percent = Money / 100 * 10;
            
            Money += Percent;
            Console.WriteLine($"Ваш счет {Money}");
            Console.ReadKey();
            
        }
        
    }
    
}
