using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;


namespace SprintZero.Render
{
    internal interface IRender
    {
        void Update(GameTime gameTime);
        void Draw(Vector2 pos,GameTime gameTime);
    }
}
