namespace Fantasy_Sim.Characters {
    public class Hunter : ICharacter {
        public string Type() => "Hunter";
        public int Health() => 100;
        public int Attack() => 50;
        public int Defense() => 20;
        public void UseAbility1() {
            Console.WriteLine("Back Slash");
        }
        public void UseAbility2() {
            Console.WriteLine("Quick Step");
        }
        public void UseAbility3() {
            Console.WriteLine("Shadow Strike");
        }
    }
}
