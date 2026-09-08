using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace MonoGameLibrary.Sprite
{
    public class TextureClip
    {
        private readonly List<TextureData> frames;
        public int Length
        {
            get => frames.Count;
        }
        public TextureData this[int i]
        {
            get => frames[i];
        }
        
        public TextureClip()
        {
            frames = new List<TextureData>();
        }
        public TextureClip(params TextureData[] data)
        {
            frames = new List<TextureData>();
            foreach (var item in data)
            {
                frames.Add(item);
            }
        }

        public static TextureClip CreateClip(Texture2D texture2D, Rectangle[] frames, SpriteEffects spriteEffects = SpriteEffects.None, float scale = 1f)
        {
            TextureClip clip = new TextureClip();
            for(int i = 0; i < frames.Length; i++)
            {
                clip.AddFrame(new TextureData(texture2D, frames[i], spriteEffects, scale));
            }
           
            return clip;
        }
        public static TextureClip CreateClip(TextureData[] frames)
        {
            TextureClip clip = new TextureClip();
            for (int i = 0; i < frames.Length; i++)
            {
                clip.AddFrame(frames[i]);
            }

            return clip;
        }
        public TextureData GetFrame(int frameIndex)
        {
            return frames[frameIndex];
        }
        public void AddFrame(TextureData textureRegion)
        {
            frames.Add(textureRegion);
        }
        
    }
}
