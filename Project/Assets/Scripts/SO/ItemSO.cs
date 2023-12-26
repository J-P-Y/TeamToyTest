using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;

[System.Serializable]
public class Item : MonoBehaviour
{
    public string name;
    public int attack;
    public int health;
    public Sprite sprite;
    public float percent;
}
[CreateAssetMenu (fileName = "ItemSO", menuName = "Scriptable Object/ItemSO")]
public class ItemSO : ScriptableObject
{
    public Item[] items;
}




