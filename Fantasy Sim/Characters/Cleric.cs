using Fantasy_Sim.Skills;

namespace Fantasy_Sim.Characters {
    public class Cleric : ICharacter {
        public string Type() => "Cleric";
        public int Health() => 150;
        public int Attack() => 20;
        public int Defense() => 30;
        public int Mana() => 100;
        public List<INewSkill> Skills { get; set; } = new List<INewSkill>();

        public void AddSkill(INewSkill skill) {
            Skills.Add(skill);
        }

        public void UseSkill(string skillName) {
            INewSkill useSkill = Skills.FirstOrDefault(s => s.Name() == skillName);
            if(useSkill != null) {
                useSkill.Activate();
            } else {
                Console.WriteLine("Skill not found.");
            }
        }
    }
}
