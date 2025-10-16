using Fantasy_Sim.Characters;
using Fantasy_Sim.Game;

namespace Fantasy_Sim {
    internal class Program {
        static void Main(string[] args) {
            ICharacterFactory factory = new KnightFactory();

            ICharacter character = factory.CreateCharacter();

            GameState.GetInstance().AddCharacter(factory.CreateCharacter());
            Console.WriteLine(GameState.GetInstance().Characters[0].Type());

            //Console.WriteLine(character.Type());
            //character.UseAbility1();
        }
    }
}
