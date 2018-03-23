using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using MonoGame.Extended.Gui;
using Risk_Project.World_Objects;

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

        public int Turns;
        public int CurrentTurn;
        public List<Continent> Continents;
        private List<Continent> DefaultContinents;
        public Action CurrentAction;
        public Phase CurrentPhase;
        #endregion

        #region Constructor
        public Board(Game game) : base(game)
        {
            //GuiSkin currentSkin = new GuiSkin();
            //GuiScreen currentScreen = new GuiScreen(currentSkin);

            Init();
        }
        #endregion

        #region Methods
        public override void Draw(GameTime gameTime)
        {
            SpriteBatch spriteBatch = Game.Services.GetService<SpriteBatch>();

            foreach (var Continent in Continents)
            {
                foreach (var Territory in Continent.Territories)
                {
                    Territory.Draw(spriteBatch);
                }
            }
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var Continent in Continents)
            {
                foreach (var Territory in Continent.Territories)
                {
                    Territory.Update(gameTime);
                }
            }
        }

        public void Init()
        {
            Continents = new List<Continent>();

            CreateContinents();

        }

        private void CreateContinents()
        {
            // Create Continents
            Continent Europe = new Continent("Europe", Color.LightBlue);
            Continent Asia = new Continent("Asia", Color.Maroon);

            #region Create Territories
            List<Territory> EuropeTerritories = new List<Territory>()
            {
                new Territory("Ireland", CreateArmies(GameRoot.DEFAULT_ARMIES), GameRoot.TextureResource["t001"], Europe.OutlineColor)
            };

            List<Territory> AsiaTerritories = new List<Territory>()
            {
                new Territory("England", CreateArmies(GameRoot.DEFAULT_ARMIES), GameRoot.TextureResource["t002"], Asia.OutlineColor)
            };
            #endregion

            #region Edit Terrritory Textures
            EuropeTerritories[0].Texture.Position = new Vector2(220, 200);
            AsiaTerritories[0].Texture.Position = new Vector2(460, 200);
            #endregion

            #region Add Territories to Continents
            Europe.AddTerritories(EuropeTerritories);
            Asia.AddTerritories(AsiaTerritories);
            #endregion

            // Add to boards list of Continents
            Continents.Add(Europe);
            Continents.Add(Asia);

            // Store default Continents for Game Restart
            // This helps us revert back to the initial continent state
            // i.e. when the continents were first created
            DefaultContinents = Continents;
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

        }

        private void DistributePlayerTerritories()
        {

        }

        private void DistributeTerritoryUnits()
        {

        }

        public void SetPlayerOrder()
        {

        }

        public void SetMoveOrder()
        {

        }

        public void Commit()
        {

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
