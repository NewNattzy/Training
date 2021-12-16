namespace Interfaces
{
    public interface ILocation
    {

        public char MapTyle { get; set; }

        public string Name { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Landscape { get; set; }

        public int Danger { get; set; }
        public int Population { get; set; }

        public void Destroy();

        public void Siege();

        public void Restored();

    }

}
