using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnumFiles.Struct
{
    struct Cuboid
    {
        public int length;
        public int width;
        public int height;

        //create a constructor
        public Cuboid(int l, int w, int h)
        {
            length = l;
            width = w;
            height = h;
        }

        //complete this method
        public int Volume()
        {
            return length * width * height;
        }
        //complete this method
        public int Perimeter()
        {
            return (length + width + height) * 4;
        }
    }
}
