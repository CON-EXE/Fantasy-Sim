using Fantasy_Sim.Characters;
using System;

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
    }
}
