using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_2
{
    public class Building
    {
        public string Name { get; }
        public int Height { get; private set; }

        public Building(string name, int height)
        {
            Name = name;
            Height = height;
        }

        public void Grow(int amount)
        {
            Height += amount;
            Console.WriteLine($"{Name} grew by {amount} meters. New height: {Height} meters.");
        }

        public BuildingMemento Save()
        {
            return new BuildingMemento(Name, Height);
        }

        public void Restore(BuildingMemento memento)
        {
            Height = memento.Height;
            Console.WriteLine($"{Name} restored to height: {Height} meters.");
        }
    }

    public class BuildingMemento
    {
        public string Name { get; }
        public int Height { get; }

        public BuildingMemento(string name, int height)
        {
            Name = name;
            Height = height;
        }
    }
}
