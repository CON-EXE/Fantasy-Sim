using Fantasy_Sim.Skills;

namespace Fantasy_Sim.Characters {
    public class Knight : ICharacter {
        public string Type() => "Knight";
        public int Health() => 200;
        public int Attack() => 20;
        public int Defense() => 50;
        public int Mana() => 50;
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
