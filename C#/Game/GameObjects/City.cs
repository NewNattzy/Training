using GameConfig;

namespace GameObjects
{
    public class City : Location
    {

        private static int maxPopulation = Config.BaseLocationPopulation * 40;

        public City(string name, string type, string landscape, int danger, int population)
            : base (name, type, landscape, danger, population)
        {

        }

        public override void Sieged()
        {
            Status = "Осажден";

            if (Population % 2 == 0 && Population != 0)
                Population /= 2;
            else if (Population < 99)
                Destroyed();
            else
            {
                Population++;
                Population /= 2;
            }

            Danger = 8;
        }

        public override void Cursed()
        {
            Status = "Проклят";
            Population -= 50 * Danger;

            if (Population <= 0)
                Destroyed();
            if (Danger < 10)
                Danger++;
        }

        public override void Improved()
        {
            if (Population < maxPopulation)
                Population += 250;
            else if (Population > maxPopulation)
            { 
                Population = maxPopulation;
                Status = "Процветает";
                Danger = 0;
            }  
        }

    }

}
