
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private bool gameEnded = false;
    public GameObject uiobject;
    public void GameClose()
    {
        if (gameEnded == false)
        {
          //  Debug.Log("gameover");
            Invoke("Restart",2);

        }
        
    }

    public void Restart()
    {
        //Debug.Log("restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NewLevel()
    {
        if (gameEnded == false)
        {
            uiobject.SetActive(true);
            Invoke("LoadStage", 2);
        }
    }

    void LoadStage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    
}
