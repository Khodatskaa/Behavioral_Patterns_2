using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_2
{
    public class InjuredState : ICharacterState
    {
        private GameCharacter? _context;

        public void SetContext(GameCharacter context)
        {
            _context = context;
        }

        public void Attack()
        {
            Console.WriteLine("Character is injured and cannot attack effectively.");
        }

        public void Defend()
        {
            Console.WriteLine("Character defends!");
        }

        public void Injure()
        {
            Console.WriteLine("Character is already injured.");
        }

        public void Heal()
        {
            _context.TransitionTo(new AliveState());
        }
    }

}
