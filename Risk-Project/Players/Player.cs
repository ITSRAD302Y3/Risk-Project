using System;
using System.Collections.Generic;
using System.Collections;
using Microsoft.Xna.Framework;
using Risk_Project.World_Objects;

namespace Risk_Project.Players
{
    public class Player
    {
        #region Properties

        public enum State
        {
            Idle,
            Playing,
            Eliminated,
            Winner
        }

        public State PlayerState { get; set; }
        public string Name { get; set; }
        public List<Unit> Armies { get; set; }
        public List<Territory> Territories { get; set; }
        private List<Order> Orders { get; set; }
        public Color Colour { get; set; }

        #endregion

        #region Constructor

        public Player()
        {
            this.PlayerState = State.Idle;

        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return ("Player: " + Name 
                + "Units: " + Armies.Count.ToString() 
                + "Territories Owned: " + Territories.Count.ToString());
        }

        public void Surrender()
        {
            PlayerState = State.Eliminated;
        }

        public List<Order> GetOrders()
        {
            return this.Orders;
        }

        public void Reset()
        {
            Name = null;
            Armies = null;
            Territories = null;
            PlayerState = State.Idle;
        }

        public void ResetOrders()
        {
            this.Orders.Clear();
        }

        #endregion
    }
}