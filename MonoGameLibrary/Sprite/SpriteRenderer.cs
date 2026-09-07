using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameLibrary.Sprite
{
    public class SpriteRenderer : ISpriteRenderer
    {
      
        SpriteBatch spriteBatch;
        public SpriteRenderer(SpriteBatch spriteBatch)
        {
            this.spriteBatch = spriteBatch;
        }
     

        public void Draw(Texture2D texture, Vector2 targetPos, Rectangle? sourceRectangle, Color color, Vector2 origin = default, float rotation = 0, float scale = 1, SpriteEffects spriteEffect = SpriteEffects.None, float layerDepth = 0)
        {
            spriteBatch.Draw(texture, targetPos, sourceRectangle, color, rotation, origin, scale, spriteEffect, layerDepth);
  
        }
    }
}
