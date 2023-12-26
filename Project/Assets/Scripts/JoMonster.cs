using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoMonster:MonoBehaviour
{
    public string name;
    public int atk;
    public int maxHp;
    public int currentHp;

    public JoMonster(string _name,int _atk,int _hp)
    {
        name = _name;
        atk = _atk;
        maxHp = _hp;
        currentHp = _hp;
    }
}
