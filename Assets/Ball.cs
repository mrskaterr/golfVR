using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    [SerializeField] AudioSource audioBall;
    [SerializeField] AudioSource audiostone;
    [SerializeField] AudioSource audiowood;
    [SerializeField] AudioSource audiosend;
    [SerializeField] GameObject stone;
    [SerializeField] GameObject wood;
    [SerializeField] GameObject send;
    [SerializeField] GameObject grass;

    [SerializeField] Text hitsBallText;
    [SerializeField] Text PointsText;
    [SerializeField] int currentPoints;
    [SerializeField] GameObject stick;
    private int hitsBall=0;

    // Update is called once per framea
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject == stick)
        {
            hitsBall++;
            audioBall.Play();
        }
        
        else return;

        if (hitsBall > 1 && currentPoints > 1 )
        {
            currentPoints--;
            PointsText.text = currentPoints.ToString();
        }
        hitsBallText.text=hitsBall.ToString();

    }
    public int GetPoint()
    {
        PointsText.text = currentPoints.ToString();
        return currentPoints;
    }
}
