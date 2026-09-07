using Microsoft.Xna.Framework;

namespace MonoGameLibrary.Control
{
    public interface IPlayerController
    {
        Vector2 Move();
        bool Attack();
    }
}
