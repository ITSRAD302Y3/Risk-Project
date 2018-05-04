using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Risk_Project.Players;
using Risk_Project.Components;
using Risk_Project.World_Objects;
using InputManager;

namespace Risk_Project
{
    public class GameRoot : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private int _width = 1280;
        private int _height = 720;

        #region Properties

        public static Vector2 WorldBounds
        {
            get
            {
                return new Vector2(1920, 1080);
            }
        }
        public static Dictionary<string, Texture2D> TextureResource;
        public static Queue<Texture2D> BackgroundResource;
        public static List<Player> Players;
        private Camera currentCamera;
        private Board currentBoard;
        public static SpriteFont SystemFontBold;
        public static SpriteFont SystemFontLight;

        #endregion

        #region Default Properties

        public const int PLAYER_COUNT = 2;
        public const int DEFAULT_UNIT_AMOUNT = 1;
        public const int DEFAULT_ARMIES = 2;

        #endregion

        public GameRoot()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = _width;
            graphics.PreferredBackBufferHeight = _height;
            graphics.SynchronizeWithVerticalRetrace = true;
            graphics.IsFullScreen = false;
            graphics.ApplyChanges();

            IsMouseVisible = true;
            IsFixedTimeStep = false;

            Window.Title = "Systems Design - CA Assignment";
            Window.AllowAltF4 = false;
        }

        protected override void Initialize()
        {
            GameInit();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Services.AddService(spriteBatch);

            // Load Fonts
            SystemFontBold = Content.Load<SpriteFont>("Fonts\\systemBold");
            SystemFontLight = Content.Load<SpriteFont>("Fonts\\systemLight");

            // Load Texture Resources
            TextureResource = new Dictionary<string, Texture2D>();
            TextureResource = Loader.ContentLoad<Texture2D>(Content, "Textures\\Territories");

            // Load Background Resources
            BackgroundResource = new Queue<Texture2D>();
            BackgroundResource = Loader.ContentLoadQueue<Texture2D>(Content, "Backgrounds\\");

            CreateBoard();
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            currentBoard.Update(gameTime);
            currentBoard.UpdateAnimation(gameTime);

            if (currentCamera != null && InputEngine.IsMouseRightHeld())
                Camera.Follow((InputEngine.MousePosition + Camera.CamPos), Helper.GraphicsDevice.Viewport, currentCamera.CameraSpeed);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Transparent);

            spriteBatch.Begin(
                samplerState: SamplerState.LinearWrap, 
                blendState: BlendState.AlphaBlend, 
                transformMatrix: Camera.CurrentCameraTranslation);
            currentBoard.Draw(gameTime);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        #region Initialize

        private void GameInit()
        {
            // Set Window position to center screen
            Window.Position = new Point(
            (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) -
            (graphics.PreferredBackBufferWidth / 2),
            (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2) -
            (graphics.PreferredBackBufferHeight / 2));

            new InputEngine(this);
            Helper.GraphicsDevice = this.GraphicsDevice;
            InitCamera(this);

            InitPlayers();
            CreatePlayers();
        }

        private void InitCamera(Game game)
        {
            currentCamera = new Camera(game, Vector2.Zero, WorldBounds);
        }

        private void CreateBoard()
        {
            currentBoard = new Board(this);
        }

        #endregion

        #region Game Controls

        public static void GameRestart()
        {

        }

        #endregion

        #region Player Controls

        private void InitPlayers()
        {
            // Initialize players
            Players = new List<Player>();

            for (int i = 0; i < PLAYER_COUNT; i++)
            {
                Players.Add(new Player());
            }
        }

        private void CreatePlayers()
        {
            Players[0].Name = "Fearon";
            Players[0].Colour = Color.LimeGreen;

            Players[1].Name = "AI";
            Players[1].Colour = Color.Maroon;
        }

        private void CheckPlayerStates()
        {
            // Remove players if eliminated.
            // Game Over if current player is eliminated.
            // Win condition if current player conquered all continents.
        }

        #endregion
    }
}
