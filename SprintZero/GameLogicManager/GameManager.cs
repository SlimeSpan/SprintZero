using MonoGameLibrary;
using Microsoft.Xna.Framework;
using System.Diagnostics;
using MonoGameLibrary.Control;

namespace SprintZero.GameLogicManager
{
    internal class GameManager
    {
       

        public bool IsPaused { get; private set; }
        public bool IsQuitting { get; private set; }
        public IGameController gameController;
        public GameManager(IGameController gameController)
        {
            this.gameController = gameController;
            IsPaused = false;   
            IsQuitting = false;
        }
        public void HandleInput()
        {
            if (gameController.IsQuitGame())
            {
                IsQuitting = true;
            }
            else if (gameController.IsPausePressed())
            {
                IsPaused = !IsPaused;
                Debug.WriteLine($"Paused:{IsPaused}");
            }
          
        }

       
    }
}
