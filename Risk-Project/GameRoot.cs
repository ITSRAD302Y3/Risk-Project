﻿using System.Collections.Generic;
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
        public static Dictionary<string, Texture2D> TextureResource = new Dictionary<string, Texture2D>();
        private List<Player> players;
        private Camera2D currentCamera;
        private Board currentBoard;
        #endregion

        #region Default Properties
        const int PLAYER_COUNT = 2;

        #endregion

        public GameRoot()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {

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
            // Initialize players
            for (int i = 0; i < PLAYER_COUNT; i++)
            {
                players.Add(new Player());
            }

            CreatePlayers();
            CreateBoard();
        }

        private void CreatePlayers()
        {
            players[0].Name = "Fearon";
            players[0].Colour = Color.Blue;

            players[1].Name = "AI";
            players[1].Colour = Color.Red;
        }

        public static void GameRestart()
        {

        }

        private void CheckPlayerStates()
        {

        }

        private void CreateBoard()
        {
            currentBoard = new Board();
        }
        #endregion
    }
}
