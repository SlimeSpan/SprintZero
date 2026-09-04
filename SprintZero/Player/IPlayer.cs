using Microsoft.Xna.Framework;

namespace SprintZero.Player
{
    internal interface IPlayer
    {
        Vector2 Position { get; }
        void Move(Vector2 dir);
    }
}
