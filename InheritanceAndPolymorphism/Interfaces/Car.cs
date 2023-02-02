using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism.Interfaces
{
    public interface IColor 
    {
        void GetColor();       
    }

    public interface IEquipment
    {
        void GetEquipment();
    }
    internal class Car : IColor, IEquipment
    {
        public string Color { get; set; }
        public string Equipment { get; set; }

        public Car(string color, string equipment)
        {
            Color = color;
            Equipment = equipment;
        }

        public void GetColor()
        {
            Console.WriteLine("Color: "+Color);
        }

        public void GetEquipment()
        {
            Console.WriteLine("Equipment: "+Equipment);
        }
    }
}
