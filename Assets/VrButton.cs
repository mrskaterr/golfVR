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



}
