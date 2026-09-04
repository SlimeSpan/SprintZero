
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SprintZero.Sprite
{
    internal class PlayerSprite:ISprite
    {
        private readonly Texture2D _texture;
        private readonly SpriteBatch _spriteBatch;
        public PlayerSprite() { }



        public void Update(GameTime gameTime)
        {
            
        }


        public void Draw(Vector2 pos,GameTime gameTime,Color color)
        {
            _spriteBatch.Draw(_texture, pos, color);
        }

       
    }
}
