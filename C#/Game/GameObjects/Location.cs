namespace GameObjects
{
    public abstract class Location
    {

        private protected string name = "default";
        private protected string type = "default";
        private protected string landscape = "default";

        private protected int danger = 0;
        private protected int population = 0;


        public Location(string name, string type, string landscape, int danger, int population)
        {
            this.name = name;
            this.type = type;
            this.landscape = landscape;
            this.danger = danger;  
            this.population = population;
        }

        public int Population
        {
            get => population;
            set => population = value;
        }

    }

}
