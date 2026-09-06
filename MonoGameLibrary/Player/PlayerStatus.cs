using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Xna.Framework;


namespace MonoGameLibrary
{
    public class PlayerStatus : IPlayer
    {


        public float Speed
        {
            get;
            set;
        } = 1f;
        public Vector2 Position
        {
            get;
            set;
        }
     
        /// <summary>
        /// Constructor for the Player class.
        /// </summary>
        /// <param name="sprite">The sprite representing the player.</param>
        /// <param name="initPosition">The initial position of the player.</param>
        public PlayerStatus(Vector2 initialPosition, float speed)
        {
            Position = initialPosition;
            this.Speed = speed;
        }

        public void Move(Vector2 dir,GameTime deltaTime)
        {
            Position += dir;
        }

        
    }
}
