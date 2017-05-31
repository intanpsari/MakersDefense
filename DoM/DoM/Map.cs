using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class Map
    {
        //readonly : supaya nilainya ga bisa diganti
        public readonly int Height;
        public readonly int Width;

        //constructor general
        public Map(int width, int height)
        {
            Height = height;
            Width = width;
        }

        public bool onMap(Point point)
        {
            bool panjang = point.X < Width && point.X >= 0;
            bool lebar = point.Y < Height && point.Y >= 0;

            return panjang && lebar;
        } 
        
    }
}
