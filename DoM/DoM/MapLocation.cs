using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class MapLocation : Point //menandakan MapLocarion keturunan dari Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.onMap(this))
            {
                throw new OutOfBoundsException("ga ada poinya"); //buat exception yg ada di game.cs . ngecek ada di map atau tidak
            }
        }

        public bool InRangeOf(MapLocation mapLocation, int range)
        {
            return distanceTo(mapLocation) <= range;
        }
    }
}
