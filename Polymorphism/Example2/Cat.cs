using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Example2
{
    internal class Cat :Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Kedi sesi");
        }
    }
}
