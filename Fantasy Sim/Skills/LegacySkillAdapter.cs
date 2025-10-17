namespace Fantasy_Sim.Skills {
    public class LegacySkillAdapter : INewSkill {

        private readonly LegacySkill _legacySkill;

        public LegacySkillAdapter(LegacySkill legacySkill) {
            _legacySkill = legacySkill;
        }

        public string Name() => _legacySkill.SkillName;
        public int ManaCost() => _legacySkill.EnergyCost;
        
        public void Activate() {
            Console.WriteLine(_legacySkill.UseText);
        }
    }
}
