namespace Fantasy_Sim.Inventory {
    public class Item {
        public int Id { get; set; }
        public string Name { get; set; }

        private static int NextId = 1;

        public Item(int id, string name) {
            Id = NextId;
            Name = name;
            NextId++;
        }
    }
}
