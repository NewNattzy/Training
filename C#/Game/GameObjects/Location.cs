using Interfaces;

namespace GameObjects
{
    public abstract class Location : ILocation
    {

        internal static int locationCount = 0;

        private string name = "default";
        private string status = "normal";
        private string type = "default";
        private string landscape = "default";

        private int danger = 0;
        private int population = 0;


        public Location(string name, string type, string landscape, int danger, int population)
        {
            locationCount++;
            this.name = name;
            this.type = type;
            this.landscape = landscape;
            this.danger = danger;  
            this.population = population;
        }

        #region Property
        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public string Landscape
        {
            get => landscape;
            set => landscape = value;
        }

        public string Status
        {
            get => status;
            set => status = value;
        }

        public int Danger
        {
            get => danger;
            set => danger = value;
        }

        public int Population
        {
            get => population;
            set => population = value;
        }
        #endregion

        public void Destroyed()
        {
            Status = "Уничтожен";
            Population = 0;
            Danger = 7;
        }

        public abstract void Sieged();
        public abstract void Cursed();
        public abstract void Improved();
      
    }

}
