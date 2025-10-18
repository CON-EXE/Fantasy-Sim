using Fantasy_Sim.Skills;

namespace Fantasy_Sim.Characters {
    public interface ICharacter {
        string Type();
        int Health();
        int Attack();
        int Defense();
        int Mana();
        List<INewSkill> Skills { get; set; }
        void AddSkill(INewSkill skill);
        void UseSkill(string skillName);
    }
}
