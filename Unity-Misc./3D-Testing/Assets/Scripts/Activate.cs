using UnityEngine;
using System.Collections;

public class Activate : MonoBehaviour
{
    public GameObject gm;
    private void OnTriggerEnter(Collider other)
    {
        gm.SetActive(false);

    }

}