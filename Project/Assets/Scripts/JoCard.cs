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
        if (JoCardManager.userCurCost >= cardCost) // 코스트는 충분하니?
        {
            if (cardType == 0) //공격카드니?
            {
                if (JoCardManager.monPos == -1)
                {
                    Debug.Log("대상을 선정해주세요");
                }
                else
                {
                    JoCardManager.userCurCost -= cardCost;
                    JoCardManager.monrand[JoCardManager.monPos].currentHp -= cardValue;

                    if (JoCardManager.monrand[JoCardManager.monPos].currentHp <= 0)
                    {
                        JoCardManager.monrand[JoCardManager.monPos].die = true;
                    }
                    JoCardManager.cardCnt--;
                    Destroy(gameObject);
                }
            }

            else if (cardType == 1)//회복카드
            {
                JoCardManager.userCurCost -= cardCost;
                JoCardManager.userCurHp += cardValue;
                JoCardManager.cardCnt--;
                Destroy(gameObject);

            }
            else if (cardType == 2)//특수 카드 (스턴....)
            {
                if (JoCardManager.monPos == -1)
                {
                    Debug.Log("대상을 선정해주세요");
                }
                else
                {
                    JoCardManager.userCurCost -= cardCost;
                    JoCardManager.cardCnt--;
                    JoCardManager.monrand[JoCardManager.monPos].stun = true;
                    Destroy(gameObject);
                }
            }
        }
        else
            Debug.Log("코스트가 없어");
    }
    
    
}
