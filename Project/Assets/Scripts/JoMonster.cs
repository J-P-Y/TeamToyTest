using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class JoMonster
{
    //���� �޴� ��
    public string monname;
    public int atk;
    public int maxHp;
    public int currentHp;
    public Sprite monSpr;
    public bool die;

    //����
    public TextMeshProUGUI nametext;
    public TextMeshProUGUI atktext;
    public TextMeshProUGUI hptext;
    public Image monImg;

    public JoMonster(string _name,int _atk,int _hp) // ������
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
