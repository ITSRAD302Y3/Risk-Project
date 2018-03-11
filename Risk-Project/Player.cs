using System;
using System.Collections.Generic;
using System.Collections;
using Microsoft.Xna.Framework;

public class Player
{
    public enum State
    {
        Idle,
        Playing,
        Eliminated,
        Winner
    }

    public State PlayerState { get; set; }

    public Player()
    {
        this.PlayerState = State.Idle;
    }

    public string Name { get; set; }
    public List<Unit> Armies { get; set; }

    public List<Territory> Territories { get; set; }
    
    private List<Order> Orders { get; set; }

    public Color Color { get; set; }

    public override string ToString()
    {
        return "Player: " + Name + "Units:   " + Armies + "Territories Owned: " + Territories ;
    }
    
    public void Surrender()
    {
        PlayerState = State.Eliminated;
    }

    public List<Order> GetOrders()
    {
        return Orders;
    }

    public void Reset()
    {
        Name = null;
        Armies = null;
        Territories = null;
    }

    public void ResetOrders()
    {
        Orders = null;
    }
    
}

public class Unit
{
    public int Amount { get; set; }
}

public class Territory
{
    public int Amount { get; set; }
}

public class PlayerAI: Player
{

}

public class Order 
{
    public enum Action
    {
        Deploy,
        Transfer
    }

    public int Amount { get; set; }

    public string Name { get; set; }

    public Action GetAction { get; set; }

    public Territory Destination { get; set; }

    public override string ToString()
    {
        return "Player: " + Name + "Units: " + Amount + "Destination: " + Destination;
    }
}