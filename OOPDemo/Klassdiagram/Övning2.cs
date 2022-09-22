using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Klassdiagram
{
    class GameObject
    {
        public bool IsDead;
        public Vector2 position;
        public float Radius;
        public float rotation;

        public bool CollidesWith(Meteor other)
        {

        }
    }

    class Meteor : GameObject
    {
        public float Type;
        public float ExplosionScale;

        public Meter(Type : MeteorType)
        public Update(gameTime : GameTime)
    }
}
