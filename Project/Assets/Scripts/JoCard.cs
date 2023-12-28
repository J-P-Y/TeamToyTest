using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class JoCard : MonoBehaviour
{
    public string cardName;
    public int cardCost;
    public int cardType; //0����ī�� 1 ��� 2 Ư��
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
        if (cardType == 0) //����ī���?
        {
            if (JoCardManager.userCurCost >= cardCost) // �ڽ�Ʈ�� ����ϴ�?
            {
                if (JoCardManager.monPos == -1)
                {
                    Debug.Log("����� ����");
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
                Debug.Log("�ڽ�Ʈ�� ����");
        }
        else if (cardType == 1)//���ī���? ȸ��ī��� �����ٸ��İ��? �װǸ�����
        {
            if (JoCardManager.userCurCost >= cardCost)
            {
                JoCardManager.userCurCost -= cardCost;
                JoCardManager.userCurHp += cardValue;
                JoCardManager.cardCnt--;
                Destroy(gameObject);
            }
            else
                Debug.Log("�ڽ�Ʈ�� ����");
        }
        else if (cardType == 2)//ȸ��ī���? ���ī��� �����ٸ��İ��? �װ�horse��
        {
            if (JoCardManager.userCurCost >= cardCost)
            {
                JoCardManager.userCurCost -= cardCost;
                JoCardManager.userCurHp += cardValue;
                JoCardManager.cardCnt--;
                Destroy(gameObject);
            }
            else
                Debug.Log("�ڽ�Ʈ�� ����");
        }
    }
}
