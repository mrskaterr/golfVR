using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testball : MonoBehaviour
{

    void Update()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.right, ForceMode.Force);
    }
}
