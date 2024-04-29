using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 30;
    public int mana = 0;
    public Deck deck;
    public List<Card> hand = new List<Card>();

    public void Initialize()
    {
        deck.Shuffle();
        DrawInitialCards();
    }

    void DrawInitialCards()
    {
        for (int i = 0; i < 3; i++)
        {
            DrawCard();
        }
    }

    public void BeginTurn()
    {
        DrawCard();
        mana++;
    }

    public void DrawCard()
    {
        Card card = deck.Draw();
        if (card != null)
        {
            hand.Add(card);
        }
    }

    public void PlayCard(Card card)
    {
        if (mana >= card.cost)
        {
            mana -= card.cost;
            card.Play();
            hand.Remove(card);
        }
    }
}
