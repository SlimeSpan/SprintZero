using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MonoGameLibrary.Control
{
    public class KeyboardController : IController
    {
        private KeyboardState previousKeyState;
        private KeyboardState currentKeyState;
      

      
        private readonly Keys keyUp = Keys.W;
        private readonly Keys keyDown = Keys.S;
        private readonly Keys keyLeft = Keys.A;
        private readonly Keys keyRight = Keys.D;

        private readonly Keys keyQuit = Keys.Escape;
        private readonly Keys keyPause = Keys.P;
        private readonly Keys keyAttack = Keys.K;

        /// <summary>
        /// return a Vector2 representing the direction of movement based on the keys pressed
        /// </summary>
        /// <returns></returns>
        public Vector2 Move()
        {
            Vector2 direction = Vector2.Zero;

            if (currentKeyState.IsKeyDown(keyUp))
            {
                direction.Y -= 1;
            }

            if (currentKeyState.IsKeyDown(keyDown))
            {
                direction.Y += 1;
            }

            if (currentKeyState.IsKeyDown(keyLeft))
            {
                direction.X -= 1;
            }

            if (currentKeyState.IsKeyDown(keyRight))
            {
                direction.X += 1;
            }

            return direction;
        }

        public bool IsQuitGame()
        {
            
                return currentKeyState.IsKeyDown(keyQuit);
            
        }
        //following methods are pause and resume game methods,they are same
        //but the logic is different, IsPauseGame() will return true when the game is paused, IsResumeGame() will return true when the game is resumed
        
       
      

        public virtual void Update()
        {
            previousKeyState = currentKeyState;
            currentKeyState =   Keyboard.GetState();
        }

        public bool IsPausePressed()
        {

            return currentKeyState.IsKeyDown(keyPause)&&!previousKeyState.IsKeyDown(keyPause);
            
        }

        public virtual bool Attack()
        {
            return currentKeyState.IsKeyDown(keyAttack);
        }
    }
}
