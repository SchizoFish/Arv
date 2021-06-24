using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    abstract class Animal
    {
        // F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
        // Om alla djur behöver ett nytt attribut bör det läggas här, i Animal klassen,
        // då djur klasserna ärver härifrån
        public Animal(string name, int age, double weight, string colour)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Colour = colour;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Colour { get; set; }

        abstract public void DoSound();

        // Polymorfism uppg.
        public virtual string Stats()
        {
            return $"Animal Name: {Name}\nAnimal Age: {Age}\nAnimal Weight: {Weight}\nAnimal Colour: {Colour}";
        }
    }
}
