using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SprintZero.Entity;
using SprintZero.GameLogicManager;
using MonoGameLibrary;
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
        private SpriteFont _font;
        private Vector2 _fontPosition;
        private GameManager _gameManager;
        private IController _gameController;
        private IEntitySystem player;

        private Texture2D playerTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            
            
            
        }

        protected override void Initialize()
        {
            _gameController = new KeyboardController();
            _gameManager = new GameManager(_gameController);




            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            playerTexture = Content.Load<Texture2D>("Player/ZeldaSpriteLinkFront");

            _font = Content.Load<SpriteFont>("Font/04B_30");
            
            //float fontYOrigin = _font.MeasureString(_credits).Y * 0.5f;
            float fontXOrigin = _font.MeasureString(_credits).X * 0.5f;
            _fontPosition = new Vector2(GraphicsDevice.Viewport.Width/2-fontXOrigin, GraphicsDevice.Viewport.Height - _font.MeasureString(_credits).Y);
            

        }

        protected override void Update(GameTime gameTime)
        {
            _gameController.Update();
            _gameManager.HandleInput();
            if (_gameManager.IsQuitting)
            {
                Exit();
            }
            else if (_gameManager.IsPaused)
            {
                
            }
            //Debug.WriteLine("Game Running");
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            _spriteBatch.Draw(playerTexture, new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2), Color.White);
          
            _spriteBatch.DrawString(
                _font,              // spriteFont
                _credits, // text
                _fontPosition, // position
                Color.White       // color
            );

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
