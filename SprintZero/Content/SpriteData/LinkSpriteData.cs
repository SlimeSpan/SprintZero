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

        internal static readonly Rectangle[] AttackDown = new Rectangle[]
        {
            new Rectangle(90, 46, 18, 17),
            new Rectangle(108,46,18,29),
            new Rectangle(127,46,17,25),
            new Rectangle(145,46,15,21)
        };
        internal static readonly Rectangle[] AttackRight = new Rectangle[]
        {
            new Rectangle(94,77,16,17),
            new Rectangle(110, 77, 28, 17),
            new Rectangle(139, 77, 24, 17),
            new Rectangle(163, 77, 20, 18)
        };

        internal static readonly Rectangle[] AttackUp = new Rectangle[]
        {
            new Rectangle(94,109,16,16),
            new Rectangle(111, 97, 16, 28),
            new Rectangle(129, 97, 14, 28),
            new Rectangle(146, 105, 14, 21),
        };
    }
}
