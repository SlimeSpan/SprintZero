using Microsoft.Xna.Framework;
using MonoGameLibrary.Enums;
using MonoGameLibrary.Player;

namespace MonoGameLibrary.player
{ 
    public interface IPlayer
    {
        PlayerState State
        {
            get;

        }

        Direction Direction
        {
            get;
        }
        Vector2 Position { get; }
        void Move(Vector2 dir,GameTime gameTime);

        void Attack(bool isAttacking);
    }
}
