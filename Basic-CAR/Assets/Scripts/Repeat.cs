using UnityEngine;
using System.Collections;

public class Repeat : MonoBehaviour
{
    private BoxCollider2D groundCollider;        //This stores a reference to the collider attached to the Ground.
    private float groundVLength;        //A float to store the Y-axis length of the collider2D attached to the Ground GameObject.

    //Awake is called before Start.
    private void Awake()
    { 
       groundCollider = GetComponent<BoxCollider2D>();//Get and store a reference to the collider2D attached to Ground.
       groundVLength = groundCollider.size.y;  //Store the size of the collider along the Y axis (its length in units).
    }

    //Update runs once per frame
    private void Update()
    { 
        if (transform.position.y < -groundVLength - 5f) //if the object has scrolled down sufficeitly
        { 
        RepositionBackground(); //call reposition function
        }
    }

    //Moves the object this script is attached to above in order to create our looping background effect.
    private void RepositionBackground()
    {
        Vector2 groundOffSet = new Vector2(0, groundVLength * 2f); //store the value that we want our BG to repositon to.
        transform.position = groundOffSet; // transform the object to value store in the groundOffset
    }
}