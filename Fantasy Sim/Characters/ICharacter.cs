using Fantasy_Sim.Skills;

namespace Fantasy_Sim.Characters {
    public interface ICharacter {
        string Type();
        int Health();
        int Attack();
        int Defense();
        IEnumerable<INewSkill> Skills();
        void UseAbility1();
        void UseAbility2();
        void UseAbility3();
    }
}
