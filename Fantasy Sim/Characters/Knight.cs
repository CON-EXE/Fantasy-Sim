namespace Fantasy_Sim.Characters {
    public class Knight : ICharacter {
        public string Type() => "Knight";
        public int Health() => 200;
        public int Attack() => 20;
        public int Defense() => 50;
        public void UseAbility1() {
            Console.WriteLine("Mountain Stance");
        }
        public void UseAbility2() {
            Console.WriteLine("Shield Bash");
        }
        public void UseAbility3() {
            Console.WriteLine("Heavy Rush");
        }
    }
}
