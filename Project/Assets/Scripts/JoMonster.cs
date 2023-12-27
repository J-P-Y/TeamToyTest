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
    public Sprite monSpr;
    public bool die;

    //연동
    public TextMeshProUGUI nametext;
    public TextMeshProUGUI atktext;
    public TextMeshProUGUI hptext;
    public Image monImg;

    public JoMonster(string _name,int _atk,int _hp) // 생성자
    {
        monname = _name;
        atk = _atk;
        maxHp = _hp;
        currentHp = _hp;
        die = true;
    }

    public void Die()
    {
        die = false;
    }
}
