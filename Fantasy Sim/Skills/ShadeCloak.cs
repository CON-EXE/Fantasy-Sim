namespace Fantasy_Sim.Skills {
    public class ShadeCloak : INewSkill {
        public string Name() => "Shade Cloak";
        public int ManaCost() => 25;
        public void Activate() {
            Console.WriteLine("Become undetectable!");
        }
    }
}
