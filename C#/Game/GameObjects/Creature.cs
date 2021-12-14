namespace GameObjects
{

    public abstract class Creature
    {

        public string Name;

        private protected int health;
        private protected int mana;

        private int damage;
        private int level;
        private int gold;

        public Creature(string name, int basehealth, int basemana, int damage, int level, int gold)
        {
            Name = name;
            this.level = level;
            health = basehealth * level;
            mana = basemana * level;
            this.damage = damage;
            this.gold = gold;
        }

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }

        public abstract int Health { get; set; }

        public abstract int Mana { get; set; }

        public abstract void Talk(string words);

        //public Enemy this [int index]
        //{
        //    get { return }
        //}

    }

}
