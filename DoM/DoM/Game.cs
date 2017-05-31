using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8,5);

            try
            {
                //MapLocation point2 = new MapLocation(7, 2, map);

                Path path = new Path(
                new[]
                {
                    new MapLocation(0,2,map),
                    new MapLocation(1,2,map),
                    new MapLocation(2,2,map),
                    new MapLocation(3,2,map),
                    new MapLocation(4,2,map),
                    new MapLocation(5,2,map),
                    new MapLocation(6,2,map),
                    new MapLocation(7,2,map)
                });

                Invader[] invaders =
                {
                    new Invader(path),
                    new Invader(path),
                    new Invader(path),
                    new Invader(path)
                };

                Tower[] towers =
                {
                    new Tower(new MapLocation(1,3,map)),
                    new Tower(new MapLocation(3,3, map)),
                    new Tower(new MapLocation(5,3,map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };
                bool playerWon = level.Play();
                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));
                

                MapLocation location = path.getLocationAt(0); // hasil eksekusi ini sma kaya MapLocation location = new MapLocation(2,0,map);
                //Console.WriteLine(location.X + "," + location.Y);


                //dibuat array dengan tipe MapLocation
               /* MapLocation[] path =
                {
                    new MapLocation(0,2,map),
                    new MapLocation(1,2,map),
                    new MapLocation(2,2,map),
                    new MapLocation(3,2,map),
                    new MapLocation(4,2,map),
                    new MapLocation(5,2,map),
                    new MapLocation(6,2,map),
                    new MapLocation(7,2,map),
                    

                };
                */
            }
            catch (OutOfBoundsException ex) //ketika ga ada di map
            {
                Console.WriteLine(ex.Message);
            }catch(MDException ex)
            {
                Console.WriteLine("Exception level 2 " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception level 3 " + ex.Message);
            }

           /*
            Point point = new Point(4, 2);
            bool isOnMap = map.onMap(point);
            Console.WriteLine(isOnMap);

            //nyoba hasil false
            //point = new Point(9, 10);
            //isOnMap = map.onMap(point);
            //Console.WriteLine(isOnMap);


            Console.WriteLine(point.distanceTo(4,3));

            //map location
            MapLocation point3= new MapLocation(8, 5, map);
            isOnMap = map.onMap(point3);
            Console.WriteLine(isOnMap);

            MapLocation point2 = new MapLocation(8, 5);
            Console.WriteLine(point.distanceTo(point2));
            Console.WriteLine("=====\n");

            // Coba deh, jawabnnya true or false
            Console.WriteLine("aa" is string);
            Console.WriteLine(point2 is Point); //false: krn point2 inheritance dari Maplocation
            Console.WriteLine(point2 is MapLocation);
            Console.WriteLine(point is MapLocation);
            */
        }
    }
}
