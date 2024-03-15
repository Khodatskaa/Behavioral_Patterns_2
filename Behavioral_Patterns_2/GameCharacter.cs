using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_2
{
    public class GameCharacter
    {
        private ICharacterState _state;

        public GameCharacter()
        {
            TransitionTo(new AliveState());
        }

        public void TransitionTo(ICharacterState state)
        {
            Console.WriteLine($"GameCharacter: Transition to {state.GetType().Name}.");
            _state = state;
            _state.SetContext(this);
        }

        public void Attack()
        {
            _state.Attack();
        }

        public void Defend()
        {
            _state.Defend();
        }

        public void Resurrect()
        {
            TransitionTo(new AliveState());
        }
    }
}
