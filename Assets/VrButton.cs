using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VrButton : MonoBehaviour
{
    [SerializeField] Text letters;
    [SerializeField] Text label;

    public void addLetter()
    {

        if (label.text == "_________")
            label.text = "";
        label.text += letters.text;
    }
    public void deleteLetter()
    {
        Debug.Log(PlayerPrefs.GetString("Names"));
        if (label.text == "_________")
            label.text = "";
        Debug.Log(label.text[label.text.Length - 1]);
    }




}
