//using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace SprintZero.Control
{
    internal interface IGameController
    {
        bool IsQuitGame();
        bool IsPauseGame();

        bool IsResumeGame();
    }
}
