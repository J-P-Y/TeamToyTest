using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class monster 
{
    public string name;
    public int curHp;
    public int maxHp;
    public int minAttack;
    public int maxAttack;

    public monster(string monsterName, int monsterMaxHp, int monsterCurHp, int monsterMaxAttack, int monsterMinAttack)
    {
       name = monsterName;
       maxHp = monsterMaxHp;
       curHp = monsterCurHp;
       maxAttack = monsterMinAttack;
       minAttack = monsterMinAttack;

    }
}

public class card
{
    public string name;
    public int attack;
    public int hp;
    public card(string cardName, int cardAttack, int cardHp)
    {
        name = cardName;
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
    int monsterExist;
    int monsterSpawn;
    bool turn;

     // 몬스터 존재여부 판별  

   


    public List<string> monsters = new List<string>();
    
    public List<string> cards= new List<string>();





    public void Start()
    {
        monster goblin= new monster("고블린", 100, 100, 12, 10);
        monsters.Add("goblin");

        monster orc = new monster("오크", 120, 120, 14, 9);
        monsters.Add("orc");

        monster troll = new monster("트롤", 110, 110, 10, 10);
        monsters.Add("troll");
        
        monster zombie = new monster("좀비", 80, 80, 7, 7);
        monsters.Add("zombie");

        monster slime = new monster("슬라임", 60, 60, 6, 6);
        monsters.Add("slime");

        cards.Add("공격1");
        cards.Add("공격2");
        cards.Add("공격3");
        cards.Add("공격4");
        cards.Add("방어1");
        cards.Add("공격2");
        cards.Add("공격3");
        cards.Add("공격4");
        cards.Add("특수1");
        cards.Add("특수2");

        Summon();







    }

    // Update is called once per frame
    public void Update()
    {
        
    }

  


    void Summon()
    {
        if (monsterExist==0)
        {
            monsterSpawn = Random.Range(1, 4);   
        }
    }

    void Battle()
    {
        if (!turn)
        {
             turn = true;
        }



        else if (turn)
        {
            int monAttack = Random.Range(1, 3);
            
            turn = false;

        }

        else if (turn)
        {
            
            turn = false;
        }

        else if (turn)
        {
            turn = false;
        }
        
    }

    void HP_Manager()
    {
        


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

    

 