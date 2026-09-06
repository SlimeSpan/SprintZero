using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameLibrary
{
    public interface ISprite
    {
        void Update(GameTime gameTime);
        void Draw(string actionName);
        void Draw(Texture2D texture,Vector2 targetPos, GameTime gameTime, Rectangle? sourceRectangle, Color color);

        void ResetFrame();
       
    }
}
