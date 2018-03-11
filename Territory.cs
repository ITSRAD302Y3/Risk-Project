using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Software_Assignment_One
{
    class Territory : Player //Inherits from the player
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
        private string Name { get; set; }

        public ConsoleColor Color { get; set; }

        private List<Unit> Armies { get; set; }   //List of the players units currently in the territory 


        //Methods
        //Display units in territory
        private int GetArmies()
        {
            return Armies.Count();
        }

        //Reset the territory 
        private void Reset()
        {
            this.Reset();
        }

        //Can remove this
        //Set the unit number to 1 if the territory is unnocupied
        private void UnocupiedTerritory()
        {
            State state = State.Unoccupied;

            if (Status.Equals(state))
            {

            }
        }

    }
}
