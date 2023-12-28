using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card_3 : MonoBehaviour
{
  public int id;
  public string cardName;
  public int cost;
  public int power;
  public string cardDescription;
 
  public Card_3(int Id, string CardName, int Cost, int Power, string CardDescription)
  {
    id = Id;
    cardName = CardName;
    cost = Cost;
    power = Power;
    cardDescription = CardDescription;
  }
}
