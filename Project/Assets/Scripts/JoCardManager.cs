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

    //유저정보
    int userMaxHp;
    int usrCurHp;
    int maxcost;
    int curcost;
    //적 정보
    GameObject[] mondata;
    int enemyMaxHp;
    int enemyCurHp;
    int enemyAtk;
    //카드 정보
    bool clickCard;
    int cardIndex;
    int cardCost;
    string cardName;
    string cardAtk;
    

    //턴 관리
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
    void Setting() // 기본세팅
    {
        maxcost = 2;
        curcost = maxcost;
    }
    void Game()
    {
        if (!turn) //유저의 턴
        {

        }
        else // 적턴
        {
            maxcost++;
        }
    }
    void TurnEnd()
    {
        turn = false;
    }
    void ClickCard() // 카드를 클릭하였을 경우 
    {
        if (cardIndex == 0) //공격 카드일경우
        {
            clickCard = true;
        }
        else if (cardIndex == 1) // 방어카드일 경우
        {
            curcost -= cardCost;
        }
        else // 특수 카드일 경우
        {
            curcost -= cardCost;
        }
    }

    void CardUpdate()
    {

    }
    

}
