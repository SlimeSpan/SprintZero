using Microsoft.Xna.Framework;

namespace MonoGameLibrary
{
    public interface IPlayerController
    {
        Vector2 Move();
        bool Attack();
    }
}
