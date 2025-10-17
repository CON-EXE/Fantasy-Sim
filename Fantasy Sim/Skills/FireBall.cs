namespace Fantasy_Sim.Skills {
    public class FireBall : INewSkill {
        public string Name() => "FireBall";
        public int ManaCost() => 50;
        public void Activate() {
            Console.WriteLine("I don't care how big the room is I cast FireBall!");
        }
    }
}
