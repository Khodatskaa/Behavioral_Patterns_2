using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_2
{
    public class AliveState : ICharacterState
    {
        private GameCharacter? _context;

        public void SetContext(GameCharacter context)
        {
            _context = context;
        }

        public void Attack()
        {
            Console.WriteLine("Character attacks!");
        }

        public void Defend()
        {
            Console.WriteLine("Character defends!");
        }
    }
}
