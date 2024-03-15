namespace Behavioral_Patterns_2
{
    public class Program
    {
        static void Main()
        {
            GameCharacter character = new GameCharacter();

            character.Attack();
            character.Defend();

            character.TransitionTo(new DeadState());
            character.Attack();
            character.Defend();

            character.Resurrect();
            character.Attack();
            character.Defend();
        }
    }
}
