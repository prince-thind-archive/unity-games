using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other) // if coin collides with something execute the next code
    {
        if (other.name == "Car") //if the object colliding has the name as "car" then execute the next code
        {
           
           Controller.instance.CarScored(); //execute carscored fucntion from Controller script
            transform.position=new Vector2(-30, -30); //move the coin away from the screen
        }
    }
}