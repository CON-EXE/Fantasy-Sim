namespace Fantasy_Sim.Skills {
    public class BackSlash : INewSkill {
        public string Name() => "Back Slash";
        public int ManaCost() => 40;
        public void Activate() {
            Console.WriteLine("Strike from behind!");
        }
    }
}
