using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class JoCard : MonoBehaviour
{
    public string cardName;
    public int cardCost;
    public int cardType; //0공격카드 1 방어 2 특수
    public int cardValue;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI costText;
    public TextMeshProUGUI valueText;

    private void Start()
    {
        nameText.text = cardName;
        costText.text = "Cost"+cardCost;
        valueText.text = "Value" + cardValue;
    }

    public void Use()
    {
        if (cardType == 0) //공격카드니?
        {
            if (JoCardManager.userCurCost >= cardCost) // 코스트는 충분하니?
            {
                if (JoCardManager.monPos == -1)
                {
                    Debug.Log("대상이 없어");
                }
                else
                {
                    JoCardManager.userCurCost -= cardCost;
                    JoCardManager.monrand[JoCardManager.monPos].currentHp -= cardValue;
                    JoCardManager.cardCnt--;
                    Destroy(gameObject);
                }
            }
            else
                Debug.Log("코스트가 없어");
        }
        else if (cardType == 1)//방어카드니? 회복카드랑 뭐가다르냐고요? 그건말이죠
        {
            if (JoCardManager.userCurCost >= cardCost)
            {
                JoCardManager.userCurCost -= cardCost;
                JoCardManager.userCurHp += cardValue;
                JoCardManager.cardCnt--;
                Destroy(gameObject);
            }
            else
                Debug.Log("코스트가 없어");
        }
        else if (cardType == 2)//회복카드니? 방어카드랑 뭐가다르냐고요? 그건horse죠
        {
            if (JoCardManager.userCurCost >= cardCost)
            {
                JoCardManager.userCurCost -= cardCost;
                JoCardManager.userCurHp += cardValue;
                JoCardManager.cardCnt--;
                Destroy(gameObject);
            }
            else
                Debug.Log("코스트가 없어");
        }
    }
}
