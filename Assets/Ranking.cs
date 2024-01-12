using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{
    List<string> Players;
    [SerializeField] Text name;
    [SerializeField] Text score;
    [SerializeField] Text header;
    private string currentLevel;
    private void OnEnable()
    {
        name.text = "";
        score.text = "";
        currentLevel = PlayerPrefs.GetInt("CurrentLevel").ToString();
        header.text = "Ranking Level " + currentLevel;
        Players = new List<string>();

        foreach (string player in PlayerPrefs.GetString("Names").Split(';'))
        {
            Players.Add(player);
        }
        Players.RemoveAt(Players.Count - 1);

        foreach (string player in Players)
        {
            name.text += player + "\n";
            score.text += PlayerPrefs.GetInt(player + currentLevel).ToString() + "\n" ;
        }

    }
}