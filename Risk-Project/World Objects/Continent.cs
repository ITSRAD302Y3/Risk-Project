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
        public Continent()
        {

        }
        #endregion

        #region Methods
        private List<Territory> CreateTerritories()
        {
            return null;
        }

        public void Reset()
        {

        }
        #endregion
    }
}
