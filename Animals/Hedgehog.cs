using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Hedgehog : Animal
    {
        public string FavFood { get; set; }
        public Hedgehog(string name, int age, double weight, string colour, string favFood) : base(name, age, weight, colour)
        {
            FavFood = favFood;
        }
        public override void DoSound()
        {
            Console.WriteLine("Meep!");
        }

        public override string Stats()
        {
            return $"Hedgehog Name: {Name}\nHedgehog Age: {Age}\nHedgehog Weight: {Weight}\nHedgehog Colour: {Colour}\nHedgehog Favourite Food: {FavFood}";
        }
    }
}
