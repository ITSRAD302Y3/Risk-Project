using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Risk_Project.World_Objects;
using Risk_Project.Players;
using Risk_Project.Entities;

namespace Risk_Project.Components
{
    public class Board : DrawableGameComponent
    {
        #region Properties

        public enum Action
        {
            Inspect,
            Deploy,
            Transfer,
            Wait
        }

        public enum Phase
        {
            Add,
            Move,
            Battle,
            Wait
        }

        public int Turn;
        public List<Continent> Continents;
        private List<Continent> DefaultContinents;
        public Action CurrentAction;
        public Phase CurrentPhase;

        private Texture2D background;

        #endregion

        #region Continent Variables

        private Continent Europe;
        private Continent Asia;

        #endregion

        #region Territory Variables

        private List<Territory> EuropeTerritories;
        private List<Territory> AsiaTerritories;

        #endregion

        #region Constructor

        public Board(Game game) : base(game)
        {
            Init();
        }

        #endregion

        #region Methods

        public override void Update(GameTime gameTime)
        {
            // Update Territories
            foreach (var Continent in Continents)
            {
                foreach (var Territory in Continent.Territories)
                {
                    Territory.Update(gameTime);
                }
            }
        }

        public override void Draw(GameTime gameTime)
        {
            SpriteBatch spriteBatch = Game.Services.GetService<SpriteBatch>();

            // Draw Background
            spriteBatch.Draw(background, new Rectangle(Point.Zero, Camera.WorldBound.ToPoint()), Color.White);

            // Draw Territories
            foreach (var Continent in Continents)
            {
                foreach (var Territory in Continent.Territories)
                {
                    Territory.Draw(spriteBatch);
                }
            }
        }

        private void Init()
        {
            background = GameRoot.BackgroundResource["background"];

            Continents = new List<Continent>();

            CreateContinents();
            CreateTerritories();
            SetTerritoryPositions();
            AddTerritoriesToContinents();
            DistributePlayers();
        }

        private void CreateContinents()
        {
            // Create Continents
            Europe = new Continent("Europe", Color.CornflowerBlue, 5);
            Asia = new Continent("Asia", Color.Orange, 2);
            // Add to boards list of Continents
            Continents.Add(Europe);
            Continents.Add(Asia);

            // Store default Continents for Game Restart
            // This helps us revert back to the initial continent state
            // i.e. when the continents are first created
            DefaultContinents = Continents;
        }

        private void CreateTerritories()
        {
            EuropeTerritories = new List<Territory>()
            {
                new Territory("Ireland", CreateArmies(GameRoot.DEFAULT_ARMIES),
                GameRoot.TextureResource["t001"],
                GameRoot.TextureResource["t001o"],
                Europe.OutlineColor)
            };

            AsiaTerritories = new List<Territory>()
            {
                new Territory("England", CreateArmies(GameRoot.DEFAULT_ARMIES),
                GameRoot.TextureResource["t002"],
                GameRoot.TextureResource["t002o"],
                Asia.OutlineColor)
            };
        }

        private void SetTerritoryPositions()
        {
            EuropeTerritories[0].Texture.Position = new Vector2(300, 400);
            AsiaTerritories[0].Texture.Position = new Vector2(460, 200);
        }

        private void AddTerritoriesToContinents()
        {
            Europe.AddTerritories(EuropeTerritories);
            Asia.AddTerritories(AsiaTerritories);
        }

        private List<Unit> CreateArmies(int amount)
        {
            List<Unit> tempUnits = new List<Unit>();

            for (int i = 0; i < amount; i++)
            {
                tempUnits.Add(new Unit());
            }

            return tempUnits;
        }

        private void DistributePlayers()
        {
            foreach (Territory territory in Continents[0].Territories)
            {
                territory.Parent = GameRoot.Players[0];
                territory.UpdateColor();
            }

            foreach (Territory territory in Continents[1].Territories)
            {
                territory.Parent = GameRoot.Players[1];
                territory.UpdateColor();
            }
        }

        private void DistributeTerritoryUnits()
        {
            // Add units to players armies.

            foreach (Player player in GameRoot.Players)
            {
                //player.Armies.Add()
            }
        }

        private void SetMoveOrder()
        {

        }

        public void Commit()
        {
            // When commit button is clicked, start movements, transfers and battles.
        }

        private void Battle()
        {

        }

        public void ResetBoard()
        {

        }

        #endregion
    }
}
