using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioposition : MonoBehaviour
{
    [SerializeField] AudioSource aaudio;
    private Vector3 lastpos;
    void Start()
    {
        lastpos=transform.position;
    }

    void Update()
    {
        if (transform.position != lastpos)
            aaudio.Play();
        lastpos = transform.position;
    }
}
