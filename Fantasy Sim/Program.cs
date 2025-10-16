using Fantasy_Sim.Characters;

namespace Fantasy_Sim {
    internal class Program {
        static void Main(string[] args) {
            ICharacterFactory factory = new KnightFactory();

            ICharacter character = factory.CreateCharacter();

            Console.WriteLine(character.Type());
            character.UseAbility1();
        }
    }
}
