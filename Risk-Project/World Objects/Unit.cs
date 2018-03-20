using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk_Project.World_Objects
{
    public class Unit
    {
        public int Amount;

        public Unit()
        {
            try { this.Amount = GameRoot.DEFAULT_UNIT_AMOUNT; }
            catch (NullReferenceException) { this.Amount = 1; }
        }
        public Unit(int amount) // Overloading Method
        {
            this.Amount = amount;
        }
    }
}
