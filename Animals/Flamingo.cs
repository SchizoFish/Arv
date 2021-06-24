using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv.Animals
{
    class Flamingo : Bird
    {
        public bool OneLegUp { get; set; }
        public Flamingo(string name, int age, double weight, string colour, double wingSpan, bool onelegup) : base(name, age, weight, colour, wingSpan)
        {
            OneLegUp = onelegup;
        }

        public override string Stats()
        {
            return $"Bird Name: {Name}\nBird Age: {Age}\nBird Weight: {Weight}\nBird Colour: {Colour}\nBird Wingspan: {Wingspan}\nOne Leg Up: {OneLegUp}";
        }
    }
}
