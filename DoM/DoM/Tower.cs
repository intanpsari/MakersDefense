using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class Tower
    {
        private readonly MapLocation _location;
        private const int _range = 1;
        private const int _power = 1;
        private static readonly Random _random = new Random();
        private const double _accuracy = 0.75;


        public Tower (MapLocation Location)
        {
            _location = Location;
        }
        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (var invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, 1))
                {
                    if(_random.NextDouble() < _accuracy)
                    {
                        invader.decreaseHealth(_power);
                        Console.WriteLine("invader shooted succesfully");

                        if (invader.IsNeutralized)
                            Console.WriteLine("invader neutralized");

                    }
                    else
                    {
                        Console.WriteLine("Shoot on invader missed");
                    }
                   // invader.decreaseHealth(1);
                    break;
                }
            }
        }
        public void FireToInvader(Invader[] invaders)
        {
            foreach(var satuInvader in invaders)
            {
                if (satuInvader.IsActive && _location.InRangeOf(satuInvader.Location, _range))
                {
                    satuInvader.decreaseHealth(1);
                    break;
                }
            }
        }
    }
}
