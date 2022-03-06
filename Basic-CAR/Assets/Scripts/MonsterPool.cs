using UnityEngine;
using System.Collections;

public class MonsterPool : MonoBehaviour
{
    //variables names used in this script
    public GameObject monsterPrefab;
    public int monsterPoolSize = 5;
    public float spawnRate = 5f;
    public float monsterMin = -4.8f;     //for monster to remain within road horizontally                               
    public float monsterMax = 4.8f;
    private GameObject[] monsters;      // this is an array of gameobjects                             
    private int currentmonster = 0;

    private Vector2 objectPoolPosition = new Vector2(-15, -25);    //this is a random position for monsters to be placed before transformation  

    private float timeSinceLastSpawned;


    void Start()
    {
        timeSinceLastSpawned = 0f;
        monsters = new GameObject[monsterPoolSize];  //construct the empty array of size monsterpoolsize
        for (int i = 0; i < monsterPoolSize; i++)
        {
            //fill the array with objects constructed from the prefab object
            monsters[i] = (GameObject)Instantiate(monsterPrefab, objectPoolPosition, Quaternion.identity);
        }
    }



    void Update()
    {
        if (Input.GetKey(KeyCode.W)) //if w key is pressed time will increment
            timeSinceLastSpawned += Time.deltaTime;

        if (Controller.instance.gameOver == false && timeSinceLastSpawned >= spawnRate) //if sufficient time has passed and game is not over yet
        {
            timeSinceLastSpawned = 0f;                                    //reset time
            float spawnXPosition = Random.Range(monsterMin, monsterMax);  //Set a random X position for the monster
            float spawnYPosition = Random.Range(15f, 25f);                //Set a random Y position for the monster

            //set the current monster to that position.
            monsters[currentmonster].transform.position = new Vector2(spawnXPosition, spawnYPosition); 
             currentmonster++;                     // move to next monster in array
            if (currentmonster >= monsterPoolSize) //reset index if out of bound
            {
                currentmonster = 0;
            }
        }
    }
}