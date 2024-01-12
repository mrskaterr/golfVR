using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingSum : MonoBehaviour
{
    List<string> Players;
    [SerializeField] Text name;
    [SerializeField] Text score;
    [SerializeField] Text header;
    private int countLevel=5;
    private void OnEnable()
    {
        name.text = "";
        score.text = "";
        header.text = "Ranking Suma ";
        Players = new List<string>();

        foreach (string player in PlayerPrefs.GetString("Names").Split(';'))
        {
            Players.Add(player);
        }
        Players.RemoveAt(Players.Count - 1);

        foreach (string player in Players)
        {
            name.text += player + "\n"; 
            score.text += sum(player) + "\n";
        }

    }
    int sum(string p)
    {
        int buff=0;
        for (int i = 0; i < countLevel; i++)
            buff += PlayerPrefs.GetInt(p + i);
        return buff;
    }
}