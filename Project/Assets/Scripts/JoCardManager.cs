using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class JoCardManager : MonoBehaviour
{
    List<JoMonster> monsters=new List<JoMonster>(); // 몬스터리스트

    List<JoMonster> monsterrand=new List<JoMonster>(); // 소환할 리스트 

    public TextMeshProUGUI[] mnameText;
    public TextMeshProUGUI[] matkText;
    public TextMeshProUGUI[] mhpText;
    public Image[] MonImg;

    public Sprite[] Monspr;

    int hp=100;
    public TextMeshProUGUI userHp;

    void Start()
    {
        

        AddMonsters("아", 120, 120);
        AddMonsters("아2", 120, 105);
        AddMonsters("아3", 120, 105);
        
        RandSpawn(3);


        Debug.Log(monsterrand[0].monname);
        Debug.Log(monsterrand[1].monname);
        Debug.Log(monsterrand[2].monname);

        Attack(0);
  
    }
    void RandSpawn(int _cnt)
    {
        for (int i = 0; i < _cnt; i++)
        {
            JoMonster newMonster2 = monsters[Random.Range(0, monsters.Count)];
            monsterrand.Add(newMonster2);
            mnameText[i].text = monsterrand[i].monname;
            matkText[i].text = ""+monsterrand[i].atk;
            mhpText[i].text = monsterrand[i].currentHp + "/" + monsterrand[i].maxHp;
        }
    }
    void AddMonsters(string _name,int _atk,int _hp)
    {
        JoMonster newMonster = new JoMonster(_name, _atk, _hp);
        monsters.Add(newMonster);
    }

    public void Attack(int i)
    {
        monsterrand[i].currentHp -= 10;
        if (monsterrand[i].currentHp<0)
        {
            monsterrand[i].Die();
        }
        UIdate();
    }


  
    public void MonsterAtk()
    {
        for (int i = 0; i < monsterrand.Count; i++) {
            if (monsterrand[i].die == true)
            {
                hp -= monsterrand[i].atk;
            }
        }
        userHp.text = "" + hp;
    }

    public void UIdate()
    {
        for (int i = 0; i < monsterrand.Count; i++)
        {
            mnameText[i].text = monsterrand[i].monname;
            matkText[i].text = "" + monsterrand[i].atk;
            mhpText[i].text = monsterrand[i].currentHp + "/" + monsterrand[i].maxHp;
        }
    }

    

    
}
