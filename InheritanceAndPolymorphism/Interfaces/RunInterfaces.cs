using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism.Interfaces
{
    internal class RunInterfaces
    {
        public static void Running() {

            string color = "Red Doff";
            string Equip = "Standard";

            //car1.Color = "REd";
            Car car1 = new Car (color,Equip);
            car1.GetColor();
            car1.GetEquipment();
        }
    }
}
