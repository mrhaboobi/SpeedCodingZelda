﻿//------------------------------------------------------
// 
// Copyright - (c) - 2014 - Mille Boström 
//
// Youtube channel - http://www.speedcoding.net
//------------------------------------------------------

using LetsCreateZelda.UWP.Manager;
using LetsCreateZelda.UWP.Map;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LetsCreateZelda.UWP.Components
{
    public class Collision : Component
    {

        private ManagerMap _managerMap;
        private Entities _entities;

        public Collision(ManagerMap managerMap, Entities entities)
        {
            _managerMap = managerMap;
            _entities = entities;
        }

        public bool CheckCollisionWithTiles(Rectangle rectangle, bool fixBox = true)
        {
            rectangle = new Rectangle((int) (rectangle.X + (rectangle.Width*0.4)/2),(int) (rectangle.Y + rectangle.Height*0.5),(int) (rectangle.Width*0.6),(int) (rectangle.Height*0.5));
            return _managerMap.CheckCollision(rectangle, GetOwnerId()); 
        }

        public bool CheckCollisionWithEntities(Rectangle rectangle, bool fixBox = true)
        {
            rectangle = new Rectangle((int)(rectangle.X + (rectangle.Width * 0.4) / 2), (int)(rectangle.Y + rectangle.Height * 0.5), (int)(rectangle.Width * 0.6), (int)(rectangle.Height * 0.5));
            return _entities.CheckCollision(rectangle, GetOwnerId()); 
        }

        public override void Update(double gameTime)
        {
           
        }

        public override void Draw(SpriteBatch spritebatch)
        {
           
        }
    }
}



