using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class monster 
{
    public string name;
    public int ID;
    public int curHp;
    public int maxHp;
    public int minAttack;
    public int maxAttack;

    public monster(string monsterName,int monsterId, int _hp, int monsterMaxAttack, int monsterMinAttack)
    {
       name = monsterName;
       ID = monsterId;
       maxHp = _hp;
       curHp = _hp;
       maxAttack = monsterMinAttack;
       minAttack = monsterMinAttack;

    }
}

public class card
{
    public string name;
    public int ID;
    public int attack;
    public int hp;
    public card(string cardName,int card_Id, int cardAttack, int cardHp)
    {
        name = cardName;
        ID = card_Id;
        attack = cardAttack;
        hp = cardHp;

    }
}





public class MBH_UIManager : MonoBehaviour
{
    public int playerMaxHp;
    public int playerCurHp;
    public int cardValue;
    public int cardMaxValue = 5;
    int monsterExist=0; // 소환된 몬스터 수량 시작턴에 0으로 시작 
    int monsterSpawnId; // 소환해야하는 몬스터 ID
    int monsterValue;//소환해야하는 몬스터 수량 
    int monsterRange;//몬스터 클래스에 추가되어 있는 몬스터 수 
    int addCardValue;// 새로 뽑아야하는 카드 수량
                     
    bool turn;


    [SerializeField]
    TextMeshProUGUI playerHptext;

    [SerializeField]
    TextMeshProUGUI monsterHptext;




    public List<monster> monsters = new List<monster>();
    
    public List<card> cards= new List<card>();

    void AddMonster(string _name, int _id,int _hp, int _maxAtk,int _minAtk)
    {
        monster newmonster = new monster(_name, _id, _hp, _maxAtk, _minAtk);
        monsters.Add(newmonster);
    }

    void Addcard(string _name, int _id, int _atk, int _hp)
    {
        card newcard = new card(_name, _id, _atk, _hp);
        cards.Add(newcard);
    }



    public void Start()
    {
        
        AddMonster("고블린", 1, 100, 12, 10);

        AddMonster("오크", 2, 120, 14, 9);

        AddMonster("트롤", 3, 110, 10, 10);

        AddMonster("좀비", 4, 80, 7, 7);

        AddMonster("슬라임", 5, 60, 6, 6);

        

        Addcard("공격1", 1, 1, 0);


        Addcard("공격2", 2, 2, 0);

        Addcard("공격3", 1, 1, 0);

        Addcard("공격4", 1, 1, 0);

        Addcard("방어1", 1, 1, 0);

        Addcard("방어2", 1, 1, 0);

        Addcard("방어3", 3, 3, 0);

        Addcard("방어4", 4, 4, 0);

        Addcard("특수1", 1, 1, 0);

        Addcard("특수2", 2, 2, 0);
       
        Summon();



    }

    // Update is called once per frame
    public void Update()
    {
        HP_Manager();

    }

    void Setting()
    {
        cardValue = 5;

        for (int i = 0; i < 5; i++)
        { 
        
        }


        if (monsterExist == 0)
        {
            turn = false;
            monsterValue = Random.Range(1, 4); // 1~3 사이의 몬스터 수량을 랜덤으로 
            monsterExist = monsterValue;

            for (int i = 0; i < monsterValue + 1; i++)
            {
                


            }

        }


    }


    void Summon() // 몬스터 소환 함수 
    {
        if (monsterExist == 0)
        {
            turn = false;
            monsterValue = Random.Range(1, 4); // 1~3 사이의 몬스터 수량을 랜덤으로 
            monsterExist = monsterValue;
                       
            for (int i = 0; i < monsterValue + 1; i++)
            {

                monster[Random.Range(0,monsters.Count)]=
                


            }
            
        }


    }

    void card_Draw()
    {
        if (turn! && cardValue != cardMaxValue )
        { 
           addCardValue = cardMaxValue - cardValue;
            for (int i = 0; i < addCardValue + 1; i++)
            {
                
            


                cardValue++;    
            }
                       
        }
    }

    void Battle()
    {
        if (!turn)
        {
              
            
            
            turn = true;
        }



        else if (turn) // 몬스터 한 마리
        {
           //플레이어 체력에서 몬스터 한마리 공격력 감소
                    
            turn = false; // 턴 변경 

        }

        else if (turn) // 몬스터 두 마리 
        {
            //  몬스터 두마리의 데미지(각 몬스터의 최소 최대 데미지 랜덤값)들 합해서 플레이어 체력에서 빼기  
            turn = false;
        }

        else if (turn) // 몬스터 세 마리 
        {
            //  몬스터 세마리의 데미지(각 몬스터의 최소 최대 데미지 랜덤값)들 합해서 플레이어 체력에서 빼기  
            turn = false;
        }
        
    }

    public void turnEnd()
    {
        if (Input.GetMouseButtonDown(0))
        {
            turn = true;
        }

    }
    void HP_Manager()
    {
        //playerHptext.text = playerHp + "/" + playerMaxHp;
        //monsterHptext.text = monHp + "/" + monMaxHp;

        //playerHpbar.maxValue = playerMaxHp;
        //playerHpbar.value = playerHp;

        //monsterHpbar.maxValue = monMaxHp;
        //monsterHpbar.value = monHp;


    }




}

