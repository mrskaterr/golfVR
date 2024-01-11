using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    [SerializeField] Text hitsBallText;
    [SerializeField] Text PointsText;
    [SerializeField] int currentPoints=10;
    [SerializeField] GameObject stick;
    private int hitsBall=0;

    // Update is called once per framea
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject == stick)
        {
            hitsBall++;
        }
        else return;

        if (hitsBall > 1 && currentPoints > 1 )
        {
            currentPoints--;
        }
        hitsBallText.text=hitsBall.ToString();
        PointsText.text=currentPoints.ToString();
    }
}
