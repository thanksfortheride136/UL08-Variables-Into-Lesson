using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class appleCounter : MonoBehaviour
{
    public float score;
    public TextMeshProUGUI UIScore;

    // Start is called before the first frame update
    void Start()
    {
        UIScore.text = "Score:" + " " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "apple")
        {
            score += 1;
            UIScore.text = "Score:" + " " + score;
        }
    }
}
