using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism.AbstractClass
{
    abstract class Figure
    {
        //define abstract method Perimeter with no body
        public abstract int Perimeter();
    }

    class Rectangle : Figure
    {
        public int width;
        public int height;

        public Rectangle(int width, int height)
        { 
            this.width = width;
            this.height = height;
        }
        public override int Perimeter()
        {
            return (width + height) * 2;
        }
    }

    class Triangle : Figure
    {
        public int side1;
        public int side2;
        public int side3;
        public Triangle(int side1, int side2, int side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public override int Perimeter()
        {
            return side1 + side2 + side3;
        }
    }
}
