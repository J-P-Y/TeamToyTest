using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class MBH_UIManager : MonoBehaviour
{
    public int playerMaxHp;
    public int playerCurHp;

    public int mon1MaxHp;
    public int mon1CurHp;
    public int mon1MinAttack;
    public int mon1MaxAttack;
    public int mon1Damage;

    public int mon2MaxHp;
    public int mon2CurHp;
    public int mon2MinAttack;
    public int mon2MaxAttack;
    public int mon2Damage;


    public int mon3MaxHp;
    public int mon3CurHp;
    public int mon3MinAttack;
    public int mon3MaxAttack;
    public int mon3Damage;


    public int cardValue;
    public int cardMaxValue = 5;


    bool turn;

    bool monsterExist; // 몬스터 존재여부 판별  

    public List<string> monsters = new List<string>();
    
    public List<string> cards= new List<string>();





    public void Start()
    {
        monsters.Add("고블린");
        monsters.Add("오크");
        monsters.Add("트롤");
        monsters.Add("좀비");
        monsters.Add("슬라임");

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
        if (!monsterExist)
        { 
          
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
            playerCurHp = playerCurHp - mon1Damage;
            turn = false;

        }

        else if (turn)
        {
            playerCurHp = playerCurHp - mon1Damage - mon2Damage;
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

    

 