using System;
using Character;

namespace ConsoleGame
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string? playername = "";
            while (true)
            { 
                Console.WriteLine("Оракул: Введи свое имя");
                Console.Write("Ты: ");
                playername = Console.ReadLine();
                if (playername != "")
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
            }
            
            string[] special = { "Воин", "Маг", "Лучник" };
            string? playerspecial = "";
            bool specialchoice = false;
            while (specialchoice == false)
            {
                Console.WriteLine($"Оракул: Отлично, {playername}. Теперь выбери свою судьбу. Ты Воин, Маг или Лучник?");
                Console.Write($" {playername}:");
                playerspecial = Console.ReadLine();
                foreach (string i in special)
                {
                    if (i == playerspecial)
                    { 
                        specialchoice = true;
                        Thread.Sleep(1000);
                    }
                    Console.Clear();
                }
            }

            Console.WriteLine("Оракул: Твои преключения начинаются!");
            Player player = new Player(playername, playerspecial);
        }
    }
}
