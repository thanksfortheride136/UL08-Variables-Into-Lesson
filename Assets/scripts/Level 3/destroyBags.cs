using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class destroyBags : MonoBehaviour
{
    public static int bagsCollected;
    // Update is called once per frame
    void Update()
    {
        // Update logic (if any) goes here
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bag")
        {
            Destroy(collision.gameObject);
            bagsCollected ++;
        }
    }
}


