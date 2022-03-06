//usual imports for unity
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is our main class and is always same after the script name.
//it also always inherits from the monobehavior class.
public class Car_Control : MonoBehaviour
{
    private Rigidbody2D rb2d;  // rbd2 is a object of type Rigidbody, later we'll do all modifications on rb2d
    private bool isDead = false; // this variable checks if the car has hit anything or not
    public KeyCode moveLeft = KeyCode.A;
    public KeyCode moveRight = KeyCode.D; // these are just names for keys. we use these later in this script
    public float speed = 10.0f;  //here are some variables for car speed and the bound that car should not exceed.
    public float bound = 5.0f;  // bound is equal to visible road length.

    void Start()  //start runs once in the beginning
    {
        rb2d = GetComponent<Rigidbody2D>(); // we attach rb2d to our car object
    }

    void OnTriggerEnter2D(Collider2D other) // when car strikes something, name the striking object "other" and execute the code following
    {
        if (other.gameObject.CompareTag("Monster")) // if 'other' has  the tag monster
        {
            rb2d.velocity = Vector2.zero; //car velocity=0
            isDead = true; //set dead to true
            Controller.instance.CarDied(); //execute cardied function from the Controller script and an instance as an object of the that class.
        }

    }

    void Update() // this runs every frame
    {
        var vel = rb2d.velocity; // var means auto type rb2d.velocity return vector2 datatype with x and y velocity of the rb2d object .
        if (!isDead) // if car not dead
        {
            if (Input.GetKey(moveLeft)) //if players clicks left
            {
                vel.x = -speed; //move car to left
            }
            else if (Input.GetKey(moveRight))//if players clicks rigth
            {
                vel.x = speed;//move car to right
            }
            else //if players clicks nothing
            {
                vel.x = 0;// don't move the car
            }
            rb2d.velocity = vel; //assign vel vector2 to rb2d velocity
        }
        else //if car is dead
        {
            vel.x = 0; //velocity should be zero
            rb2d.velocity = vel;//assign vel vector2 to rb2d velocity
        }

            var pos = transform.position; //store cordinates of car in pos variable
        if (pos.x > bound) //if car out of bound
        {
            pos.x = bound; //repostion car
        }
        else if (pos.x < -bound) //if car out of bound
        {
            pos.x = -bound; //repostion car
        }
        transform.position = pos; //assign pos to actual position of car
    }
        
    }
   

