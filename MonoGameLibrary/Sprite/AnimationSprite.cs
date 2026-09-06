
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameLibrary.Sprite;

namespace MonoGameLibrary
{
    public class AnimationSprite : ISprite
    {


        private Dictionary<string, TextureGroup> animations;
        private readonly SpriteBatch spriteBatch;
        private int frameIndex;
        private float totalElapsed;
        private float frameTime;
 
        public AnimationSprite(Texture2D texture,SpriteBatch spriteBatch,Dictionary<string,TextureGroup> spriteGroups)
        {         
            this.spriteBatch = spriteBatch;
        }



        public void Update(GameTime gameTime)
        {
            
        }

        public void Draw(string ActionName)
        {
            
        }

        public void Draw(Vector2 targetPos,GameTime gameTime,Rectangle? sourceRectangle, Color color)
        {
                
        }

        public void ResetFrame()
        {
            frameIndex = 0;
        }

        public void Draw(Texture2D texture, Vector2 targetPos, GameTime gameTime, Rectangle? sourceRectangle, Color color)
        {
            throw new System.NotImplementedException();
        }
    }
}
