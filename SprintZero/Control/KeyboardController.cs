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
        private KeyboardState previousKeyState;
        private KeyboardState currentKeyState;
      

      
        private readonly Keys _keyUp = Keys.W;
        private readonly Keys _keyDown = Keys.S;
        private readonly Keys _keyLeft = Keys.A;
        private readonly Keys _keyRight = Keys.D;

        private readonly Keys _keyQuit = Keys.Escape;
        private readonly Keys _keyPause = Keys.P;
        private readonly Keys keyAttack = Keys.K;

        /// <summary>
        /// return a Vector2 representing the direction of movement based on the keys pressed
        /// </summary>
        /// <returns></returns>
        public Vector2 Move()
        {
            Vector2 direction = Vector2.Zero;

            if (currentKeyState.IsKeyDown(_keyUp))
            {
                direction.Y -= 1;
            }

            if (currentKeyState.IsKeyDown(_keyDown))
            {
                direction.Y += 1;
            }

            if (currentKeyState.IsKeyDown(_keyLeft))
            {
                direction.X -= 1;
            }

            if (currentKeyState.IsKeyDown(_keyRight))
            {
                direction.X += 1;
            }

            return direction;
        }

        public bool IsQuitGame()
        {
            
                return currentKeyState.IsKeyDown(_keyQuit);
            
        }
        //following methods are pause and resume game methods,they are same
        //but the logic is different, IsPauseGame() will return true when the game is paused, IsResumeGame() will return true when the game is resumed
        
       
      

        public void Update()
        {
            previousKeyState = currentKeyState;
            currentKeyState =   Keyboard.GetState();
        }

        public bool IsPausePressed()
        {

            return currentKeyState.IsKeyDown(_keyPause)&&!previousKeyState.IsKeyDown(_keyPause);
            
        }

        public bool Attack()
        {
            return currentKeyState.IsKeyDown(keyAttack);
        }
    }
}
