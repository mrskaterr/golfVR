using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{
    class row
    {
        public string name;
        public int score;
        public row(string n, int s)
        {
            this.name = n;
            this.score = s;
        }
    }
    row[] PlayerRow;
    List<string> Players;
    [SerializeField] Text name;
    [SerializeField] Text score;
    [SerializeField] Text header;
    private string currentLevel;
    private void OnEnable()
    {
        Refresh();
    }
    public void Refresh()
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
        PlayerRow = new row[Players.Count];

        for (int i = 0; i < Players.Count; i++)
        {
            PlayerRow[i] = new row(Players[i], PlayerPrefs.GetInt(Players[i] + currentLevel) );

        }
        row buff;
        for (int j = 0; j < PlayerRow.Length; j++)
        {
            for (int i = 1; i < PlayerRow.Length; i++)
            {
                if (PlayerRow[i - 1].score < PlayerRow[i].score)
                {
                    buff = PlayerRow[i];
                    PlayerRow[i] = PlayerRow[i - 1];
                    PlayerRow[i - 1] = buff;
                }
            }
        }

        for (int i = 1; i < PlayerRow.Length; i++)
        {
            name.text += PlayerRow[i].name + "\n";
            score.text += PlayerRow[i].score + "\n";
        }


    }
}