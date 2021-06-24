using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Horse : Animal
    {
        public int Speed { get; set; }
        public Horse(string name, int age, double weight, string colour, int speed) : base(name, age, weight, colour)
        {
            Speed = speed;
        }
        public override void DoSound()
        {
            Console.WriteLine("...neigh?");
        }

        public override string Stats()
        {
            return $"Horse Name: {Name}\nHorse Age: {Age}\nHorse Weight: {Weight}\nHorse Colour: {Colour}\nHorse Speed: {Speed}";
        }

    }
}
