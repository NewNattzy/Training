using System;
using Creature;
using Generator;

namespace ConsoleGame
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Object Player = CreacureGenerate.PlayerCreate();
            Console.WriteLine("Характеристики персонажа");
            Console.WriteLine($"Имя героя: {Player.name}");
            Console.WriteLine($"Класс: {Player.special}");
            Console.WriteLine($"Уровень: {Player.Level}");
            Console.WriteLine($"Здоровье: {Player.Health}");
            Console.WriteLine($"Мана: {Player.Mana}");
            Console.WriteLine($"Золото: {Player.Gold}");
            Console.WriteLine($"Опыт: {Player.Exp}");
            Console.WriteLine("Оракул: Твои приключения начинаются!");
            Console.ReadKey();
        }
    }
}
