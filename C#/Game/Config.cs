namespace GameConfig
{
    public static class Config
    {

        static private int mapSize = 100;
        static private int gameObjectsLimit = 100;
        static private int creatureMaxLevel = 100;
        static private string gameDifficulty = "Normal";

        public static int MapSize
        {
            get => mapSize;
            set => mapSize = value;
        }

        public static int GameObjectsLimit
        {
            get => gameObjectsLimit;
            set => gameObjectsLimit = value;
        }

        public static int CreatureMaxLevel
        {
            get => creatureMaxLevel;
            set => creatureMaxLevel = value;
        }

        public static string GameDifficulty
        {
            get => gameDifficulty;
            set => gameDifficulty = value;
        }

    }

}
