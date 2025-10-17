namespace Fantasy_Sim.Skills {
    public class ShieldBash : INewSkill {
        public string Name() => "Shield Bash";
        public int ManaCost() => 20;
        public void Activate() {
            Console.WriteLine("Parry this you filthy casual!");
        }
    }
}
