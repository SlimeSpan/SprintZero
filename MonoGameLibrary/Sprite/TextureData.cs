using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MonoGameLibrary.Sprite
{

    public struct TextureData
    {
        public Texture2D Texture
        {
            get;
            private set;
        }
        public Rectangle Rectangle
        {
            get;
            private set;
        }
        public SpriteEffects Effect
        {
            get;
            set;
        } 
       
        public float Scale
        {
            get;
            set;
        } 
       
        public TextureData(Texture2D texture,int x,int y,int width,int height, SpriteEffects effect = SpriteEffects.None,float scale = 1.0f)
        {
            this.Texture = texture;
            Rectangle = new Rectangle(x, y, width, height);
            this.Effect = effect;
            this.Scale = scale;
        }
        public TextureData(Texture2D texture,Rectangle rectangle, SpriteEffects effect = SpriteEffects.None, float scale = 1.0f)
        {
            this.Texture = texture;
            this.Rectangle = rectangle;
            this.Effect = effect;
            this.Scale = scale;
        }
    }
}
