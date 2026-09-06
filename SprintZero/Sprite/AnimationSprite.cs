
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SprintZero.Sprite
{
    internal class AnimationSprite : ISprite
    {
        private readonly Texture2D _texture;
        private readonly SpriteBatch _spriteBatch;
        private int frameIndex;
        private float totalElapsed;
        private float frameTime;
        public AnimationSprite(Texture2D texture,SpriteBatch spriteBatch)
        {
            _texture = texture;
            _spriteBatch = spriteBatch;
        }



        public void Update(GameTime gameTime)
        {
            
        }


        public void Draw(Vector2 pos,GameTime gameTime,Rectangle? sourceRectangle, Color color)
        {
            _spriteBatch.Draw(_texture, pos, color);
        }

        public void ResetFrame()
        {
            frameIndex = 0;
        }
    }
}
