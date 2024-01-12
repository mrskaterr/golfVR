using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private UnityEvent evets;
    
    private void Evets()
    {
        evets.Invoke();
        if (PlayerPrefs.GetInt(PlayerPrefs.GetString("CurrentPlayer") + PlayerPrefs.GetInt("CurrentLevel").ToString()) < ball.GetComponent<Ball>().GetPoint())
        {

            PlayerPrefs.SetInt(PlayerPrefs.GetString("CurrentPlayer") + PlayerPrefs.GetInt("CurrentLevel").ToString(), ball.GetComponent<Ball>().GetPoint());
        }
        Debug.Log(PlayerPrefs.GetInt(PlayerPrefs.GetString("CurrentPlayer") + PlayerPrefs.GetInt("CurrentLevel").ToString()));
    }    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == ball)
            Evets();
    }
}
