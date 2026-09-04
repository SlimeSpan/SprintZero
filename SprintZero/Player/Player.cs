using Microsoft.Xna.Framework;
using SprintZero.Sprite;
namespace SprintZero.Player
{
    internal class Player : IPlayer
    {
      
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
        public Player( Vector2 initPosition)
        {
            Position = initPosition;
        }

        public void Move(Vector2 dir)
        {
            Position += dir;

        }

     
    }
}
