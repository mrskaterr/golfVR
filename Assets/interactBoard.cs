using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactBoard : MonoBehaviour
{
    [SerializeField] GameObject raycastinterac;
    private void OnDisable()
    {
        //raycastinterac.SetActive(true);
    }
    private void OnEnable()
    {
        //raycastinterac.SetActive(false);
    }
}
