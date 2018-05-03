using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Risk_Project.Entities;
using Risk_Project.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Risk_Project.World_Objects
{
    public class Territory
    {
        #region Properties

        public enum State
        {
            Unoccupied,
            Occupied,
            Battle
        }
        public State Status;

        public string Name { get; set; }
        public Color Colour { get; set; }
        private Color defaultColor = new Color(200, 200, 200);
        public List<Unit> Armies { get; set; }   //List of temporary units currently in the boards territory 
        public List<Unit> DefaultArmies { get; set; }
        public Player Parent { get; set; }
        public Sprite Texture { get; set; }
        public Sprite TextureOutline { get; set; }

        #endregion

        #region Constructor

        public Territory(string name, List<Unit> armies, Texture2D texture, Texture2D textureOutline, Color outlineColor)
        {
            Name = name;
            Colour = defaultColor;
            Armies = armies;
            Texture = new Sprite(texture, new Vector2(0,0), 1);
            TextureOutline = new Sprite(textureOutline, new Vector2(0,0), 1);
            TextureOutline.Colour = outlineColor;
            Armies = armies;
            DefaultArmies = Armies;
        }

        #endregion

        #region Methods

        public void Update(GameTime gameTime)
        {
            Texture.Update(gameTime);
            TextureOutline.Update(gameTime);
            Texture.Colour = Colour;
            TextureOutline.Position = Texture.Position;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            TextureOutline.Draw(spriteBatch);
            Texture.Draw(spriteBatch);
            spriteBatch.DrawString(GameRoot.SystemFontBold, GetArmies().ToString(), Texture.CentrePosition, Color.Black);
        }
        
        //Display units in territory
        public int GetArmies()
        {
            int total = 0;

            foreach (Unit army in Armies)
            {
                total += army.Amount;
            }

            return total;
        }

        //Reset the territory 
        public void Reset()
        {
            Name = null;
            Colour = defaultColor;
            Armies.Clear();
            Parent = null;
        }

        //Set territory color
        public void UpdateColor()
        {
            if (Parent != null)
                try
                {
                    this.Colour = Parent.Colour;
                }
                catch (NullReferenceException)
                {
                    this.Colour = Color.Black;
                    Console.WriteLine("Parent to {0} is NULL !", Name);
                }
        }

        ////Can remove this
        ////Set the unit number to 1 if the territory is unnocupied
        //private void UnocupiedTerritory()
        //{
        //    State state = State.Unoccupied;

        //    if (Status.Equals(state))
        //    {

        //    }
        //}

        #endregion
    }
}
