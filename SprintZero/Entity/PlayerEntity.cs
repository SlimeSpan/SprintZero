using System;
using Microsoft.Xna.Framework;
using MonoGameLibrary;



namespace SprintZero.Entity
{
    
    internal class PlayerEntity : IEntitySystem
    {
        private readonly IPlayer player;
        private readonly ISprite sprite;
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

        public PlayerEntity(IPlayer player, IPlayerController playerController, ISprite sprite)
        {
           
            this.player = player;
            PlayerController = playerController;
            this.sprite = sprite;
        }

        private static class Direction
        {
            static string MoveLeft = "MoveLeft";
            static string MoveRight = "MoveRight";
            static string MoveDown = "MoveDown";
            static string MoveUp = "MoveUp";
        }

        public void Update(GameTime gameTime)
        {
            if (!UpdateEnabled)
            {
                return;
            }
            Vector2 moveDirection = PlayerController.Move();
            player.Move(moveDirection,gameTime);

            switch (moveDirection)
            {
                
            }

            if(moveDirection==Vector2.Zero)
            {

                sprite.ResetFrame();

            }
            else
            {

            }
          
        }

        public void Draw(GameTime gameTime)
        {
            if (!RenderEnabled)
            {
                return;
            }
            
            
        }

    }
}
