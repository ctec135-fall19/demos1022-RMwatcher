using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Child : Parent
    {
        // demoonstrate overriding a base class metod by a class
        public override void SomeMethod()
        {
            Console.WriteLine("Child's SomeMethod");
        }

        // Demonstrate a child method calling the parent's method
        public override void Method2()
        {
            // use base keyword to add basic behavior
            base.Method2(); 
            Console.WriteLine("Child.Method2");
        }
    }
}
