
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameLibrary.Control;
using MonoGameLibrary.player;
using MonoGameLibrary.Sprite;

using SprintZero.Content.SpriteData;
using SprintZero.Entity;
using SprintZero.GameLogicManager;
namespace SprintZero
{
    public class Game1 : Game
    {
        private static readonly string _credits =
        "CREDITS\r\n" +
        "Program Made By: Alex Chen\r\n" +
        "Sprite From:";


        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
       
        private SpriteFont font;
        
        private Vector2 fontPosition;
        private GameManager gameManager;
        
        private IEntitySystem player;
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
            gameController = new KeyboardController();
            gameManager = new GameManager(gameController);

            
           


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            Texture2D playerTexture = Content.Load<Texture2D>("Player/Link");
                
            font = Content.Load<SpriteFont>("Font/04B_30");

            LoadLinkAnimation( playerTexture);

            float fontXOrigin = font.MeasureString(_credits).X * 0.5f;
            fontPosition = new Vector2(GraphicsDevice.Viewport.Width/2-fontXOrigin, GraphicsDevice.Viewport.Height - font.MeasureString(_credits).Y);
            
            player = new PlayerEntity(new PlayerStatus(new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2), 100f), gameController,playerAnimation);
        }
        private void LoadLinkAnimation(Texture2D texture2D)
        {
            TextureClip MoveDown = new TextureClip();
            TextureClip MoveRight = new TextureClip();
            TextureClip MoveUp = new TextureClip();
            TextureClip MoveLeft = new TextureClip();
            for (int i = 0; i < LinkSpriteData.MoveDown.Length; i++)
            {
                MoveDown.AddFrame(new TextureData(texture2D, LinkSpriteData.MoveDown[i],scale:2));
            }

          
            for (int i = 0; i < LinkSpriteData.MoveRight.Length; i++)
            {
                MoveRight.AddFrame(new TextureData(texture2D, LinkSpriteData.MoveRight[i],scale:2));
            }

            int moveLeftFrameCount = LinkSpriteData.MoveRight.Length;
            
            for (int i = 0; i < moveLeftFrameCount; i++)
            {
                MoveLeft.AddFrame(new TextureData(texture2D, LinkSpriteData.MoveRight[i], SpriteEffects.FlipHorizontally, scale:2));
            }
            
            for (int i = 0; i < LinkSpriteData.MoveUp.Length; i++)
            {
                MoveUp.AddFrame(new TextureData(texture2D, LinkSpriteData.MoveUp[i],scale:2));
            }
           

            Dictionary<string, TextureClip> animationClips = new Dictionary<string, TextureClip>
            {
               
                { "MoveDown",MoveDown },
                { "MoveRight",MoveRight },               
                { "MoveUp",MoveUp },
                { "MoveLeft",MoveLeft }
                //{ "Attack", new TextureClip(texture2D, 0, 32, 16, 16, 3) }
            };
            playerAnimation = new Animation(animationClips, new SpriteRenderer(_spriteBatch), 0.2f);
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
                   
            }
            //Debug.WriteLine("Game Running");
           
            player.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            player.Draw(gameTime);


            _spriteBatch.DrawString(
                font,              // spriteFont
                _credits, // text
                fontPosition, // position
                Color.White       // color
            );

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
