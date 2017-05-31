using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class Path
    {
        //conroh encapsulation
        private readonly MapLocation[] _path; //kalau private pakai _
        public int Length
        {
            get
            {
               return _path.Length;
            }
        }

        //general constructor
        //array isinya maplocation disebut path
        public Path(MapLocation[] path)
        {
            //cara lain selain yg dibawah -> this.path = path
            //array diisi sebagai _path
            _path = path;
        }

        public MapLocation getLocationAt(int pathStep)
        {
           /* if (pathStep < _path.Length)
                return _path[pathStep];
            else
                return null;*/

            //cara ke 2 : if ternary
            return pathStep < _path.Length ? _path[pathStep] : null;
        }
    }
}
