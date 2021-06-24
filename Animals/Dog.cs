using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string name, int age, double weight, string colour, string breed) : base(name, age, weight, colour)
        {
            Breed = breed;
        }
        public override void DoSound()
        {
            Console.WriteLine("Bark!");
        }

        public override string Stats()
        {
            return $"Dog Name: {Name}\nDog Age: {Age}\nDog Weight: {Weight}\nDog Colour: {Colour}\nDog Breed: {Breed}";
        }

        public string BarkThreeTimes()
        {
            return "Bark bark bark!";
        }
    }
}
