using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_2
{
    public class DeadState : ICharacterState
    {
        private GameCharacter? _context;

        public void SetContext(GameCharacter context)
        {
            _context = context;
        }

        public void Attack()
        {
            Console.WriteLine("Character is dead and cannot attack!");
        }

        public void Defend()
        {
            Console.WriteLine("Character is dead and cannot defend!");
        }
    }
}
