using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Example2
{
    public class Animal
    {
       public virtual void Voice()
        {
            Console.WriteLine("Hayvan sesleri");
        }
    }
}
