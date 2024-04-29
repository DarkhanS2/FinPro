using System.Collections.Generic;
using UnityEngine;

public class Battlefield : MonoBehaviour
{
    public List <MinionCard> minions;
    public void AddMinion(MinionCard card)
    {
        if (!minions.Contains(card))
        {
            minions.Add(card);
        }
    }

    public void RemoveMinion(MinionCard card)
    {
        if (minions.Contains(card))
        {
            minions.Remove(card);
        }
    }

    public void PerformAttack(MinionCard attacker, MinionCard defender)
    {
        attacker.Attack(defender);
        // Chek na to cho defender mojet kontratakovat'
        if (defender.health > 0)
        {
            defender.Attack(attacker);
        }
    }