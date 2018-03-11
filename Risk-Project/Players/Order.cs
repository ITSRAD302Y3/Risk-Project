using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk_Project.Players
{
    class Order
    {
        #region Properties
        public enum Action
        {
            Deploy,
            Transfer
        }

        public string Name;
        public int Amount;
        public Action CurrentAction;
        public Territory Destination;
        #endregion

        #region Constructor
        public Order()
        {

        }
        #endregion
    }
}
