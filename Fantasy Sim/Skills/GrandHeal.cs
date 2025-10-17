namespace Fantasy_Sim.Skills {
    public class GrandHeal : INewSkill {
        public string Name() => "Grand Heal";
        public int ManaCost() => 30;
        public void Activate() {
            Console.WriteLine("");
        }
    }
}
