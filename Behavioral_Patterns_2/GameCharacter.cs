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
            Console.WriteLine($"Character transitions to {state.GetType().Name} state.");
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

        public void Injure()
        {
            _state.Injure();
        }

        public void Heal()
        {
            _state.Heal();
        }

        public void Resurrect()
        {
            TransitionTo(new AliveState());
        }
    }

}
