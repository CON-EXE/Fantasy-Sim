using Fantasy_Sim.Characters;
using Fantasy_Sim.Game;
using Fantasy_Sim.Inventory;
using Fantasy_Sim.Skills;

namespace Fantasy_Sim {
    internal class Program {
        static InventoryRepository inventory = new InventoryRepository();
        static void Main(string[] args) {
            SeedData();

            Console.WriteLine("Created Characters:");
            Console.WriteLine(GameState.GetInstance().Characters[0].Type());
            Console.WriteLine(GameState.GetInstance().Characters[1].Type());
            Console.WriteLine(GameState.GetInstance().Characters[2].Type());

            Console.WriteLine("Using a Skill:");
            GameState.GetInstance().Characters[0].UseSkill("Mountain Stance");
            Console.WriteLine("Using a Legacy Skill:");
            GameState.GetInstance().Characters[0].UseSkill("Heavy Slash");

            Console.WriteLine();
            Console.WriteLine("Changing Environment:");
            Console.WriteLine("Current Environment: " + GameState.GetInstance().Environment);
            GameState.GetInstance().SetEnvironment("High Peaks");
            Console.WriteLine("New Environment: " + GameState.GetInstance().Environment);
            Console.WriteLine("Updating Level");
            Console.WriteLine("Current Level: " + GameState.GetInstance().Level);
            GameState.GetInstance().IncreaseLevel();
            Console.WriteLine("New Level: " + GameState.GetInstance().Level);

            Console.WriteLine();
            Console.WriteLine("Inventory Management");
            Console.WriteLine("All Inventory Items:");
            foreach(Item item in inventory.GetAll()) {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
            }
            Console.WriteLine();

            // Get an item by Id
            Console.WriteLine("GetById Test:");
            Item found = inventory.GetById(3);
            if(found != null)
                Console.WriteLine($"Found item with Id 3: {found.Name}");
            else
                Console.WriteLine("Item not found.");
            Console.WriteLine();

            // Delete an item
            Console.WriteLine("Delete Test:");
            inventory.DeleteItem(2);
            Console.WriteLine("Deleted item with Id 2.");
            Console.WriteLine();

            // Display remaining items
            Console.WriteLine("Remaining Inventory:");
            foreach(Item item in inventory.GetAll()) {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
            }
            Console.WriteLine();

            // Verify deleted item
            Console.WriteLine("Check Deleted Item:");
            Item deletedItem = inventory.GetById(2);
            Console.WriteLine(deletedItem == null ? "Item successfully deleted." : "Item still exists.");
        }

        public static void SeedData() {
            //Theres a chance I went a bit overboard here

            //Create Characters
            ICharacterFactory factory1 = new KnightFactory();
            ICharacterFactory factory2 = new ClericFactory();
            ICharacterFactory factory3 = new HunterFactory();

            GameState.GetInstance().AddCharacter(factory1.CreateCharacter());
            GameState.GetInstance().AddCharacter(factory2.CreateCharacter());
            GameState.GetInstance().AddCharacter(factory3.CreateCharacter());
            
            //Add and assign skillss
            INewSkill skill1 = new FireBall();
            INewSkill skill2 = new GrandHeal();
            INewSkill skill3 = new ShieldBash();
            INewSkill skill4 = new MountainStance();
            INewSkill skill5 = new ShadeCloak();
            INewSkill skill6 = new BackSlash();

            GameState.GetInstance().AddSkill(skill1);
            GameState.GetInstance().AddSkill(skill2);
            GameState.GetInstance().AddSkill(skill3);
            GameState.GetInstance().AddSkill(skill4);
            GameState.GetInstance().AddSkill(skill5);
            GameState.GetInstance().AddSkill(skill6);
            //Legacy Skills adapted to new skills
            LegacySkill legacySkill1 = new LegacySkill("Thunder", 20, "Cast down thunder!");
            LegacySkill legacySkill2 = new LegacySkill("Heavy Slash", 10, "Crush your foes!");
            LegacySkill legacySkill3 = new LegacySkill("Assassinate", 40, "Silent execution!");

            INewSkill adaptedSkill1 = new LegacySkillAdapter(legacySkill1);
            INewSkill adaptedSkill2 = new LegacySkillAdapter(legacySkill2);
            INewSkill adaptedSkill3 = new LegacySkillAdapter(legacySkill3);

            GameState.GetInstance().AddSkill(adaptedSkill1);
            GameState.GetInstance().AddSkill(adaptedSkill2);
            GameState.GetInstance().AddSkill(adaptedSkill3);

            GameState.GetInstance().Characters[0].AddSkill(GameState.GetInstance().Skills.FirstOrDefault(s => s.Name() == "Mountain Stance"));
            GameState.GetInstance().Characters[0].AddSkill(GameState.GetInstance().Skills.FirstOrDefault(s => s.Name() == "Shield Bash"));
            GameState.GetInstance().Characters[0].AddSkill(GameState.GetInstance().Skills.FirstOrDefault(s => s.Name() == "Heavy Slash"));
            GameState.GetInstance().Characters[1].AddSkill(GameState.GetInstance().Skills.FirstOrDefault(s => s.Name() == "FireBall"));
            GameState.GetInstance().Characters[1].AddSkill(GameState.GetInstance().Skills.FirstOrDefault(s => s.Name() == "Grand Heal"));
            GameState.GetInstance().Characters[1].AddSkill(GameState.GetInstance().Skills.FirstOrDefault(s => s.Name() == "Thunder"));
            GameState.GetInstance().Characters[2].AddSkill(GameState.GetInstance().Skills.FirstOrDefault(s => s.Name() == "Shade Cloak"));
            GameState.GetInstance().Characters[2].AddSkill(GameState.GetInstance().Skills.FirstOrDefault(s => s.Name() == "Back Slash"));
            GameState.GetInstance().Characters[2].AddSkill(GameState.GetInstance().Skills.FirstOrDefault(s => s.Name() == "Assassinate"));

            // Add Items to inventory
            Item sword = new Item(0, "Sword of Flames");
            Item shield = new Item(0, "Dragon Scale Shield");
            Item potion = new Item(0, "Potion of Healing");
            Item staff = new Item(0, "Staff of Storms");
            Item ring = new Item(0, "Ring of Invisibility");

            inventory.AddItem(sword);
            inventory.AddItem(shield);
            inventory.AddItem(potion);
            inventory.AddItem(staff);
            inventory.AddItem(ring);
        }
    }
}
