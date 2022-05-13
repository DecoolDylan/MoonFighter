using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MoonFighter
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //Choix de l'état lors du démarrage de l'application
        private GameState _gameState = GameState.MainMenu;

        // Concerne le menu
        private Texture2D background;
        private Texture2D logo;
        private Texture2D whiteRectangle;



        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

           
            //Screen Size
            _graphics.PreferredBackBufferWidth = GraphicsDevice.DisplayMode.Width;
            _graphics.PreferredBackBufferHeight = GraphicsDevice.DisplayMode.Height;
            _graphics.IsFullScreen = true;
            _graphics.ApplyChanges();
            // End

            whiteRectangle = new Texture2D(GraphicsDevice, 1, 1);
            whiteRectangle.SetData(new[] { Color.White });

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            //Concerne le menu de démarrage
            background = Content.Load<Texture2D>("background");
            logo = Content.Load<Texture2D>("logo");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {

            switch (_gameState)
            {
                case GameState.MainMenu:
                    
                    break;

                case GameState.ChoiceAvatar:
                 
                    break;

                case GameState.Gameplay:
      
                    break;

                case GameState.Score:

                    break;
                default:
                  
                    break;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            switch (_gameState)
            {
                case GameState.MainMenu:

                    _spriteBatch.Begin();
                    //Image de fond
                    _spriteBatch.Draw(background, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);

                    // rectangle blanc transparent
                    _spriteBatch.Draw(whiteRectangle, new Rectangle(((int)(this.Window.ClientBounds.Width * 0.7)) / 2, ((int)(this.Window.ClientBounds.Height * 0.2)) / 2, ((int)(this.Window.ClientBounds.Width * 0.3)), ((int)(this.Window.ClientBounds.Height * 0.8))), Color.White * 0.8f);

                    //logo
                    _spriteBatch.Draw(logo, new Rectangle(((int)(this.Window.ClientBounds.Width * 0.75)) / 2, ((int)(this.Window.ClientBounds.Height * 0.3)) / 2, ((int)(this.Window.ClientBounds.Width * 0.25)), ((int)(this.Window.ClientBounds.Height * 0.3))), Color.White);
                    _spriteBatch.End();
                    break;

                case GameState.ChoiceAvatar:

                    break;

                case GameState.Gameplay:

                    break;

                case GameState.Score:

                    break;
                default:

                    break;
            }


            
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
