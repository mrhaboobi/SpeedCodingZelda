﻿using Microsoft.Xna.Framework.Graphics;

namespace LetsCreateZelda.UWP.Components.StatusEffects
{
    abstract class StatusEffectBase
    {
        public BaseObject BaseObject { get; private set; }

        protected StatusEffectBase(BaseObject baseObject)
        {
            BaseObject = baseObject;
        }

        public bool Done { get; set; }
        public abstract void Update(double gameTime);
        public abstract void Draw(SpriteBatch spriteBatch);

        public abstract void Stacking(); 

    }
}
