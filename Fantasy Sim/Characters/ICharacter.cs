using Fantasy_Sim.Skills;

namespace Fantasy_Sim.Characters {
    public interface ICharacter {
        string Type();
        int Health();
        int Attack();
        int Defense();
        int Mana();
        IEnumerable<INewSkill> Skills();
    }
}
