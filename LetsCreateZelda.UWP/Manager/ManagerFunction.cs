﻿//------------------------------------------------------
// 
// Copyright - (c) - 2014 - Mille Boström 
//
// Youtube channel - http://www.speedcoding.net
//------------------------------------------------------

using System;
using Microsoft.Xna.Framework;

namespace LetsCreateZelda.UWP.Manager
{
    public static class ManagerFunction
    {
        private static readonly Random Rnd = new Random();

        public static int Random(int min, int max)
        {
            return Rnd.Next(min, max + 1); 
        }

        public static double Distance(Vector2 positionOne, Vector2 positionTwo)
        {
            var x = Math.Pow(positionOne.X - positionTwo.X,2);
            var y = Math.Pow(positionOne.Y - positionTwo.Y,2);
            return Math.Sqrt(x + y); 
        }
    }
}




