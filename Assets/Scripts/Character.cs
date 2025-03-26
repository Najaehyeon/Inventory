using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string UserName { get; private set; }
    public int Level { get; private set; }
    public string Description { get; private set; }
    public int Atk { get; private set; }
    public int Def { get; private set; }
    public int Health { get; private set; }
    public int Crit { get; private set; }

    public Character(string userName, int level, string description, int atk, int def, int health, int crit)
    {
        UserName = userName;
        Level = level;
        Description = description;
        Atk = atk;
        Def = def;
        Health = health;
        Crit = crit;
    }
}
