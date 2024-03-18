using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Example2
{
    public class Dog :Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Kopek Sesi");
        }
    }
}
