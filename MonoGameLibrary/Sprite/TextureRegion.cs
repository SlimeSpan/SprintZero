using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MonoGameLibrary.Sprite
{

    public class TextureRegion
    {
        public Texture2D Texture
        {
            get;
            set;
        }
        public Rectangle Rectangle
        {
            get;
            set;
        }
        
        
        public TextureRegion(Texture2D texture,int x,int y,int width,int height)
        {
            this.Texture = texture;
            Rectangle = new Rectangle(x, y, width, height);
        }
        public TextureRegion(Texture2D texture,Rectangle rectangle)
        {
            this.Texture = texture;
            this.Rectangle = rectangle;
        }
    }
}
