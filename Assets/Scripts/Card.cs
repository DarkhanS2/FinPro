using UnityEngine;
using UnityEngine.UI;

public abstract class Card : MonoBehaviour
{
    public int cost;
    public string cardName;

    public abstract void Play();

    public abstract void Effect();
}

