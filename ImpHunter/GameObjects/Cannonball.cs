using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ImpHunter.GameObjects
{
    class Cannonball : GameObjectList { 
        GameObjectList cannonballs;
    
        public Cannonball()
        {
            Add(cannonballs = new GameObjectList());
            SpriteGameObject cannonball = new SpriteGameObject("spr_cannon_ball");
        }            
    }
}
