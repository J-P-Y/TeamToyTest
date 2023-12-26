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

    bool monsterExist; // ���� ���翩�� �Ǻ�  

    public List<string> monsters = new List<string>();
    
    public List<string> cards= new List<string>();





    public void Start()
    {
        monsters.Add("���");
        monsters.Add("��ũ");
        monsters.Add("Ʈ��");
        monsters.Add("����");
        monsters.Add("������");

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

    

 