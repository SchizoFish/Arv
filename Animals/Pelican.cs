using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv.Animals
{
    class Pelican : Bird
    {
        public double BeakWidth { get; set; }
        public Pelican(string name, int age, double weight, string colour, double wingSpan, double beakWidth) : base(name, age, weight, colour, wingSpan)
        {
            BeakWidth = beakWidth;
        }

        public override string Stats()
        {
            return $"Pelican Name: {Name}\nPelican Age: {Age}\nPelican Weight: {Weight}\nPelican Colour: {Colour}\nPelican Wingspan: {Wingspan}\nPelican Beak Width: {BeakWidth}";
        }
    }
}
