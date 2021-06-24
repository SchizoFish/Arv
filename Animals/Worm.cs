using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Worm : Animal
    {
        public string FavFood { get; set; }
        public Worm(string name, int age, double weight, string colour, string favFood) : base(name, age, weight, colour)
        {
            FavFood = favFood;
        }
        public override void DoSound()
        {
            Console.WriteLine("Splat");
        }

        public override string Stats()
        {
            return $"Worm Name: {Name}\nWorm Age: {Age}\nWorm Weight: {Weight}\nWorm Colour: {Colour}\nWorm Favourite Food: {FavFood}"; ;
        }
    }
}
