using Creature;

namespace Generator
{
    public static class CreacureGenerate
    {
        public static object PlayerCreate()
        {
            string? playername = "";
            while (true)
            {
                Console.WriteLine("Оракул: Введи свое имя, герой!");
                Console.Write("Ты: ");
                playername = Console.ReadLine();
                Console.Clear();
                if (playername != "" && playername.Length >= 3)
                    break;
            }

            string[] special = { "Воин", "Маг", "Лучник" };
            string? playerspecial = "";
            bool specialchoice = false;
            Thread.Sleep(250);
            while (specialchoice == false)
            {
                Console.WriteLine($"Оракул: Отлично, {playername}. Теперь выбери свою судьбу. Ты Воин, Маг или Лучник?");
                Console.Write($"{playername}: ");
                playerspecial = Console.ReadLine();
                foreach (string i in special)
                {
                    if (i == playerspecial)
                        specialchoice = true;
                    Console.Clear();
                }
            }

            int basehealth = 0;
            int basemana = 0;
            int gold = 0;
            Thread.Sleep(250);
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

            Player player = new Player(playername, basehealth, basemana, 10, 1, gold, playerspecial);
            return player;
        }
    }

    public static class LocationGenerate
    {

    }
}