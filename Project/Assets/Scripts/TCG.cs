using UnityEngine;
using System.Collections.Generic;

public class TCG : MonoBehaviour
{
    // 카드 타입 정의
    public enum CardType { Attack, Defense, Heal }

        
    public class Card
    {
        public string name;
        public int power;
        public int cost;
        public CardType type;
        public Card(string cardName, int cardPower, int cardCost, CardType cardType)
        {
            name = cardName;
            power = cardPower;
            cost = cardCost;
            type = cardType;
        }
    }

    public List<Card> playerDeck = new List<Card>(); // 플레이어 덱
    public List<Card> opponentDeck = new List<Card>(); // 상대방 덱

    public List<Card> playerHand = new List<Card>(); // 플레이어 손패
    public List<Card> opponentHand = new List<Card>(); // 상대방 손패

    public int playerAvailableCost = 1; // 플레이어의 사용 가능한 코스트
    public int opponentAvailableCost = 1; // 상대방의 사용 가능한 코스트

    public enum Turn { Player, Opponent }
    public Turn currentTurn;

    void Start()
    {
       
        playerDeck.Add(new Card("Attack Card 1", 1, 1, CardType.Attack));
        playerDeck.Add(new Card("Attack Card 2", 2, 2, CardType.Attack));
        playerDeck.Add(new Card("Attack Card 3", 3, 3, CardType.Attack));
        playerDeck.Add(new Card("Attack Card 4", 4, 4, CardType.Attack));
        playerDeck.Add(new Card("Defense Card 1", 1, 1, CardType.Defense));
        playerDeck.Add(new Card("Defense Card 2", 2, 2, CardType.Defense));
        playerDeck.Add(new Card("Defense Card 3", 3, 3, CardType.Defense));
        playerDeck.Add(new Card("Defense Card 4", 4, 4, CardType.Defense));
        playerDeck.Add(new Card("Heal Card 2", 2, 2, CardType.Heal));
        playerDeck.Add(new Card("Heal Card 4", 4, 4, CardType.Heal));
        currentTurn = Turn.Player; // 플레이어의 턴으로 시작
        StartTurn();
    }

    void StartTurn()
    {
        if (currentTurn == Turn.Player)
        {
            playerAvailableCost++; // 플레이어의 턴이 시작될 때마다 사용 가능한 코스트 증가
            PlayerTurn();
        }
        else if (currentTurn == Turn.Opponent)
        {
            opponentAvailableCost++; // 상대방의 턴이 시작될 때마다 사용 가능한 코스트 증가
            OpponentTurn();
        }
    }

    void PlayerTurn()
    {
        
        // 여기서 플레이어의 턴 동작을 추가하세요.
        // 코스트에 맞는 카드를 사용하고, 더 이상 사용할 수 있는 카드가 없다면 턴 종료 버튼을 누르도록 구현
    }

    void OpponentTurn()
    {
        // 여기서 상대방의 자동 턴 동작을 추가하세요.
        // 코스트에 맞는 카드를 사용하고, 더 이상 사용할 수 있는 카드가 없다면 자동으로 턴 종료
    }

    public void EndTurnButtonClicked()
    {
        if (currentTurn == Turn.Player)
        {
            currentTurn = Turn.Opponent;
            StartTurn(); // 다음 턴 시작
        }
    }
}
