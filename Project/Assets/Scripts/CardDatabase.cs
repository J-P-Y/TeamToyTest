using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public List<Card_3> cardList= new List<Card_3>(); 
void Awake()
{
    cardList.Add (new Card_3 (0, "None", 0, 0, "None"));
}
}
