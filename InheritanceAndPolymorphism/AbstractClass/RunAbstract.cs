using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism.AbstractClass
{
    internal class RunAbstract
    {
        public static void Running()
        {
            Figure rectangle = new Rectangle(5, 6);
            Figure triangle = new Triangle(4, 8, 3);

            Console.WriteLine(rectangle.Perimeter());
            Console.WriteLine(triangle.Perimeter());
        }


    }
}
