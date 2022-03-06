
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    void Update()
    {
        Vector3 temp=new Vector3(transform.position.x,transform.position.y,player.position.z-50f);
        transform.position = temp;
    }
}
