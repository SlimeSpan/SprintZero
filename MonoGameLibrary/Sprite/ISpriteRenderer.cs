using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameLibrary.Sprite
{
    public interface ISpriteRenderer
    {

        public void Draw(Texture2D texture, Vector2 targetPos, Rectangle? sourceRectangle, Color color, Vector2 origin=default, float rotation = 0, float scale = 1.0f, SpriteEffects spriteEffect = SpriteEffects.None, float layerDepth = 0f);

    }
}
