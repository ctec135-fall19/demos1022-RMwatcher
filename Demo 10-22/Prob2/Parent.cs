﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Parent
    {
        // Show that a method belonging to the base class is called from a 
        // child instance
        public void ParentMethod()
        {
            Console.WriteLine("Parent Method");
        }

        // demoonstrate overriding a base class metod by a class
        public virtual void SomeMethod()
        {
            Console.WriteLine("Parent's SomeMethod");
        }

        // Demonstrate a child method calling the parent's method
        public virtual void Method2()
        {
            Console.WriteLine("Parent.Method2");
        }
    }
}
