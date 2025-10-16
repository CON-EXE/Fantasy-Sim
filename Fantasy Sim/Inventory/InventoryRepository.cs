namespace Fantasy_Sim.Inventory {
    public class InventoryRepository : IInventoryRepository {
        public List<Item> Items { get; set; } = new List<Item>(); //In place of dbcontext
        public IEnumerable<Item> GetAll() {
            return Items;
        }

        public Item GetById(int id) {
            return Items.FirstOrDefault(i => i.Id == id);
        }

        public void AddItem(Item item) {
            if(item != null) {
                Items.Add(item);
            }
        }

        public void DeleteItem(int id) {
            Item item = Items.FirstOrDefault(i => i.Id == id);
            if(item != null) {
                Items.Remove(item);
            }
        }
    }
}
