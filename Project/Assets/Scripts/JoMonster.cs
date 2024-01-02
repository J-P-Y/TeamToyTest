using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class JoMonster
{
    //값을 받는 것
    public string monname;
    public int atk;
    public int maxHp;
    public int currentHp;
    public Sprite monSprite;
    public bool die;
    public bool stun;
    
    public JoMonster()
    {

    }
    public JoMonster(string _name,int _atk,int _hp,Sprite _monSprite) // 생성자
    {
        monname = _name;
        atk = _atk;
        maxHp = _hp;
        currentHp = _hp;
        monSprite = _monSprite;
        die = false;
    }

    
}
