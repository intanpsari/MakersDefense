﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class Level
    {
        private readonly Invader[] _invaders;
        public Tower[] Towers { get; set; }

        public Level (Invader[] invaders)
        {
            _invaders = invaders;
        }

        public bool Play()
        {
            //looping sampai invader mati atau invader menang
            int remainingInvaders = _invaders.Length;

            //tower cek jarak dengan invader
            while (remainingInvaders > 0)
            {
                foreach(Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                //kalau masih ada invader, invader maju
                remainingInvaders = 0;
                foreach(Invader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();
                        if (invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;
                    }
                }
            }

            return true;
            

            
        }
    }
}
