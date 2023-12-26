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

     // ���� ���翩�� �Ǻ�  

   


    public List<string> monsters = new List<string>();
    
    public List<string> cards= new List<string>();





    public void Start()
    {
        monster goblin= new monster("���", 100, 100, 12, 10);
        monsters.Add("goblin");

        monster orc = new monster("��ũ", 120, 120, 14, 9);
        monsters.Add("orc");

        monster troll = new monster("Ʈ��", 110, 110, 10, 10);
        monsters.Add("troll");
        
        monster zombie = new monster("����", 80, 80, 7, 7);
        monsters.Add("zombie");

        monster slime = new monster("������", 60, 60, 6, 6);
        monsters.Add("slime");

        cards.Add("����1");
        cards.Add("����2");
        cards.Add("����3");
        cards.Add("����4");
        cards.Add("���1");
        cards.Add("����2");
        cards.Add("����3");
        cards.Add("����4");
        cards.Add("Ư��1");
        cards.Add("Ư��2");

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


// TCG �������� 
// *UI ���ַ� ���� 
// 
// ī�� 5��, ��, ���� 1~3��, ���, ���� ü�¹�, ���� ü�� ǥ�� (�ؽ�Ʈ), ���� �̹���(����)
// �÷��̾� ü�� ��, �÷��̾� ü�� ǥ��(�ؽ�Ʈ), �÷��̾� �̹���(����), ��� 
// ���� ǥ��â(TMP), ������ ��ư 



// *����
// �ִ�hp, ���� ü��, ���� �ִ� hp, ����hp, ���� �ּ� ���ݷ�, �ִ� ���ݷ�
// �÷��̾� �ִ� �ڽ�Ʈ, �÷��̾� ���� �ڽ�Ʈ 
// ���ݷ�, ����, ��,      
// �� ����(�ִ� ����), ī���� ����(�ִ� ����), 
// ���� �� ����= ���ӽ���� ���� ����
// ���� ��ȯ�� 
// ���� ���� ���� -- ���������� �̿� 
// ���� ��ȯ ���� ���� 3 
// 



// *��Ÿ
// �ǰ� Ÿ�ݽ� ��鸲 
// ī�� ���� ī�� ����� ����
// ���� Scene, �¸�/�й� Scene ��ȯ 




// 1.���۽� ��ü ����
// public void Start()
// 
// {���� ���� �Լ�}
// �����Լ��� ���ԵǾ� �Ұ� ���� ��ȯ ���� 
// 
// 
// 2.���ݽ� ����ī�� ����
// public void Update()
// {
// 
// } 

// 3. �ʿ� �Լ��� 
// void bar_Update 
// void battle 
// ����.������ (1~3) --- ���� ��ȯ ���� 


// ���� ��ȯ ���� 
// ���� ��ȯ���� = ����.������(1,4)
// ���� ����Ʈ���� ���� ��ȯ������ŭ �������� ���� 
// ��ȯ�� ���͵��� ���� ��ȯ ������ ��ġ 
// ��ġ�� ���� ���� ���� ���� 

// ���� 
// bool������ �÷��̾�, ���� �� �Ǻ� 
// 
// ���� �� ������ ��� ����ġ Ȥ�� if���� ���� ���� ���ڿ� ���� �޶��� 

    

 