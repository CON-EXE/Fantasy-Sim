namespace Fantasy_Sim.Skills {
    public class MountainStance : INewSkill {
        public string Name() => "MountainStance";
        public int ManaCost() => 30;
        public void Activate() {
            Console.WriteLine("Become unbreakable!");
        }
    }
}
