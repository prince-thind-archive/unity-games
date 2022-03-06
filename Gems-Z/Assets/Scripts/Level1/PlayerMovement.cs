using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    Vector3 velocity;
   
   void Update()
    {
        
        float x= Input.GetAxis("Horizontal");
        float z= Input.GetAxis("Vertical");
        Vector3 move= transform.right * x + transform.forward * z;
        controller.Move(move * speed *Time.deltaTime);
        velocity.y = -9f;
        controller.Move(velocity*Time.deltaTime);


    }
}