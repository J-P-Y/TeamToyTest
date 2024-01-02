using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class JoCardManager : MonoBehaviour
{
    public List<JoMonster> monsters = new List<JoMonster>();
    public static List<JoMonster> monrand = new List<JoMonster>();
    bool turn;
    public Sprite[] Monspr;


    public GameObject[] monObj;
    public Image[] monImg;
    public TextMeshProUGUI[] monNameText;
    public TextMeshProUGUI[] monAtkText;
    public TextMeshProUGUI[] monHpText;
    public Slider[] sliderVar;


    public static int userCurHp = 100;
    int userMaxHp = 100;
    public static int userCurCost = 2;
    int userMaxCost = 2;
    public static int cardCnt = 0;
    int carMaxCnt = 5;
    public TextMeshProUGUI uHpText;
    public Slider uVar;
    public TextMeshProUGUI uCost;

    public GameObject[] CardPrefab;
    public Transform cardPos;

    public GameObject resetBtn;
    public TextMeshProUGUI resetText;

    public static int monPos;
    public void Click1() // ��..��!��!
    {
        monPos = 0;
    }
    public void Click2()
    {
        monPos = 1;
    }
    public void Click3()
    {
        monPos = 2;
    }

    public void Awake()
    {
        resetBtn.SetActive(false);
        monsters.Add(new JoMonster("���ӽ���", 2, 10,Monspr[0]));
        monsters.Add(new JoMonster("�Ķ�������", 1, 15, Monspr[1]));
        monsters.Add(new JoMonster("���� ����", 3, 10, Monspr[2]));
        monPos = -1;
        RandSpawn();
        
        Game();
    }

    void RandSpawn() // ���� 3���� ���� ����
    {
        for (int i = 0; i < 3; i++)
        {
            JoMonster randMon = monsters[Random.Range(0, monsters.Count)];
            JoMonster valMon = new JoMonster(randMon.monname, randMon.atk, randMon.maxHp,randMon.monSprite);
            monrand.Add(valMon);
        }
    }
    public void ReSetting()
    {
        monrand.Clear();
        for(int i = 0; i < 3; i++)
        {
            monObj[i].SetActive(true);
        }
        userCurCost = 2;
        userMaxCost = 2;
        monPos = -1;
        userCurHp = userMaxHp;
        RandSpawn();
        Game();
        resetBtn.SetActive(false);
    }
    void Game()
    {
        if (!turn)
        {
            monPos = -1;
            UserTurn();
        }
        else
        {
            MonAttack();
            turn = false;
            Game();
        }
    }

    public void TurnEnd()
    {
        turn = true;
        userMaxCost++;
        userCurCost = userMaxCost;
        Game();
    }
    private void Update()
    {
        UIupdate();
    }
    void UIupdate() // UI���� ������Ʈ
    {
        for (int i = 0; i < monrand.Count; i++)
        {
            monImg[i].sprite = monrand[i].monSprite;
            monNameText[i].text = monrand[i].monname;
            monAtkText[i].text = ""+monrand[i].atk;
            monHpText[i].text = monrand[i].currentHp + "/" + monrand[i].maxHp;
            sliderVar[i].value = monrand[i].currentHp;
            sliderVar[i].maxValue = monrand[i].maxHp;
            uHpText.text = userCurHp+"/" + userMaxHp;
            uVar.value = userCurHp;
            uVar.maxValue = userMaxHp;
            uCost.text = "�ڽ�Ʈ\n"+userCurCost + "/" + userMaxCost;

            if (monrand[i].die == true)
            {
                monObj[i].SetActive(false);
            }
        }
        if (monrand[0].die == true && monrand[1].die == true && monrand[2].die == true)
        {
            resetText.text = "��Ÿ���׿�\nŬ�����߳׿�;n��ư Ŭ�� �� �����!";
            resetBtn.SetActive(true);
        }
    }
    
    public void UserTurn()
    {
        int _cardval = 0; // �߰��� ī���� ��
        for (int i = 0; i < carMaxCnt; i++)
        {
            if (cardCnt < carMaxCnt)
            {
                cardCnt++;
                _cardval++;
            }
        }
        
        for (int i = 0; i < _cardval; i++)
        {
            GameObject myInstance = Instantiate(CardPrefab[Random.Range(0,CardPrefab.Length)],cardPos.position,Quaternion.identity) ; // �θ� ����
            myInstance.transform.SetParent(cardPos);
        }
    }
    

    public void MonAttack() // ���� ����
    {
        for (int i = 0; i < monrand.Count; i++)
        {
            if (!monrand[i].die) //���׾���?
            {
                if (monrand[i].stun)
                {
                    Debug.Log("������");
                    monrand[i].stun = false;
                }
                else
                {
                    userCurHp -= monrand[i].atk;
                    if (userCurHp <= 0)
                    {
                        resetText.text = "���ϵ帳�ϴ�\n�׾����ϴ�!\n��ư Ŭ�� �� �����!";
                        resetBtn.SetActive(true);
                    }
                }
                
            }
        }
    } 

}
