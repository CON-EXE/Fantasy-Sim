namespace Fantasy_Sim.Characters {
    public class HunterFactory : ICharacterFactory {
        public ICharacter CreateCharacter() {
            return new Hunter();
        }
    }
}
