using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
   void OnTriggerEnter(Collider n)
    {
        if (n.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("gameover");
        }
    }
}
