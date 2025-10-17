using Fantasy_Sim.Characters;
using Fantasy_Sim.Skills;

namespace Fantasy_Sim.Game {
    public class GameState {
        private static GameState _instance;
        private static readonly object _lock = new object();

        private GameState() { }

        public static GameState GetInstance() {
            if(_instance == null) {
                lock(_lock) {
                    if (_instance == null) {
                        _instance = new GameState();
                    }
                }
            }
            return _instance;
        }

        public List<ICharacter> Characters { get; set; } = new List<ICharacter>();
        public List<INewSkill> Skills { get; set; } = new List<INewSkill>();
        public int Level { get; set; } = 1;
        public string Environment { get; set; }

        public void SetEnvironment() {
            Console.Write("Enter Environment Details: ");
            Environment = Console.ReadLine();
        }

        public void AddCharacter(ICharacter character) {
            if(character != null) {
                Characters.Add(character);
            }
        }

        public void AddSkill(INewSkill skill) {
            if(skill != null) {
                Skills.Add(skill);
            }
        }

        public void IncreaseLevel() {
            Level++;
        }
    }
}
