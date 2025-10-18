using Fantasy_Sim.Skills;

namespace Fantasy_Sim.Characters {
    public class Hunter : ICharacter {
        public string Type() => "Hunter";
        public int Health() => 100;
        public int Attack() => 50;
        public int Defense() => 20;
        public int Mana() => 70;
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
