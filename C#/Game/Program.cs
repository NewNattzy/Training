using System;
using Creature;

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
                Console.Write($"{playername}: ");
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

            int basehealth = 0;
            int basemana = 0;
            int gold = 0;

            switch (playerspecial)
            {
                case "Воин":
                    basehealth = 200;
                    basemana = 50;
                    gold = 0;
                    break;
                case "Маг":
                    basehealth = 75;
                    basemana = 200;
                    gold = 50;
                    break;
                case "Лучник":
                    basehealth = 150;
                    basemana = 100;
                    gold = 150;
                    break;
            }

            // Создаем игрока, проверяем корректность статов
            Player player = new Player(playername, basehealth, basemana, 10, 1, gold, playerspecial);
            Console.WriteLine("Характеристики персонажа");
            Console.WriteLine($"Имя героя: {player.name}");
            Console.WriteLine($"Класс: {player.special}");
            Console.WriteLine($"Уровень: {player.Level}");
            Console.WriteLine($"Здоровье: {player.Health}");
            Console.WriteLine($"Мана: {player.Mana}");
            Console.WriteLine($"Золото: {player.Gold}");
            Console.WriteLine($"Опыт: {player.Exp}");
            Console.WriteLine("Оракул: Твои приключения начинаются!");
            Console.ReadKey();
        }
    }
}
