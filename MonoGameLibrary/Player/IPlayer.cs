using Microsoft.Xna.Framework;

namespace MonoGameLibrary
{
    public interface IPlayer
    {
        
        Vector2 Position { get; }
        void Move(Vector2 dir,GameTime gameTime);
    }
}
