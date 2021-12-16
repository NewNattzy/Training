using Interfaces;

namespace GameObjects
{
    public abstract class Location : ILocation
    {

        private char mapTyle = '?';

        private protected string name = "default";
        private protected string status = "normal";
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

        #region Property
        public char MapTyle
        {
            get => mapTyle;
            set => mapTyle = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Status
        {
            get => status;
            set => status = value;
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

        #region Methods
        public void Destroy()
        {
            status = "Уничтожен";
            population = 0;
            danger = 5;
            mapTyle = 'D';
        }

        public void Siege()
        {
            status = "Осажден";

            if (population % 2 == 0 && population != 0)
                population /= 2;
            else
            {
                population++;
                population /= 2;
            }
                
            danger = 10;
            mapTyle = 'S';
        }

        public void Restored()
        {
            status = "Восстановлен";
            population += 100;
            danger = 2;
            mapTyle = 'R';
        }
        #endregion

    }

}
