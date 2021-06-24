using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, double weight, string sound, bool isDire) : base(name, age, weight, sound, isDire)
        {

        }

        public void Talk()
        {
            Console.WriteLine("How did I become like this?");
        }
    }
}
