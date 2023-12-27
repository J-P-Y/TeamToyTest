using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MBH_MonsterClass : MonoBehaviour
{
    public class monster
    {
        public string name;
        public int ID;
        public int curHp;
        public int maxHp;
        public int minAttack;
        public int maxAttack;

        public monster(string monsterName, int monsterId, int _hp, int monsterMaxAttack, int monsterMinAttack)
        {
            name = monsterName;
            ID = monsterId;
            maxHp = _hp;
            curHp = _hp;
            maxAttack = monsterMinAttack;
            minAttack = monsterMinAttack;

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
