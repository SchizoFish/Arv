using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv.Animals
{
    class Bird : Animal
    {
        // F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut,
        // i vilken klass bör vi lägga det?
        // Om alla fåglar behöver ett nytt attribut bör det läggas här, i Bird klassen, då fåglarna ärver härifrån
        public double Wingspan { get; set; }
        public Bird(string name, int age, double weight, string colour, double wingSpan) : base(name, age, weight, colour)
        {
            Wingspan = wingSpan;
        }
        public override void DoSound()
        {
            Console.WriteLine("Chirp!");
        }

        public override string Stats()
        {
            return $"Bird Name: {Name}\nBird Age: {Age}\nBird Weight: {Weight}\nBird Colour: {Colour}\nBird Wingspan: {Wingspan}";
        }
    }
}
