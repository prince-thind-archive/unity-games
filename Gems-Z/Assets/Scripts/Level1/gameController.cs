using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public  bool gamefinish = false;
    private int count = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gem")
        {
            count++;
            other.gameObject.SetActive(false);
        }
        if (count == 2)
            gamefinish = true;
        
        if (gamefinish)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("Level2");
        }
           
    }
}
