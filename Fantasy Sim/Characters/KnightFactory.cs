namespace Fantasy_Sim.Characters {
    public class KnightFactory : ICharacterFactory {
        public ICharacter CreateCharacter() {
            return new Knight();
        }
    }
}
