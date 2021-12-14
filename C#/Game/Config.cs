namespace GameConfig
{
    public static class Config
    {

        static private int mapSize = 100;
        static private int gameObjectsLimit = 100;
        static private string difficulty = "Normal";

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
        public static string Difficulty
        {
            get => difficulty;
            set => difficulty = value;
        }

    }

}
