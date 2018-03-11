using System;
using System.Collections.Generic;
using System.Collections;
using Microsoft.Xna.Framework;

public class Player
{

    public string Name { get; set; }
    public List<TempUnit> Armies { get; set; }

    public List<TempTerritory> Territories { get; set; }

    public Color Color { get; set; }

    public override string ToString()
    {
        return "Player: " + Name + "Units:   " + Armies + "Territories Owned: " + Territories ;
    }

    //public List<TempOrders> GetOrders()
    //{
        
    //}

    public void Reset()
    {
        this.Reset();
    }

    public void ResetOrders()
    {
        this.Reset();
    }
    
}

public class TempUnit
{
    public int Amount { get; set; }
}

public class TempTerritory
{
    public int Amount { get; set; }
}

public class PlayerAI: Player
{

}

public class TempOrders
{

}
