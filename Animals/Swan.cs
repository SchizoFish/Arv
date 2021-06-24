using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv.Animals
{
    class Swan : Bird
    {
        public bool UglyDuckling { get; set; }
        public Swan(string name, int age, double weight, string colour, double wingSpan, bool uDuckling) : base(name, age, weight, colour, wingSpan)
        {
            UglyDuckling = uDuckling;
        }

        public override string Stats()
        {
            return $"Swan Name: {Name}\nSwan Age: {Age}\nSwan Weight: {Weight}\nSwan Colour: {Colour}\nSwan Wingspan: {Wingspan}\nSwan Was Ugly Duckling: {UglyDuckling}";
        }
    }
}
