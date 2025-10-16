namespace Fantasy_Sim.Inventory {
    public interface IInventoryRepository {
        IEnumerable<Item> GetAll();
        Item GetById(int id);
        void AddItem(Item item);
        void DeleteItem(int id);
    }
}
