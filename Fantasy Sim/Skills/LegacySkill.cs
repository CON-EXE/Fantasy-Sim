namespace Fantasy_Sim.Skills {
    public class LegacySkill {
        public string SkillName { get; set; }
        public int EnergyCost { get; set; }
        public string UseText { get; set; }

        public LegacySkill(string skillName, int energyCost, string useText) {
            SkillName = skillName;
            EnergyCost = energyCost;
            UseText = useText;
        }

        public void UseSkill() {
            Console.WriteLine(UseText);
        }
    }
}