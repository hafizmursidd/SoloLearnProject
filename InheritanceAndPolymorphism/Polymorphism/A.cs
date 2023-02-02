using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism.Polymorphism
{
    class A
    {
        public A() {
            Console.WriteLine("a");
        }        
    }

    class B : A {
        public B()
        {
            Console.WriteLine("b");
        }
    }
}
