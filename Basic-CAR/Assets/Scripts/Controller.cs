using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public static Controller instance;    //A reference to our game control script so we can access it statically.
    public Text scoreText;                 //A reference to the UI text component that displays the player's score.
    public GameObject gameOvertext;        //A reference to the object that displays the text which appears when the player dies.
    private int score = 0;                 //The player's score.
    public bool gameOver = false;          //Is the game over?
    public float scrollSpeed = -5f;        //scroll speed


    void Awake()
    {
        if (instance == null)               //If we don't currently have a game control...
            instance = this;                //...set this one to be it...
        else if (instance != this)          //...otherwise...
            Destroy(gameObject);             //...destroy this one because it is a duplicate.
    }

    void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0))            //If the game is over and the player has pressed some input...
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   //...reload the current scene
        }
    }

    public void CarScored()
    {
        if (gameOver)    //no scoring while game is over
            return;
        score++;         //othrwise increase score
        scoreText.text = "Score: " + score.ToString();  //displaying the score text.
    }

    public void CarDied()
    {
        gameOvertext.SetActive(true);   // Activate the game over text
        gameOver = true;                //Set the game to be over.
    }
}