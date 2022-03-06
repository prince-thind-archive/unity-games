using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour {

    public GameObject[] waypoints;
    int i = 0;
    public float speed;
    float minDistance = 1;
	
	void Update () {
		if(Vector3.Distance(waypoints[i].transform.position, transform.position) < minDistance)
        {
            i++;
            if (i >= waypoints.Length)
            {
                i = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[i].transform.position, Time.deltaTime * speed);

    }


}