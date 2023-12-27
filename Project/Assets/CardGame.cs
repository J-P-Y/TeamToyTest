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

    // 초기 HP 값
    public int initialHP1 = 50;
    public int initialHP2 = 30;

    void Start()
    {
        // 초기에는 모든 TextMeshPro를 숨깁니다.
        foreach (var cardText in cardTexts)
        {
            cardText.gameObject.SetActive(false);
        }

        // Warning TextMeshPro를 비활성화합니다.
        warningText.gameObject.SetActive(false);
        warningText2.gameObject.SetActive(false);

        // 각 Card 버튼에 대해 이벤트 등록
        for (int i = 0; i < cardButtons.Length; i++)
        {
            int index = i;
            cardButtons[i].onClick.AddListener(() => ShowRandomEffect(index));
        }

        // Reset 버튼 클릭 이벤트 등록
        resetButton.onClick.AddListener(ResetGame);

        // HP1과 HP2 초기값 설정
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
        // hp2가 0 이하인 경우 (플레이어 승리)
        if (initialHP2 <= 0)
        {
            endText.text = "승리";
            StartCoroutine(EndGameAfterDelay());
        }
        // hp1이 0 이하인 경우 (플레이어 패배)
        else if (initialHP1 <= 0)
        {
            endText.text = "패배";
            StartCoroutine(EndGameAfterDelay());
        }
    }

    IEnumerator EndGameAfterDelay()
    {
        // 2초 대기
        yield return new WaitForSeconds(2f);

        // endText를 활성화하여 결과를 표시
        endText.gameObject.SetActive(true);

        // 게임 변수 초기화
        initialHP1 = 50;
        initialHP2 = 30;

        // HP1과 HP2 초기값 설정
        HP1.text = "PlayerHP: " + initialHP1.ToString();
        HP2.text = "MonsterHP: " + initialHP2.ToString();

        // 모든 TextMeshPro를 숨기고 모든 Card 버튼을 활성화
        foreach (var cardText in cardTexts)
        {
            cardText.gameObject.SetActive(false);
        }

        foreach (var button in cardButtons)
        {
            button.interactable = true;
        }

        // endText를 3초 후에 비활성화
        StartCoroutine(HideEndText());
    }

    IEnumerator HideEndText()
    {
        yield return new WaitForSeconds(3f);
        endText.gameObject.SetActive(false);
    }
    void ShowRandomEffect(int buttonIndex)
    {
        // 1부터 10까지의 랜덤 숫자 생성
        int randomEffectCount = Random.Range(1, 11);

        // 생성된 숫자를 기반으로 텍스트를 생성
        string effectText;

        // 생성된 숫자가 홀수인지 짝수인지 확인
        if (randomEffectCount % 2 == 1)
        {
            // 홀수일 경우 "플레이어가 i의 데미지로 적을 공격했습니다" 출력
            effectText = "플레이어가 " + randomEffectCount + "의 데미지로 적을 공격했습니다.";
        }
        else
        {
            // 짝수일 경우 "플레이어가 'i' 만큼 체력을 회복했습니다" 출력
            int recoveryAmount = randomEffectCount / 2;
            effectText = "플레이어가 " + recoveryAmount + "만큼 체력을 회복했습니다.";
        }

        // 생성된 텍스트를 TextMeshPro에 표시
        cardTexts[buttonIndex].text = effectText;

        // TextMeshPro를 보이게 하고 해당 Card 버튼을 비활성화
        cardTexts[buttonIndex].gameObject.SetActive(true);
        cardButtons[buttonIndex].interactable = false;

        // 생성된 숫자가 홀수인지 짝수인지 확인
        if (randomEffectCount % 2 == 0)
        {
            // 짝수일 경우 HP1 증가
            int increaseAmount = randomEffectCount / 2;
            initialHP1 += increaseAmount;
            HP1.text = "PlayerHP: " + initialHP1.ToString();
        }
        else
        {
            // 홀수일 경우 HP2 감소
            initialHP2 -= randomEffectCount;
            HP2.text = "MonsterHP: " + initialHP2.ToString();
        }
    }

    IEnumerator DisplayWarning(int effectCount)
    {
        // Warning TextMeshPro를 활성화하고 3초간 대기
        warningText.gameObject.SetActive(true);
        warningText2.gameObject.SetActive(true);

        foreach (var button in cardButtons)
        {
            button.interactable = false;
        }

        // Warning Text 2를 표시
        string warningText2Content = "NO." + effectCount + " Effect is activated.";
        warningText2.text = warningText2Content;

        yield return new WaitForSeconds(3f);

        // 3초 후에 Warning TextMeshPro 및 Text 2를 비활성화하고 모든 버튼 활성화
        warningText.gameObject.SetActive(false);
        warningText2.gameObject.SetActive(false);
        foreach (var button in cardButtons)
        {
            button.interactable = true;
        }
    }

    void ResetGame()
    {
        // 모든 TextMeshPro를 숨기고 모든 Card 버튼을 활성화
        foreach (var cardText in cardTexts)
        {
            cardText.gameObject.SetActive(false);
        }

        foreach (var button in cardButtons)
        {
            button.interactable = true;
        }

        // 1부터 10까지의 랜덤 숫자를 생성
        int randomEffectCount = Random.Range(1, 11);

        // 생성된 숫자를 기반으로 텍스트를 생성
        string effectText;

        // 생성된 숫자가 홀수인지 짝수인지 확인
        if (randomEffectCount % 2 == 1)
        {
            // 홀수일 경우 "몬스터가 k의 데미지로 적을 공격했습니다" 출력
            effectText = "몬스터가 " + randomEffectCount + "의 데미지로 플레이어를 공격했습니다.";

            // 홀수일 경우 HP1 감소
            initialHP1 -= randomEffectCount;
            HP1.text = "PlyaerHP: " + initialHP1.ToString();
        }
        else
        {
            // 짝수일 경우 "몬스터가 'l' 만큼 체력을 회복했습니다" 출력
            int recoveryAmount = randomEffectCount / 2;
            effectText = "몬스터가 " + recoveryAmount + "만큼 체력을 회복했습니다.";

            // 짝수일 경우 HP2 증가
            initialHP2 += recoveryAmount;
            HP2.text = "MonsterHP: " + initialHP2.ToString();
        }

        // 생성된 텍스트를 TextMeshPro에 표시
        warningText.text = effectText;

        // Warning TextMeshPro를 활성화하고 3초간 대기
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

        // 3초 후에 Warning TextMeshPro를 비활성화하고 모든 버튼 활성화
        warningText.gameObject.SetActive(false);
        foreach (var button in cardButtons)
        {
            button.interactable = true;
        }
    }
}