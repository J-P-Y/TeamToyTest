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
    int monsterExist=0; // ��ȯ�� ���� ���� �����Ͽ� 0���� ���� 
    int monsterSpawnId; // ��ȯ�ؾ��ϴ� ���� ID
    int monsterValue;//��ȯ�ؾ��ϴ� ���� ���� 
    int monsterRange;//���� Ŭ������ �߰��Ǿ� �ִ� ���� �� 
    int addCardValue;// ���� �̾ƾ��ϴ� ī�� ����
                     
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
        
        AddMonster("���", 1, 100, 12, 10);

        AddMonster("��ũ", 2, 120, 14, 9);

        AddMonster("Ʈ��", 3, 110, 10, 10);

        AddMonster("����", 4, 80, 7, 7);

        AddMonster("������", 5, 60, 6, 6);

        

        Addcard("����1", 1, 1, 0);


        Addcard("����2", 2, 2, 0);

        Addcard("����3", 1, 1, 0);

        Addcard("����4", 1, 1, 0);

        Addcard("���1", 1, 1, 0);

        Addcard("���2", 1, 1, 0);

        Addcard("���3", 3, 3, 0);

        Addcard("���4", 4, 4, 0);

        Addcard("Ư��1", 1, 1, 0);

        Addcard("Ư��2", 2, 2, 0);
       
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
            monsterValue = Random.Range(1, 4); // 1~3 ������ ���� ������ �������� 
            monsterExist = monsterValue;

            for (int i = 0; i < monsterValue + 1; i++)
            {
                


            }

        }


    }


    void Summon() // ���� ��ȯ �Լ� 
    {
        if (monsterExist == 0)
        {
            turn = false;
            monsterValue = Random.Range(1, 4); // 1~3 ������ ���� ������ �������� 
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



        else if (turn) // ���� �� ����
        {
           //�÷��̾� ü�¿��� ���� �Ѹ��� ���ݷ� ����
                    
            turn = false; // �� ���� 

        }

        else if (turn) // ���� �� ���� 
        {
            //  ���� �θ����� ������(�� ������ �ּ� �ִ� ������ ������)�� ���ؼ� �÷��̾� ü�¿��� ����  
            turn = false;
        }

        else if (turn) // ���� �� ���� 
        {
            //  ���� �������� ������(�� ������ �ּ� �ִ� ������ ������)�� ���ؼ� �÷��̾� ü�¿��� ����  
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

