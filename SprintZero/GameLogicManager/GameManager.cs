using SprintZero.Control;
using Microsoft.Xna.Framework;
using System.Diagnostics;

namespace SprintZero.GameLogicManager
{
    internal class GameManager
    {
        public bool IsPaused { get; private set; }
        public bool IsQuitting { get; private set; }
        public IGameController _gameController;
        public GameManager(IGameController gameController)
        {
            _gameController = gameController;
            IsPaused = false;
            IsQuitting = false;
        }
        public void HandleInput()
        {
            if (_gameController.IsQuitGame())
            {
                IsQuitting = true;
            }
            else if (_gameController.IsPausePressed())
            {
                if(IsPaused)
                {
                    IsPaused = false;
                    Debug.WriteLine("Unpaused");
                }
                else
                {
                    IsPaused=true;
                    Debug.WriteLine("Paused");
                }
            }
          
        }

       
    }
}
