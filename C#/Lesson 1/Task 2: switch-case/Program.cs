/*
    Напишите консольную программу, которая запрашивает у пользователя два числа и производит операции над ними.
    Тип операции выбирается пользователем, вводом: 1.Сложение, 2.Вычитание, 3.Умножение.
    Если введенное пользователем число не соответствует никакой операции (например, число 120), то выведите пользователю сообщение о том, что операция неопределена.
*/

using System;

namespace SimpleCalc
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.Write("Введите X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Выберите тип операции: 1.Сложение, 2.Вычитание, 3.Умножение");
            byte operation = Convert.ToByte(Console.ReadLine());
            
            switch (operation)
            {
                case 1:
                    Console.WriteLine(x + y);
                    break;
                    
                case 2:
                    Console.WriteLine(x - y);
                    break;
                    
                case 3:
                    Console.WriteLine(x * y);
                    break;
                    
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }
            
            Console.ReadKey();
            
        }
        
    }
    
}
