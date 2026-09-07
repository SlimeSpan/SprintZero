using Microsoft.Xna.Framework;

namespace SprintZero.Content.SpriteData
{
    internal static class LinkSpriteData
    {
        internal static readonly Rectangle[] MoveDown = new Rectangle[]
        {
            new Rectangle(1, 10, 17, 18),
            new Rectangle(18, 10, 15, 18)
        };
        internal static readonly Rectangle[] MoveRight = new Rectangle[]
        {
            new Rectangle(33, 10, 18, 18),
            new Rectangle(51, 11, 16, 17)
        };
      
        internal static readonly Rectangle[] MoveUp= new Rectangle[]
        {
            new Rectangle(69, 10, 18, 19),
            new Rectangle(85, 10, 18, 19)
        };
       
    }
}
