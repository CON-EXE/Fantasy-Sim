namespace Fantasy_Sim.Characters {
    public class ClericFactory : ICharacterFactory {
        public ICharacter CreateCharacter() {
            return new Cleric();
        }
    }
}
