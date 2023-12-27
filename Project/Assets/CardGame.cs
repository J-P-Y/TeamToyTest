using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class CardGame : MonoBehaviour
{
    public Button[] cardButtons;
    public Button resetButton;
    public TextMeshProUGUI[] cardTexts;
    public TextMeshProUGUI warningText;
    public TextMeshProUGUI warningText2;
    public TextMeshProUGUI HP1;
    public TextMeshProUGUI HP2;
    public TextMeshProUGUI endText;

    // �ʱ� HP ��
    public int initialHP1 = 50;
    public int initialHP2 = 30;

    void Start()
    {
        // �ʱ⿡�� ��� TextMeshPro�� ����ϴ�.
        foreach (var cardText in cardTexts)
        {
            cardText.gameObject.SetActive(false);
        }

        // Warning TextMeshPro�� ��Ȱ��ȭ�մϴ�.
        warningText.gameObject.SetActive(false);
        warningText2.gameObject.SetActive(false);

        // �� Card ��ư�� ���� �̺�Ʈ ���
        for (int i = 0; i < cardButtons.Length; i++)
        {
            int index = i;
            cardButtons[i].onClick.AddListener(() => ShowRandomEffect(index));
        }

        // Reset ��ư Ŭ�� �̺�Ʈ ���
        resetButton.onClick.AddListener(ResetGame);

        // HP1�� HP2 �ʱⰪ ����
        HP1.text = "PlayerHP: " + initialHP1.ToString();
        HP2.text = "MonsterHP: " + initialHP2.ToString();

        endText.gameObject.SetActive(false);
    }

    void Update()
    {
        CheckGameEndCondition();
    }

    void CheckGameEndCondition()
    {
        // hp2�� 0 ������ ��� (�÷��̾� �¸�)
        if (initialHP2 <= 0)
        {
            endText.text = "�¸�";
            StartCoroutine(EndGameAfterDelay());
        }
        // hp1�� 0 ������ ��� (�÷��̾� �й�)
        else if (initialHP1 <= 0)
        {
            endText.text = "�й�";
            StartCoroutine(EndGameAfterDelay());
        }
    }

    IEnumerator EndGameAfterDelay()
    {
        // 2�� ���
        yield return new WaitForSeconds(2f);

        // endText�� Ȱ��ȭ�Ͽ� ����� ǥ��
        endText.gameObject.SetActive(true);

        // ���� ���� �ʱ�ȭ
        initialHP1 = 50;
        initialHP2 = 30;

        // HP1�� HP2 �ʱⰪ ����
        HP1.text = "PlayerHP: " + initialHP1.ToString();
        HP2.text = "MonsterHP: " + initialHP2.ToString();

        // ��� TextMeshPro�� ����� ��� Card ��ư�� Ȱ��ȭ
        foreach (var cardText in cardTexts)
        {
            cardText.gameObject.SetActive(false);
        }

        foreach (var button in cardButtons)
        {
            button.interactable = true;
        }

        // endText�� 3�� �Ŀ� ��Ȱ��ȭ
        StartCoroutine(HideEndText());
    }

    IEnumerator HideEndText()
    {
        yield return new WaitForSeconds(3f);
        endText.gameObject.SetActive(false);
    }
    void ShowRandomEffect(int buttonIndex)
    {
        // 1���� 10������ ���� ���� ����
        int randomEffectCount = Random.Range(1, 11);

        // ������ ���ڸ� ������� �ؽ�Ʈ�� ����
        string effectText;

        // ������ ���ڰ� Ȧ������ ¦������ Ȯ��
        if (randomEffectCount % 2 == 1)
        {
            // Ȧ���� ��� "�÷��̾ i�� �������� ���� �����߽��ϴ�" ���
            effectText = "�÷��̾ " + randomEffectCount + "�� �������� ���� �����߽��ϴ�.";
        }
        else
        {
            // ¦���� ��� "�÷��̾ 'i' ��ŭ ü���� ȸ���߽��ϴ�" ���
            int recoveryAmount = randomEffectCount / 2;
            effectText = "�÷��̾ " + recoveryAmount + "��ŭ ü���� ȸ���߽��ϴ�.";
        }

        // ������ �ؽ�Ʈ�� TextMeshPro�� ǥ��
        cardTexts[buttonIndex].text = effectText;

        // TextMeshPro�� ���̰� �ϰ� �ش� Card ��ư�� ��Ȱ��ȭ
        cardTexts[buttonIndex].gameObject.SetActive(true);
        cardButtons[buttonIndex].interactable = false;

        // ������ ���ڰ� Ȧ������ ¦������ Ȯ��
        if (randomEffectCount % 2 == 0)
        {
            // ¦���� ��� HP1 ����
            int increaseAmount = randomEffectCount / 2;
            initialHP1 += increaseAmount;
            HP1.text = "PlayerHP: " + initialHP1.ToString();
        }
        else
        {
            // Ȧ���� ��� HP2 ����
            initialHP2 -= randomEffectCount;
            HP2.text = "MonsterHP: " + initialHP2.ToString();
        }
    }

    IEnumerator DisplayWarning(int effectCount)
    {
        // Warning TextMeshPro�� Ȱ��ȭ�ϰ� 3�ʰ� ���
        warningText.gameObject.SetActive(true);
        warningText2.gameObject.SetActive(true);

        foreach (var button in cardButtons)
        {
            button.interactable = false;
        }

        // Warning Text 2�� ǥ��
        string warningText2Content = "NO." + effectCount + " Effect is activated.";
        warningText2.text = warningText2Content;

        yield return new WaitForSeconds(3f);

        // 3�� �Ŀ� Warning TextMeshPro �� Text 2�� ��Ȱ��ȭ�ϰ� ��� ��ư Ȱ��ȭ
        warningText.gameObject.SetActive(false);
        warningText2.gameObject.SetActive(false);
        foreach (var button in cardButtons)
        {
            button.interactable = true;
        }
    }

    void ResetGame()
    {
        // ��� TextMeshPro�� ����� ��� Card ��ư�� Ȱ��ȭ
        foreach (var cardText in cardTexts)
        {
            cardText.gameObject.SetActive(false);
        }

        foreach (var button in cardButtons)
        {
            button.interactable = true;
        }

        // 1���� 10������ ���� ���ڸ� ����
        int randomEffectCount = Random.Range(1, 11);

        // ������ ���ڸ� ������� �ؽ�Ʈ�� ����
        string effectText;

        // ������ ���ڰ� Ȧ������ ¦������ Ȯ��
        if (randomEffectCount % 2 == 1)
        {
            // Ȧ���� ��� "���Ͱ� k�� �������� ���� �����߽��ϴ�" ���
            effectText = "���Ͱ� " + randomEffectCount + "�� �������� �÷��̾ �����߽��ϴ�.";

            // Ȧ���� ��� HP1 ����
            initialHP1 -= randomEffectCount;
            HP1.text = "PlyaerHP: " + initialHP1.ToString();
        }
        else
        {
            // ¦���� ��� "���Ͱ� 'l' ��ŭ ü���� ȸ���߽��ϴ�" ���
            int recoveryAmount = randomEffectCount / 2;
            effectText = "���Ͱ� " + recoveryAmount + "��ŭ ü���� ȸ���߽��ϴ�.";

            // ¦���� ��� HP2 ����
            initialHP2 += recoveryAmount;
            HP2.text = "MonsterHP: " + initialHP2.ToString();
        }

        // ������ �ؽ�Ʈ�� TextMeshPro�� ǥ��
        warningText.text = effectText;

        // Warning TextMeshPro�� Ȱ��ȭ�ϰ� 3�ʰ� ���
        warningText.gameObject.SetActive(true);

        StartCoroutine(DisplayWarning());
    }
    IEnumerator DisplayWarning()
    {
        foreach (var button in cardButtons)
        {
            button.interactable = false;
        }

        yield return new WaitForSeconds(3f);

        // 3�� �Ŀ� Warning TextMeshPro�� ��Ȱ��ȭ�ϰ� ��� ��ư Ȱ��ȭ
        warningText.gameObject.SetActive(false);
        foreach (var button in cardButtons)
        {
            button.interactable = true;
        }
    }
}