using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();//Get and store a reference to the Rigidbody2D attached to this GameObject.
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W)) //if the user presses w key
            rb2d.velocity = new Vector2(0, Controller.instance.scrollSpeed); //start moving the object this script is attached to
        else
            rb2d.velocity = new Vector2(0, 0); //otherwise no movement
        if (Controller.instance.gameOver == true) // If the game is over, stop scrolling.
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}