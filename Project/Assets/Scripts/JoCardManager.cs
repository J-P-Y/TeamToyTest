using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
class Monster
{
    public int id;
    public int hp;
    public int atk;

    public void Addclass(int _id,int _hp, int _atk)
    {
        id = _id;
        hp = _hp;
        atk = _atk;
    }
}

public class JoCardManager : MonoBehaviour
{
    TextMeshProUGUI UserHp;
    List<Monster> monster=new List<Monster>();

    //��������
    int userMaxHp;
    int usrCurHp;
    int maxcost;
    int curcost;
    //�� ����
    GameObject[] mondata;
    int enemyMaxHp;
    int enemyCurHp;
    int enemyAtk;
    //ī�� ����
    bool clickCard;
    int cardIndex;
    int cardCost;
    string cardName;
    string cardAtk;
    

    //�� ����
    bool turn;

    private void Start()
    {
        Setting();
        Game();
    }

    private void Update()
    {
        if (turn == true)
        {
            turn = false;
        } 
    }
    void Setting() // �⺻����
    {
        maxcost = 2;
        curcost = maxcost;
    }
    void Game()
    {
        if (!turn) //������ ��
        {

        }
        else // ����
        {
            maxcost++;
        }
    }
    void TurnEnd()
    {
        turn = false;
    }
    void ClickCard() // ī�带 Ŭ���Ͽ��� ��� 
    {
        if (cardIndex == 0) //���� ī���ϰ��
        {
            clickCard = true;
        }
        else if (cardIndex == 1) // ���ī���� ���
        {
            curcost -= cardCost;
        }
        else // Ư�� ī���� ���
        {
            curcost -= cardCost;
        }
    }

    void CardUpdate()
    {

    }
    

}
