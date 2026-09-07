using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace MonoGameLibrary.Sprite
{
    public struct TextureClip
    {
        private readonly List<TextureData> frames;
        public int Length
        {
            get=>frames.Count;
        }
        public TextureClip()
        {
            frames = new List<TextureData>();
        }
        public TextureData this[int i]
        {
            get => frames[i];
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
