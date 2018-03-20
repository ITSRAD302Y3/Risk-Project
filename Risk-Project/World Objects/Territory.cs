using Microsoft.Xna.Framework;
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

        public List<Unit> Armies { get; set; }   //List of the players units currently in the territory 

        public List<Unit> DefaultArmies { get; set; }

        public Player Parent { get; set; }

        //Constructor
        public Territory()
        {

        }

        //Methods
        //Display units in territory
        public int GetArmies()
        {
            return Armies.Count();
        }

        public List<Unit> SetDefaultArmies()
        {

        }

        //Reset the territory 
        public void Reset()
        {
            Name = null;
            Colour = Color.Transparent;
            Armies.Clear();
            Parent = null;
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
