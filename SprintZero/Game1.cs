
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary.Control;
using MonoGameLibrary.player;
using MonoGameLibrary.Sprite;

using SprintZero.Content.SpriteData;
using SprintZero.Entity;
using SprintZero.GameLogicManager;
using SprintZero.LoadCharacter;
namespace SprintZero
{
    public class Game1 : Game
    {
        private static readonly string _credits =
        "CREDITS\r\n" +
        "Program Made By: Alex Chen\r\n" +
        "Sprite From:https://www.spriters-resource.com/nes/legendofzelda/";


        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
       
        private SpriteFont font;
        
        private Vector2 fontPosition;
        private GameManager gameManager;
        
        private IEntitySystem playerEntity;
        private IController gameController;
        private IAnimation playerAnimation;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
         
           
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            
            
            
        }

        protected override void Initialize()
        {
            gameController = new KeyboardMouseController();
            gameManager = new GameManager(gameController);

            
           


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            Texture2D playerTexture = Content.Load<Texture2D>("Player/Link");
            
            //Used for show credit, no special use
            font = Content.Load<SpriteFont>("Font/Arial");
            float fontXOrigin = font.MeasureString(_credits).X * 0.5f;
            fontPosition = new Vector2(GraphicsDevice.Viewport.Width / 2 - fontXOrigin, GraphicsDevice.Viewport.Height - font.MeasureString(_credits).Y);





            playerAnimation = Link.LoadAnimation(playerTexture,new SpriteRenderer(_spriteBatch) , 3f, 0.1f);
            
            IPlayer playerStatus = new PlayerStatus(new Vector2(fontPosition.X, fontPosition.Y - 50), 200f);
            playerEntity = new PlayerEntity(playerStatus, gameController,playerAnimation);
        }
        
        protected override void Update(GameTime gameTime)
        {
            gameController.Update();
            gameManager.HandleInput();
           

            if (gameManager.IsQuitting)
            {
                Exit();
            }
            else if (gameManager.IsPaused)
            {
                //not implemented yet
            }


            playerEntity.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            playerEntity.Draw(gameTime);


            _spriteBatch.DrawString(font,_credits, fontPosition, Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
