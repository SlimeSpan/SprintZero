using System;
using Microsoft.Xna.Framework;
using SprintZero.Player;
using SprintZero.Sprite;
namespace SprintZero.Render
{
    internal class PlayerRender:IRender
    {
        private ISprite playerSprite;
        public PlayerRender(ISprite playerSprite)
        {
            if (playerSprite is null)
            {
                throw new ArgumentNullException(nameof(playerSprite), "Player sprite cannot be null.");
            }

            this.playerSprite = playerSprite;
        }
        public void Update(GameTime gameTime)
        {
            playerSprite.Update(gameTime);
        }
        public void Draw(Vector2 pos, GameTime gameTime)
        {
            
            playerSprite.Draw(pos,gameTime,Color.White);
        }
    }
}
