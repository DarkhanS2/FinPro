using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Player currentPlayer;
    public List<Player> players = new List<Player>();
    private int turnIndex;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        // Iniciaciaya setapa igri
        foreach (Player player in players)
        {
            player.Initialize();
        }
        currentPlayer = players[0];
        turnIndex = 0;
    }

    public void EndTurn()
    {
        turnIndex = (turnIndex + 1) % players.Count;
        currentPlayer = players[turnIndex];
        currentPlayer.BeginTurn();
    }

    public void CheckWinConditions()
    {
        // Dobavit' check na win condition
    }
}