
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardPush;
    public float sidePush;
    //public GameController script;
    
    void FixedUpdate()
    {
        
        rb.AddForce(0,0,forwardPush*Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidePush*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidePush*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameController>().GameClose();
         // script.GameClose();
        }
    }
}
