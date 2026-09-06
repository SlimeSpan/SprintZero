using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace MonoGameLibrary.Sprite
{
    public class TextureGroup
    {
        List<TextureRegion> frameGroup;
        public TextureGroup()
        {
            frameGroup = new List<TextureRegion>();
        }

        public TextureRegion GetFrame(int frameIndex)
        {
            return frameGroup[frameIndex];
        }

    }
}
