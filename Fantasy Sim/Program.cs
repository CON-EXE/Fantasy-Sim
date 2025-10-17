using Fantasy_Sim.Characters;
using Fantasy_Sim.Game;

namespace Fantasy_Sim {
    internal class Program {
        static void Main(string[] args) {
            ICharacterFactory factory1 = new KnightFactory();

            ICharacter character = factory1.CreateCharacter();

            GameState.GetInstance().AddCharacter(factory.CreateCharacter());
            Console.WriteLine(GameState.GetInstance().Characters[0].Type());

            //Console.WriteLine(character.Type());
            //character.UseAbility1();
        }

        public static void SeedData() {
            ICharacterFactory factory1 = new KnightFactory();
            ICharacterFactory factory2 = new ClericFactory();
            ICharacterFactory factory3 = new HunterFactory();

            GameState.GetInstance().AddCharacter(factory1.CreateCharacter());
            GameState.GetInstance().AddCharacter(factory2.CreateCharacter());
            GameState.GetInstance().AddCharacter(factory3.CreateCharacter());

            
        }
    }
}
