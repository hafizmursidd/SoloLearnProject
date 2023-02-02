using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism.Polymorphism
{
    internal static class RunPolymorphism
    {
        public static void Running ()
        { 
        Unit unit1 = new Unit();
        Unit musketeer = new Musketeer();
        Unit magician = new Magician();

        unit1.Attack();
        musketeer.Attack();
        magician.Attack();

            }
    }
}

