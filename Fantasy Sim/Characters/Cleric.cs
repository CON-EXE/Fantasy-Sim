namespace Fantasy_Sim.Characters {
    public class Cleric : ICharacter {
        public string Type() => "Cleric";
        public int Health() => 150;
        public int Attack() => 20;
        public int Defense() => 30;
        public void UseAbility1() {
            Console.WriteLine("Heal Round");
        }
        public void UseAbility2() {
            Console.WriteLine("Hypnosis");
        }
        public void UseAbility3() {
            Console.WriteLine("Holy Smite");
        }
    }
}
