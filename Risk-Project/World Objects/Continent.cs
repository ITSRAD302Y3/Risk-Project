using Microsoft.Xna.Framework;
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
        #endregion

        #region Constructor
        public Continent(string name, Color color)
        {
            this.Name = name;
            this.OutlineColor = color;
            this.Territories = new List<Territory>();
        }
        #endregion

        #region Methods

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
