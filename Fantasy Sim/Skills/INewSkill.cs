namespace Fantasy_Sim.Skills {
    public interface INewSkill {
        string Name();
        int ManaCost();
        void Activate();
    }
}
