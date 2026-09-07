using System;
using Microsoft.Xna.Framework;
using MonoGameLibrary.Control;
using MonoGameLibrary.Sprite;
using MonoGameLibrary.player;
using MonoGameLibrary.Enums;
using MonoGameLibrary.Player;


namespace SprintZero.Entity
{
    
    internal class PlayerEntity : IEntitySystem
    {
        private readonly IPlayer player;
        
        public IAnimation animation
        {
            get;
            set;
        }
        public IPlayerController PlayerController
        {
            get;
            set;
        }
        public bool UpdateEnabled
        {
            get;
            set;
        } = true;
        public bool RenderEnabled
        {
            get;
            set;
        } = true;

        public PlayerEntity(IPlayer player, IPlayerController playerController, IAnimation animation)
        {
           
            this.player = player;
            PlayerController = playerController;
            this.animation = animation;
        }

      

        public void Update(GameTime gameTime)
        {
            if (!UpdateEnabled)
            {
                return;
            }
            animation.Update(gameTime);

            //some animation must wait, until one loop is completed,player can't do anything at
            //this point, state is locked.
            if (player.State == PlayerState.Attacking && !animation.HasPlayedOnce)
            {
                animation.IsPaused = false;

                return;
            }


            Vector2 moveDirection = PlayerController.Move();
            player.Move(moveDirection, gameTime);
            SetMoveDirection();
           

            bool isAttacking = PlayerController.Attack();            
            player.Attack(isAttacking);
            if (player.State == PlayerState.Attacking)
            {
                SetAttackDirection();
            }

            if (player.State == PlayerState.Idle)
            {
                animation.IsPaused = true;
            }
            else
            {
                animation.IsPaused = false;
            }



           
        }
        private void SetMoveDirection()
        {
            switch (player.Direction)
            {
                case Direction.Left:
                    animation.Play("MoveLeft");
                    break;
                case Direction.Right:
                    animation.Play("MoveRight");
                    break;
                case Direction.Up:
                    animation.Play("MoveUp");
                    break;
                case Direction.Down:
                    animation.Play("MoveDown");
                    break;
            }
        }
        private void SetAttackDirection()
        {
            switch (player.Direction)
            {
                case Direction.Left:
                    animation.Play("AttackLeft");
                    break;
                case Direction.Right:
                    animation.Play("AttackRight");
                    break;
                case Direction.Up:
                    animation.Play("AttackUp");
                    break;
                case Direction.Down:
                    animation.Play("AttackDown");
                    break;
            }
        }
        public void Draw(GameTime gameTime)
        {
            if (!RenderEnabled)
            {
                return;
            }
            animation.Draw(player.Position,Color.White);
            
        }

    }
}
