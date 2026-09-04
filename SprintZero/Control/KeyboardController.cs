using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace SprintZero.Control
{
    internal class KeyboardController : IController
    {
        private KeyboardState _keyState;
      

        /// <summary>
        /// Key bindings for movement and quitting the game, readonly for now.
        /// </summary>
        private readonly Keys _keyUp = Keys.W;
        private readonly Keys _keyDown = Keys.S;
        private readonly Keys _keyLeft = Keys.A;
        private readonly Keys _keyRight = Keys.D;
        private readonly Keys _keyQuit = Keys.Escape;
        private readonly Keys _keyPause = Keys.P;

        /// <summary>
        /// return a Vector2 representing the direction of movement based on the keys pressed
        /// </summary>
        /// <returns></returns>
        public Vector2 Move()
        {
            Vector2 direction = Vector2.Zero;

            if (_keyState.IsKeyDown(_keyUp))
            {
                direction.Y -= 1;
            }

            if (_keyState.IsKeyDown(_keyDown))
            {
                direction.Y += 1;
            }

            if (_keyState.IsKeyDown(_keyLeft))
            {
                direction.X -= 1;
            }

            if (_keyState.IsKeyDown(_keyRight))
            {
                direction.X += 1;
            }

            return direction;
        }

        public bool IsQuitGame()
        {
            if (_keyState.IsKeyDown(_keyQuit))
            {
                return true;
            }
            return false;
        }
        //following methods are pause and resume game methods,they are same
        //but the logic is different, IsPauseGame() will return true when the game is paused, IsResumeGame() will return true when the game is resumed
        public bool IsPauseGame()
        {
            if (_keyState.IsKeyDown(_keyPause))
            {
                return true;
            }
            return false;
        }
        public bool IsResumeGame()
        {
            if (_keyState.IsKeyDown(_keyPause))
            {
                return true;
            }
            return false;
        }

        public void Update()
        {
            _keyState =   Keyboard.GetState();
        }
    }
}
