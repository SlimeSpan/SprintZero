using Microsoft.Xna.Framework;

namespace SprintZero.Sprite
{
    internal interface ISprite
    {
        void Update(GameTime gameTime);
        void Draw(Vector2 pos, GameTime gameTime, Rectangle? sourceRectangle, Color color);

        void ResetFrame();
       
    }
}
