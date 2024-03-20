using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class lives : MonoBehaviour
{
    private int playerLives = 5;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("spike"))
        {
            playerLives--;
            Debug.Log("Lives: " + playerLives);      
        }
    }
    
}

