namespace GameObjectGenerator
{

    public static class PlayerGenerator
    {

        public static string[] PlayerCreate()
        {
            
            string playerName;
            string[] special = { "Воин", "Маг", "Лучник" };
            string playerSpecial = "";
            bool specialChoice = false;

            while (true)
            {
                Console.WriteLine("Оракул: Введи свое имя, герой!");
                Console.Write("Ты: ");
                playerName = Console.ReadLine();

                Console.Clear();

                if (playerName != "" && playerName.Length >= 3)
                    break;
            }

            Thread.Sleep(250);

            while (specialChoice == false)
            {
                Console.WriteLine($"Оракул: Отлично, {playerName}. Теперь выбери свою судьбу. Ты Воин, Маг или Лучник?");
                Console.Write($"{playerName}: ");
                playerSpecial = Console.ReadLine();

                foreach (string i in special)
                {
                    if (i == playerSpecial)
                        specialChoice = true;
                    
                    Console.Clear();
                }
            }

            Thread.Sleep(250);

            // TODO: Вернуть как было - int значения вместо string, попробовать вернуть объект в Main. Сейчас жуткий костыль.
            string baseHealth = "0";
            string baseMana = "0";
            string gold = "0";
            
            switch (playerSpecial)
            {
                case "Воин":
                    baseHealth = "200";
                    baseMana = "50";
                    gold = "0";
                    break;

                case "Маг":
                    baseHealth = "75";
                    baseMana = "200";
                    gold = "50";
                    break;

                case "Лучник":
                    baseHealth = "150";
                    baseMana = "100";
                    gold = "150";
                    break;
            }

            string[] playerStats = new string[] { playerName, baseHealth, baseMana, "10", "1", gold, playerSpecial };
            return playerStats;
            
        }
        
    }
    
}
