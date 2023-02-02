using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnumFiles.Struct
{
    internal class RunStruct
    {
        public static void Running()
        {
            int length = 5;
            int width = 4;
            int height = 5;

            Cuboid cuboid = new Cuboid(length, width, height);

            Console.WriteLine("Volume: " + cuboid.Volume());
            Console.WriteLine("Perimeter: " + cuboid.Perimeter());
        }
    }
}
