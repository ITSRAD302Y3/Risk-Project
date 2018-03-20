using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Sprites;
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
        //Three states of a territory
        public enum State
        {
            Unoccupied,
            Occupied,
            Battle
        }
        public State Status;

        //Properties
        public string Name { get; set; }

        public Color Colour { get; set; }
        private Color defaultColor = new Color(200, 200, 200);

        public List<Unit> Armies { get; set; }   //List of temporary units currently in the boards territory 

        public List<Unit> DefaultArmies { get; set; }

        public Player Parent { get; set; }

        public Sprite Texture { get; set; }

        //Constructor
        public Territory(string name, List<Unit> armies, Texture2D texture)
        {
            this.Name = name;
            this.Colour = defaultColor;
            this.Armies = armies;
            this.Texture = new Sprite(texture);
            this.Armies = armies;
            this.DefaultArmies = Armies;
        }

        //Methods
        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Texture.Draw(spriteBatch);
        }
        
        //Display units in territory
        public int GetArmies()
        {
            return Armies.Count();
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
        public void SetColor()
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
    }
}
