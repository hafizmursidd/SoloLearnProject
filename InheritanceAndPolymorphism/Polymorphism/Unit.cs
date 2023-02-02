using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism.Polymorphism
{
    internal class Unit
    {
        public virtual void Attack()
        {
            Console.WriteLine("Using sword!");
        }
    }

    /*derive the class from Unit class
    and override Attack() method*/
    class Musketeer : Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Using musket!");
        }

    }
    /*derive the class from Unit class
    and override Attack() method*/
    class Magician : Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Using magic!");
        }


    }
}

