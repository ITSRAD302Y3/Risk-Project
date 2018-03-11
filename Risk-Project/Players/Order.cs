using Risk_Project.World_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk_Project.Players
{
    public class Order
    {
        #region Properties
        public enum Action
        {
            Deploy,
            Transfer
        }

        public string Name { get; set; }
        public int Amount { get; set; }
        public Action CurrentAction;
        public Territory Destination { get; set; }
        #endregion

        #region Constructor
        public Order()
        {

        }
        #endregion
    }
}
