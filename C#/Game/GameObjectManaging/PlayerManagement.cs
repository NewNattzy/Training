using GameObjects;

namespace GameObjectManaging
{
    public static class PlayerManagement
    {

        public static Player CreatePlayer()
        {

            string? playerName = "";
            string? playerSpecial = "";
            string[] special = new string[] { "воин", "лучник", "маг" };

            bool isValidName = false;
            bool isValidSpecial = false;

            // TODO: Валидация имени (validate console.readline)
            while (!isValidName)
            {
                Console.WriteLine("Оракул: Введи свое имя, герой!");
                Console.Write("Ты: ");

                playerName = "Аргус"; // Console.ReadLine();

                Console.Clear();

                if (playerName != "" && playerName.Length >= 3)
                    isValidName = true;
            }

            // TODO: Валидация класса (validate console.readline)
            while (!isValidSpecial)
            {
                Console.WriteLine($"Оракул: Отлично, {playerName}. Теперь выбери свою судьбу. Ты воин, лучник или маг?");
                Console.Write($"{playerName}: ");

                playerSpecial = "воин"; // Console.ReadLine().ToLower();

                if (special.Contains(playerSpecial))
                    isValidSpecial = true;

                Console.Clear();
            }

            int baseHealth = 0;
            int baseMana = 0;
            int gold = 0;
            
            switch (playerSpecial)
            {
                case "воин":
                    baseHealth = 200;
                    baseMana = 50;
                    gold = 0;
                    break;

                case "лучник":
                    baseHealth = 150;
                    baseMana = 100;
                    gold = 150;
                    break;

                case "маг":
                    baseHealth = 75;
                    baseMana = 200;
                    gold = 50;
                    break;

                default:
                    break;
            }          

            return new Player(playerName, baseHealth, baseMana, 10, 1, gold, playerSpecial);

        }

        public static void LevelUP(Player player)
        {

            string? answer = "";
            string?[] variants = new string[] { "да", "конечно", "ага", "само собой", "точно" };

            Console.WriteLine($"Оракул: Сейчас у тебя {player.Exp} опыта и {player.Gold} золота. Для перехода на следующий уровень нужно {Player.newLevelExp} опыта и {player.Level*50} золота.");
            Console.WriteLine("Оракул: Ты точно хочешь поднять уровень? Враги тоже станут сильнее!");
            Console.Write($"{player.Name}: ");
            answer = Console.ReadLine();

            if (variants.Contains(answer.ToLower()))
            {

                if (player.Exp >= Player.newLevelExp && player.Gold >= player.Level*50)
                {
                    player.Exp -= Player.newLevelExp;
                    player.Gold -= player.Level*50;

                    player.Level++;
                    player.Health += player.Health;
                    player.Mana += player.Mana;
                    switch (player.Special)
                    {
                        case "воин":
                            player.Damage += 3;
                            break;

                        case "лучник":
                            player.Damage += 5;
                            break;

                        case "маг":
                            player.Damage += 1;
                            break;

                        default:
                            break;
                    }
                    Player.newLevelExp += Player.newLevelExp;

                    Console.WriteLine($"\nОракул: Твой уровень вырос! Теперь ты {player.Special} {player.Level} уровня.");
                    Console.WriteLine($"Оракул: Текущий опыт {player.Exp}, остаток золота {player.Gold}.\n");
                }
                else
                {
                    Console.WriteLine("\nОракул: У тебя недостаточно ресурсов. Приходи когда будешь готов!\n");
                }

            }
            else
            { 
                Console.WriteLine("\nОракул: Так я и думал.\n");
            }

        }

        public static void ShowPlayerInfo(Player player)
        {
            Console.WriteLine($"Имя персонажа : {player.Name}");
            Console.WriteLine($"Класс         : {player.Special}");
            Console.WriteLine($"Уровень       : {player.Level}");
            Console.WriteLine($"Здоровье      : {player.Health}");
            Console.WriteLine($"Мана          : {player.Mana}");
            Console.WriteLine($"Урон          : {player.Damage}");
            Console.WriteLine($"Опыт          : {player.Exp}");
            Console.WriteLine($"Золото        : {player.Gold}");
        }

    }

}
