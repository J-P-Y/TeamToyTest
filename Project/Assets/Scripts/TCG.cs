using UnityEngine;
using System.Collections.Generic;

public class TCG : MonoBehaviour
{
    // ī�� Ÿ�� ����
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

    public List<Card> playerDeck = new List<Card>(); // �÷��̾� ��
    public List<Card> opponentDeck = new List<Card>(); // ���� ��

    public List<Card> playerHand = new List<Card>(); // �÷��̾� ����
    public List<Card> opponentHand = new List<Card>(); // ���� ����

    public int playerAvailableCost = 1; // �÷��̾��� ��� ������ �ڽ�Ʈ
    public int opponentAvailableCost = 1; // ������ ��� ������ �ڽ�Ʈ

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
        currentTurn = Turn.Player; // �÷��̾��� ������ ����
        StartTurn();
    }

    void StartTurn()
    {
        if (currentTurn == Turn.Player)
        {
            playerAvailableCost++; // �÷��̾��� ���� ���۵� ������ ��� ������ �ڽ�Ʈ ����
            PlayerTurn();
        }
        else if (currentTurn == Turn.Opponent)
        {
            opponentAvailableCost++; // ������ ���� ���۵� ������ ��� ������ �ڽ�Ʈ ����
            OpponentTurn();
        }
    }

    void PlayerTurn()
    {
        
        // ���⼭ �÷��̾��� �� ������ �߰��ϼ���.
        // �ڽ�Ʈ�� �´� ī�带 ����ϰ�, �� �̻� ����� �� �ִ� ī�尡 ���ٸ� �� ���� ��ư�� �������� ����
    }

    void OpponentTurn()
    {
        // ���⼭ ������ �ڵ� �� ������ �߰��ϼ���.
        // �ڽ�Ʈ�� �´� ī�带 ����ϰ�, �� �̻� ����� �� �ִ� ī�尡 ���ٸ� �ڵ����� �� ����
    }

    public void EndTurnButtonClicked()
    {
        if (currentTurn == Turn.Player)
        {
            currentTurn = Turn.Opponent;
            StartTurn(); // ���� �� ����
        }
    }
}
