namespace Character { 
    class Player
    {
        private string? name;
        private string? special;
        public Player(string? playername, string? special)
        {
            this.Name = playername;
            this.Special = special;
        }
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }
        public string? Special
        {
            get { return special; }
            set { special = value; }
        }
    }
}
