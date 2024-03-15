namespace Behavioral_Patterns_2
{
    public class Program
    {
        static void Main()
        {
            Building building = new Building("Skyscraper", 100);
            BuildingHistory history = new BuildingHistory();

            history.Memento = building.Save(); 

            building.Grow(50); 
            history.Memento = building.Save(); 

            building.Grow(30); 
            Console.WriteLine("Building collapsed!"); 

            building.Restore(history.Memento);

            building.ChangeName("Empire State Building");
            building.PrintDetails();
        }
    }
}
