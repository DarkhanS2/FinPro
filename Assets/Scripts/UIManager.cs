using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text healthText;
    public Text manaText;
    public Text deckCountText;
    public GameObject handDisplay;
    public GameObject battlefieldDisplay;

    public void UpdateHealth(int health)
    {
        healthText.text = "Health: " + health.ToString();
    }

    public void UpdateMana(int mana)
    {
        manaText.text = "Mana: " + mana.ToString();
    }

    public void UpdateDeckCount(int count)
    {
        deckCountText.text = "Deck: " + count.ToString();
    }

    public void UpdateHand(List<Card> hand)
    {
        // Obnovit' logiku otobrazheniya ruki
    }

    public void UpdateBattlefield(List MinionCard> battlefield)
    {
        // Obnovit' logiku otobrazheniya polya srazheniya
    }
}