using UnityEngine.SceneManagement;
using UnityEngine;

public class FinalGem : MonoBehaviour
{
    void OnTriggerEnter(Collider n)
    {
        if (n.gameObject.tag == "Player")
        {
            
            SceneManager.LoadScene("Credits");
        }
    }
}
