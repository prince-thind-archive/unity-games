using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    public float resetOffset;
    public float speed;
    public float resetTarget;

    // Update is called once per frame
    void Update()
    {
        transform.position=Vector3.MoveTowards(transform.position,target.transform.position,speed);
        if(transform.position.x>resetTarget && resetTarget>0)
        {
            transform.position=(new Vector3(transform.position.x+resetOffset,transform.position.y,transform.position.z));
        }
        else if(transform.position.x<resetTarget && resetTarget<0)
        {
            transform.position=(new Vector3(transform.position.x+resetOffset,transform.position.y,transform.position.z));
        }
    }
}
