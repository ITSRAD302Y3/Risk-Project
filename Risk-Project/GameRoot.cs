using System.Collections.Generic;
using MonoGame.Extended;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Risk_Project.Players;
using Risk_Project.Components;
using Risk_Project.World_Objects;
using Loader;

namespace Risk_Project
{
    public class GameRoot : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        #region Properties
        public static Dictionary<string, Texture2D> 
            TextureResource = new Dictionary<string, Texture2D>();
        private List<Player> players;
        private Camera2D currentCamera;
        private Board currentBoard;
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
        }

        protected override void Initialize()
        {
            GameInit();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load Texture Resources
            ContentLoader.ContentLoad<Texture2D>(Content, "Textures");

            CreateBoard();
        }


        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();



            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);



            base.Draw(gameTime);
        }

        #region Methods
        private void GameInit()
        {
            currentCamera = new Camera2D(GraphicsDevice);

            // Initialize players
            players = new List<Player>();

            for (int i = 0; i < PLAYER_COUNT; i++)
            {
                players.Add(new Player());
            }

            CreatePlayers();
        }

        public static void GameRestart()
        {

        }

        private void CreatePlayers()
        {
            players[0].Name = "Fearon";
            players[0].Colour = Color.Blue;

            players[1].Name = "AI";
            players[1].Colour = Color.Red;
        }

        private void CheckPlayerStates()
        {
            // Remove players if eliminated.
            // Game Over if current player is eliminated.
            // Win condition if current player conquered all continents.
        }

        private void CreateBoard()
        {
            currentBoard = new Board();
        }
        #endregion
    }
}
