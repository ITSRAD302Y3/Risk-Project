using System.Collections.Generic;
using MonoGame.Extended;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Risk_Project.Players;
using Risk_Project.Components;

namespace Risk_Project
{
    public class GameRoot : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        #region Properties
        public static List<Player> players = new List<Player>();
        private Camera2D currentCamera;
        private Board currentBoard;
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
            CreatePlayers();
            CreateBoard();
        }

        public static void GameRestart()
        {

        }

        private void CreateBoard()
        {
            currentBoard = new Board();
        }

        private void CreatePlayers()
        {
            Player one = new Player("David Brennan", Color.LightBlue);
            PlayerAI two = new PlayerAI("AI", Color.DarkRed);

            // Add these players to our list
            players.Add(one);
            players.Add(two);
        }

        private void CheckPlayerStates()
        {

        }
        #endregion
    }
}
