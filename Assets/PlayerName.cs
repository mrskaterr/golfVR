using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    List <string> Players;
    [SerializeField] Text label;
    int levelCount = 5; 
    private void Awake()
    {
        //PlayerPrefs.DeleteAll();

        Players = new List<string>();

        foreach (string player in PlayerPrefs.GetString("Names").Split(';'))
        {
                Players.Add(player);
        }
        Debug.Log(PlayerPrefs.GetString("Names"));

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
                this.gameObject.gameObject.SetActive(false);
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

        this.gameObject.gameObject.SetActive(false);
    }
}
