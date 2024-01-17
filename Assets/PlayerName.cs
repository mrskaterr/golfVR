using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    List <string> Players;
    [SerializeField] Text label;
    [SerializeField] GameObject Ranking;
    int levelCount = 5;
    [SerializeField] GameObject teleportation;
    private void Awake()
    {
        

        Players = new List<string>();
        if (PlayerPrefs.GetString("Names").Length==0)
        {
            Debug.Log("nima");
            return;
        }
        foreach (string player in PlayerPrefs.GetString("Names").Split(';'))
        {   
                
                Players.Add(player);
        }
        Players.RemoveAt(Players.Count-1);

        Debug.Log(PlayerPrefs.GetString("Names"));
        //PlayerPrefs.DeleteAll();

    }
    public void Enter()
    {
        if (label.text == "_________" || label.text == "")
            return;
        for (int i = 0; i < Players.Count; i++)
        {
            if(Players[i]==label.text)
            {
                PlayerPrefs.SetString("CurrentPlayer", label.text);
                Debug.Log("juz isnieje");
                PlayerPrefs.SetInt("CurrentLevel", 0);
                this.gameObject.gameObject.SetActive(false);
                Ranking.SetActive(true) ;
                PlayerPrefs.Save();
                return;
            }
        }

        PlayerPrefs.SetString("Names", PlayerPrefs.GetString("Names") + label.text + ";");
        PlayerPrefs.SetString("CurrentPlayer", label.text);
        PlayerPrefs.SetInt("CurrentLevel", 0);
        Debug.Log(PlayerPrefs.GetString("Names"));
        Players.Add(label.text);
        for(int i = 0; i < levelCount; i++)
        {
            PlayerPrefs.SetInt(label.text + i, 0);
        }

        gameObject.gameObject.SetActive(false);
        Ranking.SetActive(true);
        PlayerPrefs.Save();
        teleportation.SetActive(true);

    }
}
