using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace SprintZero.Entity
{
    internal interface IEntitySystem
    {
       
        public void Update(GameTime gameTime);
        public void Draw(GameTime gameTime);
    }
}
