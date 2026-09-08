using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MonoGameLibrary.Control
{
    public class KeyboardMouseController : KeyboardController
    {
        private MouseState currentState;
        public override bool Attack()
        {

            return base.Attack()|| currentState.LeftButton == ButtonState.Pressed;
        }      
        public override void Update()
        {
            currentState = Mouse.GetState();
            base.Update();
        }
    }
}
