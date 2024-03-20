using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class changePosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //if touching certain sprite, decrease lives by 1
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("spike"))
        {
            Vector3 newPos = changePos(-4.58f, -.064f, 0f);
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
                if (rb != null) 
                {
                    rb.velocity = Vector3.zero;
                }
        }
    }

    public Vector3 changePos(float x, float y, float z)
    {
        return transform.position = new Vector3(x, y, 0f);
    }
    
}
