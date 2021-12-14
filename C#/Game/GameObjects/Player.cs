namespace GameObjects
{

    public class Player : Creature
    {

        private int exp = 0;
        public string Special;

        public Player(string name, int basehealth, int basemana, int damage, int level, int gold, string special)
            : base(name, basehealth, basemana, damage, level, gold)
        {
            Special = special;
        }

        // TODO: Добавить модификаторы в зависимости от уровня сложности под игрока
        public override int Health
        {
            get { return health; }
            set { health = value; }
        }

        public override int Mana
        {
            get { return mana; }
            set { mana = value; }
        }

        public int Exp
        {
            get { return exp; }
            set { exp = value; }
        }

        // TODO: Реализовать механику разговоров под игрока
        public override void Talk(string words)
        {
            Console.WriteLine($"{this.Name} say: {words}");
        }

    }

}
