using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk_Project.World_Objects
{
    public class Continent
    {
        #region Properties

        public string Name;
        public Color OutlineColor;
        public List<Territory> Territories;
        public int ArmiesPerTurn;

        #endregion

        #region Constructor

        public Continent(string name, Color color, int armiesPerTurn)
        {
            this.Name = name;
            this.OutlineColor = color;
            this.Territories = new List<Territory>();
            this.ArmiesPerTurn = armiesPerTurn;
        }

        #endregion

        #region Methods

        public void Update(GameTime gameTime)
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }

        public void AddTerritories(List<Territory> territories)
        {
            this.Territories.AddRange(territories);
        }

        public void Reset()
        {

        }

        #endregion
    }
}
