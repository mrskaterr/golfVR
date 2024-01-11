using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarllRevert : MonoBehaviour
{
    Vector3 startPosition;
    [SerializeField] GameObject testballRAMP;
    [SerializeField] List <Collider> colls;
    [SerializeField] GameObject Stick;

    void Start()
    {
        startPosition = transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject==Stick || testballRAMP.gameObject==collision.gameObject)
        {
            Debug.Log("To kij lub rampa");
            return;
        }
        for (int i = 0; i < colls.Count; i++)
        {
            if (collision.gameObject == colls[i].gameObject)
            {
                Debug.Log("To mapa");
                return;
            }
        }
        Debug.Log("To  NIE mapa!");

        transform.position = startPosition;
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

}
