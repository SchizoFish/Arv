using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Wolf : Animal
    {
        public bool IsDire { get; set; }
        public Wolf(string name, int age, double weight, string colour, bool isDire) : base(name, age, weight, colour)
        {
            IsDire = isDire;
        }
        public override void DoSound()
        {
            Console.WriteLine("Grrr");
        }

        public override string Stats()
        {
            return $"Wolf Name: {Name}\nWolf Age: {Age}\nWolf Weight: {Weight}\nWolf Colour: {Colour}\nWolf Is Dirw Wolf: {IsDire}";
        }
    }
}
