using System;
using Microsoft.Xna.Framework;
using SprintZero.Control;
using SprintZero.Player;
using SprintZero.Render;
using SprintZero.Sprite;

namespace SprintZero.GameLogicManager
{
    
    internal class PlayerSystem: IGameSystem
    {
        private readonly IPlayer _player;
        private readonly IRender _renderer;
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

        public PlayerSystem(IPlayer player, IPlayerController playerController, IRender rendere)
        {
           
            this._player = player;
            this.PlayerController = playerController;
            this._renderer = rendere;
        }

        public void Update(GameTime gameTime)
        {
            if (UpdateEnabled)
            {
                Vector2 moveDirection = PlayerController.Move();
                _player.Move(moveDirection);
                _renderer.Update(gameTime);
            }
        }

        public void Draw(GameTime gameTime)
        {
            if (RenderEnabled)
            {
                _renderer.Draw(_player.Position, gameTime);
            }
        }

    }
}
