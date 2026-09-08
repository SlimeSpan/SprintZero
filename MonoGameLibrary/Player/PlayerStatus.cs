using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Xna.Framework;
using MonoGameLibrary.Enums;
using MonoGameLibrary.Player;


namespace MonoGameLibrary.player
{
    public class PlayerStatus : IPlayer
    {

        public Direction Direction
        {
            get;
            private set;
        } = Direction.Right; //default direction is right

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

        public PlayerState State
        {
            get;
            private set;
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
            Position += dir*Speed*(float)deltaTime.ElapsedGameTime.TotalSeconds;

            if(dir == Vector2.Zero)
            {
                State = PlayerState.Idle;
                return;
            }
               

            if (dir.X > 0)
            {
                Direction = Direction.Right;
            }
            else if (dir.X < 0)
            {
                Direction = Direction.Left;
            }
            else if (dir.Y > 0)
            {
                Direction = Direction.Down;
            }
            else if (dir.Y < 0)
            {
                Direction = Direction.Up;
               
            }
            State = PlayerState.Moving;
        }
        public void Attack(bool isAttacking)
        {
            if (isAttacking)
            {
                State = PlayerState.Attacking;
            }
          
        }
        
    }
}
