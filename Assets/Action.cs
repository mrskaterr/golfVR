using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Action : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private UnityEvent evets;

    private void Evets()
    {
        evets.Invoke();
    }    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject== ball)
            Evets();
    }
}
