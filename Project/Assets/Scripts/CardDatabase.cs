using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
void Awake()
{
    cardList.Add (new Card (0, "None", 0, 0, "None"));
}
}
