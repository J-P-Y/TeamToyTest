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

    int addCardValue;// 새로 뽑아야하는 카드 수량
                     
    bool turn; 

     

   


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
        //monster goblin= new monster("고블린",1, 100, 100, 12, 10);
        //monsters.Add("goblin");

        //monster orc = new monster("오크",2, 120, 120, 14, 9);
        //monsters.Add("orc");

        //monster troll = new monster("트롤",3, 110, 110, 10, 10);
        //monsters.Add("troll");

        //monster zombie = new monster("좀비", 4, 80, 80, 7, 7);
        //monsters.Add("zombie");

        //monster slime = new monster("슬라임",5, 60, 60, 6, 6);
        //monsters.Add("slime");
        AddMonster("고블린", 1, 100, 12, 10);

        AddMonster("오크", 2, 120, 14, 9);

        AddMonster("트롤", 3, 110, 10, 10);

        AddMonster("좀비", 4, 80, 7, 7);

        AddMonster("슬라임", 5, 60, 6, 6);

        //card attack1 = new card("공격1", 1, 1, 0);
        //cards.Add("공격1");

        //card attack2 = new card("공격2",2, 2, 0);
        //cards.Add("공격2");

        //card attack3 = new card("공격3",3, 3, 0);
        //cards.Add("공격3");

        //card attack4 = new card("공격4",4, 4, 0);
        //cards.Add("공격4");

        //card defense1 = new card("방어1",5, 0, 1);
        //cards.Add("방어1");

        //card defense2 = new card("방어2",6, 0, 2);
        //cards.Add("방어2");

        //card defense3 = new card("방어3",7, 0, 3);
        //cards.Add("방어3");

        //card defense4 = new card("방어4",8, 0, 4);
        //cards.Add("방어4");

        //card utility1 = new card("유틸1",9, 0, 1);
        //cards.Add("특수1");

        //card utility2 = new card("유틸2",10, 0, 2);
        //cards.Add("특수2");

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

  


    void Summon() // 몬스터 소환 함수 
    {
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
        // 버튼을 클릭하면 변수를 바꿈 

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


// TCG 구조설계 
// *UI 위주로 진행 
// 
// 카드 5장, 덱, 몬스터 1~3개, 배경, 몬스터 체력바, 몬스터 체력 표시 (텍스트), 몬스터 이미지(더미)
// 플레이어 체력 바, 플레이어 체력 표시(텍스트), 플레이어 이미지(더미), 배경 
// 상태 표시창(TMP), 턴종료 버튼 



// *변수
// 최대hp, 현재 체력, 몬스터 최대 hp, 몬스터hp, 몬스터 최소 공격력, 최대 공격력
// 플레이어 최대 코스트, 플레이어 현재 코스트 
// 공격력, 방어력, 턴,      
// 덱 숫자(최대 현재), 카드패 숫자(최대 현재), 
// 게임 중 변수= 게임실행시 변수 증가
// 몬스터 소환수 
// 몬스터 존재 변수 -- 스폰판정에 이용 
// 몬스터 소환 슬롯 변수 3 
// 



// *기타
// 피격 타격시 흔들림 
// 카드 사용시 카드 사라짐 구현
// 시작 Scene, 승리/패배 Scene 전환 




// 1.시작시 전체 세팅
// public void Start()
// 
// {세팅 실행 함수}
// 세팅함수에 포함되야 할것 몬스터 소환 여부 
// 
// 
// 2.공격시 선택카드 삭제
// public void Update()
// {
// 
// } 

// 3. 필요 함수들 
// void bar_Update 
// void battle 
// 랜덤.레인지 (1~3) --- 몬스터 소환 관련 


// 몬스터 소환 관련 
// 몬스터 소환수량 = 랜덤.레인지(1,4)
// 몬스터 리스트에서 몬스터 소환수량만큼 랜덤으로 선택 
// 소환된 몬스터들을 몬스터 소환 지점에 배치 
// 배치후 몬스터 존재 변수 증가 

// 전투 
// bool값으로 플레이어, 몬스터 턴 판별 
// 
// 몬스터 턴 진행의 경우 스위치 혹은 if문을 통해 몬스터 숫자에 따라 달라짐 

    

 