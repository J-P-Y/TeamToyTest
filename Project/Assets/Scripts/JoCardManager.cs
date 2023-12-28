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
    public void Click1() // 하..하!하!
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
        monsters.Add(new JoMonster("블루머쉬맘", 20, 100,Monspr[0]));
        monsters.Add(new JoMonster("파란달팽이", 15, 80, Monspr[1]));
        monsters.Add(new JoMonster("물의 정령", 10, 120, Monspr[2]));
        monPos = -1;
        RandSpawn();
        
        Game();
    }

    void RandSpawn() // 몬스터 3마리 랜덤 스폰
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
    void UIupdate() // UI값을 업데이트
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
            uCost.text = "코스트\n"+userCurCost + "/" + userMaxCost;
        }
    }
    
    public void UserTurn()
    {
        int _cardval = 0; // 추가된 카드의 값
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
            GameObject myInstance = Instantiate(CardPrefab[Random.Range(0,CardPrefab.Length)],cardPos.position,Quaternion.identity) ; // 부모 지정
            myInstance.transform.SetParent(cardPos);
        }
    }
    public void Useratk(int _val) // 유저 공격
    {
        monrand[_val].currentHp -= 20;
        if (monrand[_val].currentHp <= 0)// 체력이 0 이면 삭제
        {
            monObj[_val].SetActive(false);
            monrand[_val].Die();
        }
    }

    public void MonAttack() // 몬스터 공격
    {
        for (int i = 0; i < monrand.Count; i++)
        {
            if (!monrand[i].die) //안죽었니?
            {
                userCurHp -= monrand[i].atk;
                if (userCurHp <= 0)
                {
                    resetText.text = "축하드립니다\n죽었습니다!\n버튼 클릭 시 재시작!";
                    resetBtn.SetActive(true);
                }
            }
        }

        if(monrand[0].die == true && monrand[1].die == true && monrand[2].die == true)
        {
            resetText.text = "안타깝네요\n클리어했네요;n버튼 클릭 시 재시작!";
            resetBtn.SetActive(true);
        }
    } 

}
